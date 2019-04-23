using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControlSystem
{
    public partial class FormAnchoredKeysAddEdit : Form
    {
        int id_worker_visitor, id_key, id_user;
        string worker_visitor;       

        public FormAnchoredKeysAddEdit(int id_worker_visitor, string worker_visitor, int id_key, int id_user, string dateIssue, string dateStartAction, string dateExpiration, string visitPurpose)
        {
            InitializeComponent();

            this.id_worker_visitor = id_worker_visitor;
            this.id_key = id_key;
            this.id_user = id_user;
            this.worker_visitor = worker_visitor;

            
            if (worker_visitor.Equals("worker"))
                this.richTextBoxVisitPurpose.Enabled = false;

            if(id_user != -1)
            {
                this.buttonAddEdit.Text = "Изменить";
                this.dateTimePickerDateOfIssue.Value = Convert.ToDateTime(dateIssue);
                this.dateTimePickerDateStartAction.Value = Convert.ToDateTime(dateStartAction);
                this.dateTimePickerDateExpiration.Value = Convert.ToDateTime(dateExpiration);
                this.richTextBoxVisitPurpose.Text = (visitPurpose == null ? "" : visitPurpose);
            }
        }

        private void buttonAddEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_user != -1)
                {
                    this.key_userTableAdapter.UpdateQuery(dateTimePickerDateOfIssue.Value.ToShortDateString(), dateTimePickerDateStartAction.Value.ToShortDateString(), richTextBoxVisitPurpose.Text, dateTimePickerDateExpiration.Value.ToShortDateString(), id_user);
                    MessageBox.Show("Запись изменена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (worker_visitor.Equals("worker"))
                        this.key_userTableAdapter.InsertWorkerQuery(id_key, dateTimePickerDateOfIssue.Value.ToShortDateString(), dateTimePickerDateStartAction.Value.ToShortDateString(), richTextBoxVisitPurpose.Text, dateTimePickerDateExpiration.Value.ToShortDateString(), id_worker_visitor);
                    else 
                        this.key_userTableAdapter.InsertVisitorQuery(id_key, dateTimePickerDateOfIssue.Value.ToShortDateString(), dateTimePickerDateStartAction.Value.ToShortDateString(), richTextBoxVisitPurpose.Text, dateTimePickerDateExpiration.Value.ToShortDateString(), id_worker_visitor);
                    MessageBox.Show("Запись добавлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка.\nТекст ошибки: " + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAnchoredKeysAddEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
