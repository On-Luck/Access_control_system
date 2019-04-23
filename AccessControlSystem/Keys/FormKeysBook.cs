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
    public partial class FormKeysBook : Form
    {
        int id_worker_visitor = -1;
        string worker_visitor = "";

        public FormKeysBook()
        {
            InitializeComponent();
            this.view_keysDataGridView.Columns["ColumnAdd"].Visible = false;
        }
        public FormKeysBook(int id_worker_visitor, string worker_visitor)
        {
            InitializeComponent();
            this.view_keysDataGridView.Columns["ColumnAdd"].Visible = true;
            this.id_worker_visitor = id_worker_visitor;
            this.worker_visitor = worker_visitor;
        }

        private void FormKeysBook_Load(object sender, EventArgs e)
        {
            this.view_keysTableAdapter.Fill(this.accessControlSystemDataSet.View_keys);
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            this.view_keysBindingSource.Filter = "";
            this.view_keysTableAdapter.Fill(this.accessControlSystemDataSet.View_keys);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string filtrString = "";
            long _checked = 0;
            foreach (Control cb in panelFindKey.Controls)
            {
                if (cb is CheckBox)
                {
                    if (((CheckBox)cb).Checked)
                    {
                        if (_checked != 0)
                            filtrString += @" AND";

                        switch (cb.Name)
                        {
                            case "checkBoxType":
                                filtrString += string.Format(" Name LIKE '%{0}%'", textBoxType.Text);
                                break;
                            case "checkBoxValue":
                                filtrString += string.Format(" Key_value LIKE '%{0}%'", textBoxValue.Text);
                                break;
                            case "checkBoxStatus":
                                filtrString += string.Format(" Status LIKE '%{0}%'", textBoxStatus.Text);
                                break;
                        }
                        _checked++;
                    }
                }
            }
            this.view_keysBindingSource.Filter = filtrString;
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.view_keysBindingSource.Position = this.view_keysDataGridView.CurrentRow.Index;
                    this.keysTableAdapter.DeleteQuery(Convert.ToInt32(((DataRowView)this.view_keysBindingSource.Current).Row["ID_key"].ToString()));
                    MessageBox.Show("Запись удалена", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления!\nОбратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            FormKeysAddEdit frmEditKey = new FormKeysAddEdit(Convert.ToInt32(((DataRowView)this.view_keysBindingSource.Current).Row["ID_key"].ToString()),
               ((DataRowView)this.view_keysBindingSource.Current).Row["Key_value"].ToString(),
               Convert.ToInt32(((DataRowView)this.view_keysBindingSource.Current).Row["ID_type"].ToString()),
               Convert.ToInt32(((DataRowView)this.view_keysBindingSource.Current).Row["ID_status"].ToString()));
            frmEditKey.ShowDialog();
            this.view_keysTableAdapter.Fill(this.accessControlSystemDataSet.View_keys);
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            FormKeysAddEdit frmAddKey = new FormKeysAddEdit();
            frmAddKey.ShowDialog();
            this.view_keysTableAdapter.Fill(this.accessControlSystemDataSet.View_keys);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.view_keysBindingSource.Filter = "";
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) return;
            else
                if ((((TextBox)sender).Name == "textBoxValue") && Char.IsDigit(e.KeyChar))
                    return;
                else
                    e.Handled = true;
        }

        private void view_keysDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (id_worker_visitor != -1)
            {
                try
                {
                    var senderGrid = (DataGridView)sender;

                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                        e.RowIndex >= 0)
                    {
                        FormAnchoredKeysAddEdit frmAncAdd = new FormAnchoredKeysAddEdit(id_worker_visitor, worker_visitor, Convert.ToInt32(((DataRowView)this.view_keysBindingSource.Current).Row["ID_key"].ToString()), -1, null, null, null, null);
                        frmAncAdd.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка добавления записи.\nТекст ошибки:" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
            
        }
    }
}
