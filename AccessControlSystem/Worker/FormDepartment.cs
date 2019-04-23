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
    public partial class FormDepartment : Form
    {
        public FormDepartment()
        {
            InitializeComponent();
        }

        private void departmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accessControlSystemDataSet);

        }

        private void FormPosition_Load(object sender, EventArgs e)
        {
            this.departmentTableAdapter.Fill(this.accessControlSystemDataSet.Department);
        }

        private void buttonFindPosition_Click(object sender, EventArgs e)
        {
            this.departmentBindingSource.Filter = "Name LIKE '%" + textBoxFindDepartment.Text + "%'";
        }

        private void FormDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            this.departmentBindingSource.Filter = "";
            this.departmentTableAdapter.Fill(this.accessControlSystemDataSet.Department);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.departmentBindingSource.Filter = "";
        }
    }
}
