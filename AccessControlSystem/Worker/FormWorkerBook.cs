using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AccessControlSystem
{
    public partial class FormWorkerBook : Form
    {
        MemoryStream ms;

        public FormWorkerBook()
        {
            InitializeComponent();
        }

        private void FormWorkerBook_Load(object sender, EventArgs e)
        {
            this.view_workerTableAdapter.Fill(this.accessControlSystemDataSet.View_worker);

        }

        private void toolStripButtonAddWorker_Click(object sender, EventArgs e)
        {
            FormWorker_AddEdit frmWorAdd = new FormWorker_AddEdit();
            frmWorAdd.ShowDialog();
            this.view_workerTableAdapter.Fill(this.accessControlSystemDataSet.View_worker);
        }

        private void toolStripButtonEditWorker_Click(object sender, EventArgs e)
        {
            FormWorker_AddEdit frmWorEdd = new FormWorker_AddEdit(
                Convert.ToUInt32(((DataRowView)this.view_workerBindingSource.Current).Row["ID_worker"].ToString()),
               ((DataRowView)this.view_workerBindingSource.Current).Row["Second_name"].ToString(),
               ((DataRowView)this.view_workerBindingSource.Current).Row["Name"].ToString(),
               ((DataRowView)this.view_workerBindingSource.Current).Row["Patronymic"].ToString(),
              pictureBoxWorker.Image,
               ((DataRowView)this.view_workerBindingSource.Current).Row["Phone"].ToString(),
               ((DataRowView)this.view_workerBindingSource.Current).Row["Email"].ToString(),
               ((DataRowView)this.view_workerBindingSource.Current).Row["Passport"].ToString(),
               ((DataRowView)this.view_workerBindingSource.Current).Row["Education"].ToString(),
               Convert.ToUInt32(((DataRowView)this.view_workerBindingSource.Current).Row["ID_department"].ToString()),
               Convert.ToUInt32(((DataRowView)this.view_workerBindingSource.Current).Row["ID_position"].ToString())
            );
            frmWorEdd.ShowDialog();
            this.view_workerTableAdapter.Fill(this.accessControlSystemDataSet.View_worker);
        }

        private void toolStripButtonDeleteWorker_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.view_workerBindingSource.Position = this.view_workerDataGridView.CurrentRow.Index;
                    this.workerTableAdapter.DeleteQuery(Convert.ToInt32(((DataRowView)this.view_workerBindingSource.Current).Row["ID_worker"].ToString()));
                    MessageBox.Show("Запись удалена", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления!\nОбратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string filtrString = "";
            long _checked = 0;
            foreach (Control cb in panelFindWorker.Controls)
            {
                if (cb is CheckBox)
                {
                    if (((CheckBox)cb).Checked)
                    {
                        if (_checked != 0)
                            filtrString += @" AND";

                        switch (cb.Name)
                        {
                            case "checkBoxSname":
                                filtrString += string.Format(" Second_name LIKE '%{0}%'", textBoxSname.Text);
                                break;
                            case "checkBoxName":
                                filtrString += string.Format(" Name LIKE '%{0}%'", textBoxName.Text);
                                break;
                            case "checkBoxPat":
                                filtrString += string.Format(" Patronymic LIKE '%{0}%'", textBoxPat.Text);
                                break;
                            case "checkBoxPhone":
                                filtrString += string.Format(" Phone LIKE '%{0}%'", textBoxPh.Text);
                                break;
                            case "checkBoxEmail":
                                filtrString += string.Format(" Email LIKE '%{0}%'", textBoxEmail.Text);
                                break;
                            case "checkBoxPas":
                                filtrString += string.Format(" Passport LIKE '%{0}%'", textBoxPas.Text);
                                break;
                            case "checkBoxEdu":
                                filtrString += string.Format(" Education LIKE '%{0}%'", textBoxEdu.Text);
                                break;
                            case "checkBoxDep":
                                filtrString += string.Format(" Dep LIKE '%{0}%'", textBoxDep.Text);
                                break;
                            case "checkBoxPos":
                                filtrString += string.Format(" Pos LIKE '%{0}%'", textBoxPos.Text);
                                break;
                        }
                        _checked++;
                    }
                }
            }
            this.view_workerBindingSource.Filter = filtrString;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) return;
            else
                if (((((TextBox)sender).Name == "textBoxEdu") || (((TextBox)sender).Name == "textBoxPos") || ((TextBox)sender).Name == "textBoxDep") && Char.IsWhiteSpace(e.KeyChar))
                    return;
                else 
                    e.Handled = true;
        }
        private void textBoxDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) return;  
            else
                e.Handled = true;
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            this.view_workerBindingSource.RemoveFilter();
            this.view_workerTableAdapter.Fill(this.accessControlSystemDataSet.View_worker);
        }

        private void buttonRefresh_Click_1(object sender, EventArgs e)
        {
            this.view_workerBindingSource.RemoveFilter();
        }

        private void view_workerDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!DBNull.Value.Equals(((DataRowView)this.view_workerBindingSource.Current).Row["Photo"]))
            {
                ms = new MemoryStream();
                byte[] pic = (byte[])((DataRowView)this.view_workerBindingSource.Current).Row["Photo"];

                ms.Write(pic, 0, pic.Length);
                pictureBoxWorker.Image = Image.FromStream(ms);
            }
            else pictureBoxWorker.Image = Properties.Resources.if_image_cancel_103591 as Bitmap;
        }

        private void view_workerDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if(view_workerDataGridView.RowCount != 0)
            if (!DBNull.Value.Equals(((DataRowView)this.view_workerBindingSource.Current).Row["Photo"]))
            {
                ms = new MemoryStream();
                byte[] pic = (byte[])((DataRowView)this.view_workerBindingSource.Current).Row["Photo"];

                ms.Write(pic, 0, pic.Length);
                pictureBoxWorker.Image = Image.FromStream(ms);
            }
            else pictureBoxWorker.Image = Properties.Resources.if_image_cancel_103591 as Bitmap;
        }

        private void toolStripButtonBindKey_Click(object sender, EventArgs e)
        {
            FormAnchoredKeys frmAncKeys = new FormAnchoredKeys("worker", Convert.ToInt32(((DataRowView)this.view_workerBindingSource.Current).Row["ID_worker"].ToString()));
            frmAncKeys.ShowDialog();
        }
    }
}
