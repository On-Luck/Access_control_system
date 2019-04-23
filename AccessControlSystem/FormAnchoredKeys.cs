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
    public partial class FormAnchoredKeys : Form
    {
        ArduinoRW arduinoRW;
        string TempUID = "", oldKey_value = "";
        int id_key;
        Thread arduinoThread;

        int id_worker_visitor;
        string whoIs = "";

        public FormAnchoredKeys(string whoIs, int id_worker_visitor)
        {
            InitializeComponent();
            this.whoIs = whoIs;
            this.id_worker_visitor = id_worker_visitor;

            GetNewArduinoThread();
        }

        private void GetNewArduinoThread()
        {
            this.arduinoRW = new ArduinoRW();
            this.arduinoRW.ArduinoPortClose += this._arduinoRW_ArduinoPortClose;
            this.arduinoRW.ArduinoReadUID += this._arduinoRW_ArduinoReadUID;
            this.arduinoThread = new Thread(arduinoRW.Start);
            this.arduinoThread.IsBackground = true;
            this.arduinoThread.Start();
        }

        private void WorkerLoad(int id_worker)
        {
            this.view_key_user_keyTableAdapter.FillByWorker(this.accessControlSystemDataSet.View_key_user_key, id_worker);
        }

        private void VisitorLoad(int id_visitor)
        {
            this.view_key_user_keyTableAdapter.FillByVisitor(this.accessControlSystemDataSet.View_key_user_key, id_visitor);
        }

        private void FormAnchoredKeys_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accessControlSystemDataSet.Key_user". При необходимости она может быть перемещена или удалена.
            this.key_userTableAdapter.Fill(this.accessControlSystemDataSet.Key_user);
            if (whoIs.Equals("worker"))
            {
                this.view_key_user_keyDataGridView.Columns["dataGridViewTextBoxColumn5"].Visible = false; // убираем отображение колонки "Цель визита"
                this.WorkerLoad(id_worker_visitor);
            }
            else
                this.VisitorLoad(id_worker_visitor);
        }

        private void buttonReadKey_Click(object sender, EventArgs e)
        {
            if (this.arduinoThread.ThreadState != ThreadState.Stopped)
            {
                if (!this.arduinoThread.IsAlive)
                {
                    this.arduinoThread.Start();
                }
            }
            else
            {
                GetNewArduinoThread();
               
            }
            this.arduinoRW.ReadUID();
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
                                case "checkBoxKeyNum":
                                    filtrString += string.Format(" CONVERT(ID_key, 'System.String') LIKE '%{0}%'", textBoxKeyNum.Text);
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
                this.view_key_user_keyBindingSource.Filter = filtrString;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска. Проверьте введеные данные.\nТекст ошибки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.view_key_user_keyBindingSource.RemoveFilter();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            if (whoIs.Equals("worker"))
                this.WorkerLoad(id_worker_visitor);
            else
                this.VisitorLoad(id_worker_visitor);
        }

        private void view_key_user_keyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            if (this.arduinoThread.IsAlive)
            {
                this.arduinoRW.Cancel();
                this.arduinoThread.Join();
            }

            FormKeysBook frmkeybook = new FormKeysBook (id_worker_visitor, whoIs);
            frmkeybook.ShowDialog();
            this.toolStripButtonRefresh.PerformClick();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (this.arduinoThread.IsAlive)
            {
                this.arduinoRW.Cancel();
                this.arduinoThread.Join();
            }
            FormAnchoredKeysAddEdit frmAncEdit = new FormAnchoredKeysAddEdit(id_worker_visitor, whoIs, 
                Convert.ToInt32(((DataRowView)this.view_key_user_keyBindingSource.Current).Row["ID_key"].ToString()), 
                Convert.ToInt32(((DataRowView)this.view_key_user_keyBindingSource.Current).Row["ID_user"].ToString()), 
                ((DataRowView)this.view_key_user_keyBindingSource.Current).Row["Date_of_issue"].ToString(),
                ((DataRowView)this.view_key_user_keyBindingSource.Current).Row["Date_of_start_action"].ToString(),
                ((DataRowView)this.view_key_user_keyBindingSource.Current).Row["Date_expiration"].ToString(),
                (whoIs.Equals("worker") ? null : ((DataRowView)this.view_key_user_keyBindingSource.Current).Row["Visit_purpose"].ToString()));
            frmAncEdit.ShowDialog();
            this.toolStripButtonRefresh.PerformClick();
        }

        private void FormAnchoredKeys_FormClosing(object sender, FormClosingEventArgs e)
        {
                this.arduinoRW.Cancel();
                this.arduinoThread.Join();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.key_userTableAdapter.DeleteQuery(Convert.ToInt32(((DataRowView)this.view_key_user_keyBindingSource.Current).Row["ID_user"].ToString()));
                    MessageBox.Show("Запись удалена", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.toolStripButtonRefresh.PerformClick();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления!\nОбратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonRegulation_Click(object sender, EventArgs e)
        {
            FormKeyUserRegulationRoom frmRegRoom = new FormKeyUserRegulationRoom(Convert.ToInt32(((DataRowView)this.view_key_user_keyBindingSource.Current).Row["ID_user"].ToString()));
            frmRegRoom.ShowDialog();

        }
    }
}
