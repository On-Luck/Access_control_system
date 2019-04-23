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
using System.Globalization;


namespace AccessControlSystem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.login_tableTableAdapter.Fill(this.accessControlSystemDataSet.Login_table, textBoxLogin.Text, textBoxPassword.Text);
            if (this.login_tableBindingSource.Count == 0)
            {
                MessageBox.Show("Введены некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (((string)ConfigurationManager.AppSettings["Role"].ToLower()).Equals("security"))
                {
                    this.Hide();
                    FormSecurity frm = new FormSecurity();
                    frm.ShowDialog();
                    this.Close();
                }
                else if (((string)ConfigurationManager.AppSettings["Role"].ToLower()).Equals("administrator"))
                {
                    this.Hide();
                    FormAdmin frm = new FormAdmin();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка получения роли. Приложение будет остановлено.\nПроверьте настройки приложения и перезапустите его.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.login_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accessControlSystemDataSet);

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
