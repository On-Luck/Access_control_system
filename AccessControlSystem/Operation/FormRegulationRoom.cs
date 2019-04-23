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
    public partial class FormRegulationRoom : Form
    {
        int id_room;
        int id_user;

        public FormRegulationRoom(int id_room, string room_name)
        {
            InitializeComponent();
            this.id_room = id_room;
            this.Text = "Прикрепленные правила для объекта: " + room_name;
            this.view_regulation_roomDataGridView.Columns["ColumnAdd"].Visible = false;
        }

        public FormRegulationRoom(int id_room, string room_name, int id_user)
        {
            InitializeComponent();
            this.id_room = id_room;
            this.Text = "Прикрепленные правила для объекта: " + room_name;
            this.id_user = id_user;
        }

        private void FormRegulationRoom_Load(object sender, EventArgs e)
        {   
            this.view_regulation_roomTableAdapter.FillBy(this.accessControlSystemDataSet.View_regulation_room, id_room);
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

            if (checkBoxFr.Checked)
                if (_day_checked != 0)
                    filtrStringDays += "%' AND Days_of_week LIKE '%Пт";
                else
                {
                    filtrStringDays += "Пт";
                    _day_checked++;
                }

            if (checkBoxSa.Checked)
                if (_day_checked != 0)
                    filtrStringDays += "%' AND Days_of_week LIKE '%Сб";
                else
                {
                    filtrStringDays += "Сб";
                    _day_checked++;
                }

            if (checkBoxSu.Checked)
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
            this.view_regulation_roomBindingSource.Filter = filtrString + filtrStringDays;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.view_regulation_roomBindingSource.RemoveFilter();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            this.view_regulation_roomTableAdapter.FillBy(this.accessControlSystemDataSet.View_regulation_room, id_room);
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            int current_position = this.view_regulation_roomBindingSource.Position;
            List<Int32> regulationList = new List<Int32>();

            this.view_regulation_roomBindingSource.Position = 0;

            for (int i = 0; i < this.view_regulation_roomBindingSource.Count; i++)
            {
                regulationList.Add(Convert.ToInt32(((DataRowView)this.view_regulation_roomBindingSource.Current).Row["ID_regulation"].ToString()));

                this.view_regulation_roomBindingSource.MoveNext();
            }

            this.view_regulation_roomBindingSource.Position = current_position;
            
            FormRegulationBook frmRegBook = new FormRegulationBook(id_room, regulationList);
            frmRegBook.ShowDialog();

            this.view_regulation_roomTableAdapter.FillBy(this.accessControlSystemDataSet.View_regulation_room, id_room);
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.room_regulationTableAdapter.DeleteQuery(Convert.ToInt32(((DataRowView)this.view_regulation_roomBindingSource.Current).Row["ID_regulation_room"].ToString()));
                    MessageBox.Show("Запись удалена", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления!\nОбратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.view_regulation_roomTableAdapter.FillBy(this.accessControlSystemDataSet.View_regulation_room, id_room);
        }

        private void view_regulation_roomDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (id_user != -1)
            {
                try
                {
                    var senderGrid = (DataGridView)sender;

                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                        e.RowIndex >= 0)
                    {
                        this.regulation_keyTableAdapter.InsertQuery(id_user, Convert.ToInt32(((DataRowView)this.view_regulation_roomBindingSource.Current).Row["ID_regulation_room"].ToString()));
                        MessageBox.Show("Запись добавлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
