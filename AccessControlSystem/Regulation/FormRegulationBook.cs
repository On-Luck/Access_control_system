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
    public partial class FormRegulationBook : Form
    {
        int id_room = -1;
        List<Int32> regList = new List<Int32>();

        public FormRegulationBook()
        {
            InitializeComponent();
            this.regulationsDataGridView.Columns["ColumnAdd"].Visible = false;
        }

        public FormRegulationBook(int id_room, List<Int32> regulations)
        {
            InitializeComponent();

            this.id_room = id_room;
            this.regList = regulations;
            
        }

        private void RegBind()
        {
            int indx = 0;
            if (regList.Count >= 1)
            {
                for (int i = 0; i < regList.Count; i++)
                {
                    indx = this.regulationsBindingSource.Find("ID_regulation", regList[i]);
                    if (indx >= 0)
                    {
                        this.regulationsBindingSource.Position = indx;
                        this.regulationsBindingSource.RemoveCurrent();
                    }
                }
            }
        }
        private void FormRegulationBook_Load(object sender, EventArgs e)
        {
            this.regulationsTableAdapter.Fill(this.accessControlSystemDataSet.Regulations);
            if (id_room != -1)
                RegBind();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            this.regulationsBindingSource.Filter = "";
            this.regulationsTableAdapter.Fill(this.accessControlSystemDataSet.Regulations);
            if (id_room != -1)
                RegBind();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string filtrString = "";
            string filtrStringDays = "Days_of_week LIKE '%";
            long _day_checked = 0;
            if (checkBoxDes.Checked)
            {
               filtrString += string.Format(" Description LIKE '%{0}%'", textBoxDes.Text);
            }      
            if (checkBoxMo.Checked)
            {
                filtrStringDays += "Пн";
                _day_checked++;
            }
            if (checkBoxTu.Checked)
            {
                if (_day_checked != 0)
                    filtrStringDays += "%' AND Days_of_week LIKE '%Вт";
                else
                {
                    filtrStringDays += "Вт";
                    _day_checked++;
                }
            }
            if (checkBoxWe.Checked)
                if (_day_checked != 0)
                    filtrStringDays += "%' AND Days_of_week LIKE '%Ср";
                else
                {
                    filtrStringDays += "Ср";
                    _day_checked++;
                }

            if (checkBoxTh.Checked)
                if (_day_checked != 0)
                    filtrStringDays += "%' AND Days_of_week LIKE '%Чт";
                else
                {
                    filtrStringDays += "Чт";
                    _day_checked++;
                }
                               
            if(checkBoxFr.Checked)
                if (_day_checked != 0)
                    filtrStringDays += "%' AND Days_of_week LIKE '%Пт";
                else
                {
                    filtrStringDays += "Пт";
                    _day_checked++;
                }

            if(checkBoxSa.Checked)
                if (_day_checked != 0)
                    filtrStringDays += "%' AND Days_of_week LIKE '%Сб";
                else
                {
                    filtrStringDays += "Сб";
                    _day_checked++;
                }

            if(checkBoxSu.Checked)
                if (_day_checked != 0)
                    filtrStringDays += "%' AND Days_of_week LIKE '%Вс";
                else
                {
                    filtrStringDays += "Вс";
                    _day_checked++;
                }
            filtrStringDays += "%'";

            if (!filtrString.Equals(String.Empty))
            {
                filtrStringDays = " AND " + filtrStringDays;
            }
            this.regulationsBindingSource.Filter = filtrString + filtrStringDays;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            FormRegulationsAddEdit frmAddRegulation = new FormRegulationsAddEdit();
            frmAddRegulation.ShowDialog();
            this.regulationsTableAdapter.Fill(this.accessControlSystemDataSet.Regulations);
            if (id_room != -1)
                RegBind();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            FormRegulationsAddEdit frmEditRegulation = new FormRegulationsAddEdit(
                Convert.ToInt32(((DataRowView)this.regulationsBindingSource.Current).Row["ID_regulation"].ToString()),
                ((DataRowView)this.regulationsBindingSource.Current).Row["Days_of_week"].ToString(),
                ((DataRowView)this.regulationsBindingSource.Current).Row["Access_time_from"].ToString(),
                ((DataRowView)this.regulationsBindingSource.Current).Row["Access_time_to"].ToString(),
                ((DataRowView)this.regulationsBindingSource.Current).Row["Description"].ToString());
            frmEditRegulation.ShowDialog();
            this.regulationsTableAdapter.Fill(this.accessControlSystemDataSet.Regulations);
            if (id_room != -1)
                RegBind();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.regulationsTableAdapter.DeleteQuery(Convert.ToInt32(((DataRowView)this.regulationsBindingSource.Current).Row["ID_regulation"].ToString()));
                    MessageBox.Show("Запись удалена", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления!\nОбратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.regulationsBindingSource.Filter = "";
        }

        private void regulationsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (id_room != -1)
            {
                try
                {
                    var senderGrid = (DataGridView)sender;

                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                        e.RowIndex >= 0)
                    {
                        this.room_regulationTableAdapter.InsertQuery(Convert.ToInt32(this.regulationsDataGridView.CurrentRow.Cells[0].Value.ToString()), id_room);
                        MessageBox.Show("Запись добавлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.regulationsBindingSource.RemoveCurrent();
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
