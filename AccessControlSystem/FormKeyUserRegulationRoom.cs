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
    public partial class FormKeyUserRegulationRoom : Form
    {
        int id_user;

        public FormKeyUserRegulationRoom(int id_user)
        {
            InitializeComponent();
            this.id_user = id_user;
        }

        private void FormKeyUserRegulationRoom_Load(object sender, EventArgs e)
        {
            this.view_user_regulation_roomTableAdapter.FillByUser(this.accessControlSystemDataSet.View_user_regulation_room, id_user);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string filtrString = "";
            string filtrStringDays = "Days_of_week LIKE '%";
            long _day_checked = 0;
            if (checkBoxObject.Checked)
            {
                filtrString += string.Format(" Name LIKE '%{0}%'", textBoxName.Text);
            }
            if (checkBoxDes.Checked)
            {
                filtrString += string.Format(" Reg_desk LIKE '%{0}%'", textBoxDes.Text);
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
            this.view_user_regulation_roomBindingSource.Filter = filtrString + filtrStringDays;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.view_user_regulation_roomBindingSource.RemoveFilter();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.regulation_keyTableAdapter.DeleteQuery(Convert.ToInt32(((DataRowView)this.view_user_regulation_roomBindingSource.Current).Row["ID_record"].ToString()));
                    MessageBox.Show("Запись удалена", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.toolStripButtonRefresh.PerformClick();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления!\nОбратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            this.view_user_regulation_roomTableAdapter.FillByUser(this.accessControlSystemDataSet.View_user_regulation_room, id_user);
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            FormRoomsBook frmroom = new FormRoomsBook(id_user);
            frmroom.ShowDialog();
        }
    }
}
