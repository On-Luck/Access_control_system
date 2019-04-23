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
    public partial class FormKeysAddEdit : Form
    {
        ArduinoRW arduinoRW;
        string TempUID = "", oldKey_value = "";
        int id_key;
        Thread arduinoThread;

        public FormKeysAddEdit()
        {
            InitializeComponent();
        }

        public FormKeysAddEdit(int id_key, string key_value, int id_type, int id_status)
        {
            InitializeComponent();
            this.oldKey_value = key_value;
            this.textBoxKey.Text = key_value;
            this.comboBoxKeyStatus.SelectedValue = id_status;
            this.comboBoxKeyType.SelectedValue = id_type;
            this.id_key = id_key;
            this.Text = "Изменение данных о ключе";
            this.buttonKeyAddEdit.Text = "Изменить запись";
        }

        private void FormKeysAddEdit_Load(object sender, EventArgs e)
        {
            this.key_typeTableAdapter.Fill(this.accessControlSystemDataSet.Key_type);
            this.key_statusTableAdapter.Fill(this.accessControlSystemDataSet.Key_status);
            this.keysTableAdapter.Fill(this.accessControlSystemDataSet.Keys);

            arduinoRW = new ArduinoRW();

            arduinoRW.ArduinoPortClose += _arduinoRW_ArduinoPortClose;
            arduinoRW.ArduinoReadUID += _arduinoRW_ArduinoReadUID;

            arduinoThread = new Thread(arduinoRW.Start);
            arduinoThread.IsBackground = true;
            arduinoThread.Start();
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
                TempUID = message.ToUpper().Trim(new Char[] { ' ', '\n', '\r' }).Substring(1); // Переводим символы в верхний регистр и удаляем пробельные символы, символ перевода строки и возврата каретки. Выделяем подстроку, содержащую UID (первый символ содержит ID RFID-ридера)
                TempUID = TempUID.Replace(" ", "");
                if (MessageBox.Show("Найден ключ: \n" + TempUID + "\nИспользовать эти данные?", "Найден ключ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    textBoxKey.Text = TempUID;
                }
            };

            if (InvokeRequired)
                Invoke(action);
            else action();
        }

        private void buttonReadKey_Click(object sender, EventArgs e)
        {
            arduinoRW.ReadUID();
        }

        private void buttonKeyAddEdit_Click(object sender, EventArgs e)
        {
            bool can_we_do_that = true;
            foreach (Control txt in this.Controls)
            {
                if (txt is TextBox)
                {
                    if (((TextBox)txt).Text == String.Empty)
                        can_we_do_that = false;
                }
            }

            if (can_we_do_that)
            {
                if (this.Text.Equals("Изменение записи"))
                {
                    try
                    {
                        if (!this.oldKey_value.Equals(textBoxKey.Text))
                            if (this.keysBindingSource.Find("Key_value", textBoxKey.Text) != -1) throw new ArgumentException("Данный ключ уже присутствует в базе!");
                        this.keysTableAdapter.UpdateQuery(textBoxKey.Text, Convert.ToInt32(comboBoxKeyStatus.SelectedValue.ToString()), Convert.ToInt32(comboBoxKeyType.SelectedValue.ToString()), id_key);
                        MessageBox.Show("Запись изменена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка изменения записи. Проверьте введеные данные.\nТекст ошибки:" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        
                        if (this.keysBindingSource.Find("Key_value", textBoxKey.Text) != -1) throw new ArgumentException("Данный ключ уже присутствует в базе!");
                        this.keysTableAdapter.InsertQuery(textBoxKey.Text, Convert.ToInt32(comboBoxKeyStatus.SelectedValue.ToString()), Convert.ToInt32(comboBoxKeyType.SelectedValue.ToString()));
                        MessageBox.Show("Запись добавлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавления записи. Проверьте введеные данные.\nТекст ошибки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Проверьте введенные значения.\nВсе поля должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormKeysAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.arduinoRW.Cancel();
            this.arduinoThread.Join();
        }
    }
}
