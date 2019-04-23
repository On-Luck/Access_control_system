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
    public partial class FormPosition : Form
    {
        public FormPosition()
        {
            InitializeComponent();
        }

        private void positionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.positionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accessControlSystemDataSet);

        }

        private void FormPosition_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accessControlSystemDataSet.Position". При необходимости она может быть перемещена или удалена.
            this.positionTableAdapter.Fill(this.accessControlSystemDataSet.Position);

        }

        private void buttonFindPosition_Click(object sender, EventArgs e)
        {
            this.positionBindingSource.Filter = "Name LIKE '%" + textBoxFindPosition.Text + "%'";
        }

        private void textBoxFindPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.positionBindingSource.Filter = "";
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            this.positionBindingSource.Filter = "";
            this.positionTableAdapter.Fill(this.accessControlSystemDataSet.Position);
        }
    }
}
