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
    public partial class FormVisitorBook : Form
    {
        MemoryStream ms;
        public FormVisitorBook()
        {
            InitializeComponent();
        }

        private void FormVisitorBook_Load(object sender, EventArgs e)
        {
            this.visitorTableAdapter.Fill(this.accessControlSystemDataSet.Visitor);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string filtrString = "";
            long _checked = 0;
            foreach (Control cb in panelFindVisitor.Controls)
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
                                filtrString += string.Format(" Phone LIKE '%{0}%'", textBoxPhone.Text);
                                break;
                            case "checkBoxPas":
                                filtrString += string.Format(" Passport LIKE '%{0}%'", textBoxPas.Text);
                                break;
                        }
                        _checked++;
                    }
                }
            }
            this.visitorBindingSource.Filter = filtrString;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBoxDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void toolStripButtonAddVisitor_Click(object sender, EventArgs e)
        {
            FormVisitorAddEdit frmVisEdd = new FormVisitorAddEdit();
            frmVisEdd.ShowDialog();
            this.visitorTableAdapter.Fill(this.accessControlSystemDataSet.Visitor);
        }

        private void toolStripButtonEditVisitor_Click(object sender, EventArgs e)
        {
            FormVisitorAddEdit frmVisEdd = new FormVisitorAddEdit(
                Convert.ToUInt32(((DataRowView)this.visitorBindingSource.Current).Row["ID_visitor"].ToString()),
               ((DataRowView)this.visitorBindingSource.Current).Row["Second_name"].ToString(),
               ((DataRowView)this.visitorBindingSource.Current).Row["Name"].ToString(),
               ((DataRowView)this.visitorBindingSource.Current).Row["Patronymic"].ToString(),
               ms != null ? Image.FromStream(ms) : Properties.Resources.if_image_cancel_103591 as Bitmap,
               ((DataRowView)this.visitorBindingSource.Current).Row["Phone"].ToString(),
               ((DataRowView)this.visitorBindingSource.Current).Row["Passport"].ToString()
               );
            frmVisEdd.ShowDialog();
            this.visitorTableAdapter.Fill(this.accessControlSystemDataSet.Visitor);
        }

        private void toolStripButtonDeleteVisitor_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.visitorBindingSource.Position = this.visitorDataGridView.CurrentRow.Index;
                    this.visitorTableAdapter.DeleteQuery(Convert.ToInt32(((DataRowView)this.visitorBindingSource.Current).Row["ID_visitor"].ToString()));
                    MessageBox.Show("Запись удалена", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления!\nОбратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void visitorDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!DBNull.Value.Equals(((DataRowView)this.visitorBindingSource.Current).Row["Photo"]))
            {
                ms = new MemoryStream();
                byte[] pic = (byte[])((DataRowView)this.visitorBindingSource.Current).Row["Photo"];

                ms.Write(pic, 0, pic.Length);
                pictureBoxVisitor.Image = Image.FromStream(ms);
            }
            else pictureBoxVisitor.Image = Properties.Resources.if_image_cancel_103591 as Bitmap;
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            this.visitorTableAdapter.Fill(this.accessControlSystemDataSet.Visitor);
            this.visitorBindingSource.Filter = "";
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.visitorBindingSource.Filter = "";
        }

        private void toolStripButtonBindKey_Click(object sender, EventArgs e)
        {
            FormAnchoredKeys frmAncKeys = new FormAnchoredKeys("visitor", Convert.ToInt32(((DataRowView)this.visitorBindingSource.Current).Row["ID_visitor"].ToString()));
            frmAncKeys.ShowDialog();
        }
    }
}
