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
    public partial class FormKeyType : Form
    {
        public FormKeyType()
        {
            InitializeComponent();
        }

        private void key_typeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.key_typeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accessControlSystemDataSet);

        }

        private void FormKeyType_Load(object sender, EventArgs e)
        {
            this.key_typeTableAdapter.Fill(this.accessControlSystemDataSet.Key_type);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.key_typeBindingSource.Filter = "";
        }

        private void buttonFindPosition_Click(object sender, EventArgs e)
        {
            this.key_typeBindingSource.Filter = "Name LIKE '%" + textBoxFindName.Text + "%' AND Description LIKE '%" + textBoxFindDescription.Text + "%'";
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            this.key_typeTableAdapter.Fill(this.accessControlSystemDataSet.Key_type);

        }
    }
}
