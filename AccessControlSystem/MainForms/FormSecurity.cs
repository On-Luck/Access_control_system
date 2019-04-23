using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;
using System.IO;
using System.Globalization;


namespace AccessControlSystem
{
    public partial class FormSecurity : Form
    {
        int id_room;
        int id_user;
        int TimeClearTemp = 0;
        string message = "";
        Color color;
        MemoryStream ms;

        ArduinoRW arduinoRW;
        string TempUID = "";
        int TempReader = -1;
        string TempMessageArduino = "";
        Thread arduinoThread;

        public FormSecurity()
        {
            InitializeComponent();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelDate.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabelTime.Text = DateTime.Now.ToShortTimeString();
            if (TimeClearTemp == 50)
            {
                TempMessageArduino = String.Empty;
                TimeClearTemp = 0;
            } 
            TimeClearTemp++;
        }
        

        private void FormSecurity_Load(object sender, EventArgs e)
        {
            this.roomsTableAdapter.FillByName(this.accessControlSystemDataSet.Rooms, ConfigurationManager.AppSettings["Room"].ToString());

            Clear_the_Form();

            toolStripStatusLabelDate.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabelTime.Text = DateTime.Now.ToShortTimeString();
            this.labelObject.Text += ConfigurationManager.AppSettings["Room"].ToString();
            this.roomsBindingSource.MoveFirst();
            this.id_room = Convert.ToInt32(((DataRowView)this.roomsBindingSource.Current).Row["ID_room"].ToString());

            arduinoRW = new ArduinoRW();
            arduinoRW.ArduinoPortClose += _arduinoRW_ArduinoPortClose;
            arduinoRW.ArduinoReadUID += _arduinoRW_ArduinoReadUID;
            arduinoThread = new Thread(arduinoRW.Start);
            arduinoThread.IsBackground = true;
            arduinoThread.Start();
            Thread.Sleep(100);
            arduinoRW.ReadUID();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer() { Interval = 1000 };
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void _arduinoRW_ArduinoPortClose(bool errorEnd)
        {
            Action action = () =>
            {
                string message;

                if (errorEnd)
                {
                    message = "завершен с ошибкой";
                    MessageBox.Show("Поток чтения данных " + message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    message = "успешно завершен";
                    MessageBox.Show("Поток чтения данных " + message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            try
            { 
                if (InvokeRequired)
                    Invoke(action);
                else action();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void _arduinoRW_ArduinoReadUID(string message)
        {
            Action action = () =>
            {
                if (!TempMessageArduino.Equals(message))
                {
                    TempMessageArduino = message;
                    TempUID = message.ToUpper().Trim(new Char[] { ' ', '\n', '\r' }).Substring(1);
                    TempUID = TempUID.Replace(" ", "");
                    TempReader = Convert.ToInt32(message.Substring(0, 1));

                    CheckUser();
                }
            };

            try
            {
                if (InvokeRequired)
                    Invoke(action);
                else action();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            arduinoRW.ReadUID();
        }

        private void CheckUser()
        {
            this.id_user = -1;
            this.message = String.Empty;
            Clear_the_Form();
            string action = String.Empty;

            try
            {   // Поиск пользователя считанного ключа ключа
                this.view_key_userTableAdapter.FillByKey(this.accessControlSystemDataSet.View_key_user, TempUID, DateTime.Now.ToShortDateString());

                if (this.view_key_userBindingSource.Count <= 0)
                {
                    message = "Неизвестный пользователь ключа";
                    color = Color.Red;
                }
                else
                {
                    this.view_key_userBindingSource.MoveFirst();

                    //Заполнение формы данными о пользователе

                    this.labelStatus.Text = ((DataRowView)this.view_key_userBindingSource.Current).Row["Role"].ToString();
                    this.labelSname.Text = ((DataRowView)this.view_key_userBindingSource.Current).Row["Second_name"].ToString();
                    this.labelName.Text = ((DataRowView)this.view_key_userBindingSource.Current).Row["Name"].ToString();
                    this.labelPat.Text = ((DataRowView)this.view_key_userBindingSource.Current).Row["Patronymic"].ToString();
                    if (!DBNull.Value.Equals(((DataRowView)this.view_key_userBindingSource.Current).Row["Photo"]))
                    {
                        ms = new MemoryStream();
                        byte[] pic = (byte[])((DataRowView)this.view_key_userBindingSource.Current).Row["Photo"];

                        ms.Write(pic, 0, pic.Length);
                        pictureBoxPhoto.Image = Image.FromStream(ms);
                    }

                    this.id_user = Convert.ToInt32(((DataRowView)this.view_key_userBindingSource.Current).Row["ID_user"].ToString());

                    //Проверка допуска
                    this.view_user_regulation_roomTableAdapter.FillByRoomUser(this.accessControlSystemDataSet.View_user_regulation_room, this.id_room, this.id_user);

                    if (this.view_user_regulation_roomBindingSource.Count <= 0)
                    {
                        message = "Нет прав доступа";
                        color = Color.Red;
                    }
                    else
                    {
                        this.view_user_regulation_roomBindingSource.MoveFirst();

                        this.view_user_regulation_roomBindingSource.Filter = string.Format("Days_of_week LIKE '%{0}%' "
                        //AND Access_time_from <=  CONVERT ('{1}', 'System.TimeSpan') AND Access_time_to >= #{1}#"
                        , CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetAbbreviatedDayName(DateTime.Now.DayOfWeek));
                        //,  DateTime.Now.ToShortTimeString());

                        if (this.view_user_regulation_roomBindingSource.Count <=0)
                        {
                            message = "Отказано в доступе";
                            color = Color.Red;
                        }
                        else
                        {
                            message = "Доступ разрешен";
                            color = Color.Lime;
                        }
                    }
                    action = TempReader == 0 ? "Попытка входа. " : "Попытка выхода. ";
                }
                this.labelAccess.Text = message;
                this.labelAccess.BackColor = color;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка.\nТекст ошибки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!action.Equals(String.Empty))
            {
                arduinoRW.OpenTheGate();
                this.journalTableAdapter.InsertQuery(DateTime.Now, action + message, id_room, id_user);
            }
        }

        private void Clear_the_Form()
        {
            pictureBoxPhoto.Image = Properties.Resources.if_image_cancel_103591 as Bitmap;
            this.labelName.Text = this.labelPat.Text = this.labelSname.Text = this.labelStatus.Text = this.labelAccess.Text = "";
        }
        private void FormSecurity_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.arduinoRW.Cancel();
            this.arduinoThread.Join();
        }
    }
}
