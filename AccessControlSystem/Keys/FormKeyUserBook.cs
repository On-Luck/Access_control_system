using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace AccessControlSystem
{
    public partial class FormKeyUserBook : Form
    {
        ArduinoRW arduinoRW;
        string TempUID = "", oldKey_value = "";
        int id_key;
        Thread arduinoThread;

        public FormKeyUserBook()
        {
            InitializeComponent();
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
                TempUID = message.ToUpper().Trim(new Char[] { ' ', '\n', '\r' }).Substring(1); 
                TempUID = TempUID.Replace(" ", "");
                if (MessageBox.Show("Найден ключ: \n" + TempUID + "\nИспользовать эти данные?", "Найден ключ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    textBoxKey.Text = TempUID;
                }
                Thread.Sleep(200);
            };

            if (InvokeRequired)
                Invoke(action);
            else action();
        }

        private void FormKeyUser_Load(object sender, EventArgs e)
        {
            this.view_key_userTableAdapter.Fill(this.accessControlSystemDataSet.View_key_user);
            
            arduinoRW = new ArduinoRW();
            arduinoThread = new Thread(arduinoRW.Start);
            arduinoThread.IsBackground = true;
            arduinoRW.ArduinoPortClose += _arduinoRW_ArduinoPortClose;
            arduinoRW.ArduinoReadUID += _arduinoRW_ArduinoReadUID;
            arduinoThread.Start();
        }

        private void buttonReadKey_Click(object sender, EventArgs e)
        {
            
            arduinoRW.ReadUID();
        }

        private void FormKeyUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.arduinoRW.Cancel();
            this.arduinoThread.Join();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string filtrString = "";
            long _checked = 0;
            try
            {
                foreach (Control cb in panelFind.Controls)
                {
                    if (cb is CheckBox)
                    {
                        if (((CheckBox)cb).Checked)
                        {
                            if (_checked != 0)
                                filtrString += @" AND";

                            switch (cb.Name)
                            {
                                case "checkBoxStatus":
                                    filtrString += string.Format(" Role LIKE '%{0}%'", textBoxStatus.Text);
                                    break;
                                case "checkBoxSname":
                                    filtrString += string.Format(" Second_name LIKE '%{0}%'", textBoxSname.Text);
                                    break;
                                case "checkBoxName":
                                    filtrString += string.Format(" Name LIKE '%{0}%'", textBoxName.Text);
                                    break;
                                case "checkBoxPat":
                                    filtrString += string.Format(" Patronymic LIKE '%{0}%'", textBoxPat.Text);
                                    break;
                                case "checkBoxKeyNum":
                                    filtrString += string.Format(" ID_key LIKE '%{0}%'", textBoxKeyNum.Text);
                                    break;
                                case "checkBoxKey":
                                    filtrString += string.Format(" Key_value LIKE '%{0}%'", textBoxKey.Text);
                                    break;
                                case "checkBoxPerAct":
                                    if (dateTimePickerActTo.Value > dateTimePickerActFrom.Value)
                                        throw new ArgumentException("Дата окончания периода не может быть меньше даты начала периода!");
                                    filtrString += string.Format(" Date_of_start_action > '%{0:yyyy-MM-dd}%' AND Date_expiration <'%{1:yyyy-MM-dd}%'", dateTimePickerActFrom.Value, dateTimePickerActTo.Value);
                                    break;
                                case "checkBoxPerIssue":
                                    if (dateTimePickerIssueTo.Value > dateTimePickerIssueFrom.Value) throw new ArgumentException("Дата окончания периода не может быть меньше даты начала периода!");
                                    filtrString += string.Format(" Date_of_issue BETWEEN '%{0:yyyy-MM-dd}%' AND '%{1:yyyy-MM-dd}%'", dateTimePickerIssueFrom.Value, dateTimePickerIssueTo.Value);
                                    break;
                            }
                            _checked++;
                        }
                    }
                }
                this.view_key_userBindingSource.Filter = filtrString;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска. Проверьте введеные данные.\nТекст ошибки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.view_key_userBindingSource.RemoveFilter();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            this.view_key_userBindingSource.RemoveFilter();
            this.view_key_userTableAdapter.Fill(this.accessControlSystemDataSet.View_key_user);
        }
    }
}
