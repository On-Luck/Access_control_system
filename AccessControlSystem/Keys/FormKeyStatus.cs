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
    public partial class FormKeyStatus : Form
    {
        public FormKeyStatus()
        {
            InitializeComponent();
        }

        private void key_statusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.key_statusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accessControlSystemDataSet);

        }

        private void FormKeyStatus_Load(object sender, EventArgs e)
        {
            this.key_statusTableAdapter.Fill(this.accessControlSystemDataSet.Key_status);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.key_statusBindingSource.Filter = "";
        }

        private void buttonFindPosition_Click(object sender, EventArgs e)
        {
            this.key_statusBindingSource.Filter = "Status LIKE '%" + textBoxFindName.Text + "%' AND Description LIKE '%" + textBoxFindDescription.Text + "%'";
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            this.key_statusTableAdapter.Fill(this.accessControlSystemDataSet.Key_status);
        }
    }
}
