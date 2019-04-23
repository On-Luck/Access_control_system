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
    public partial class FormRoomsBook : Form
    {
        int id_user = -1;

        public FormRoomsBook()
        {
            InitializeComponent();
        }

        public FormRoomsBook(int id_user)
        {
            InitializeComponent();
            this.id_user = id_user;
        }

        private void FormRoomsBook_Load(object sender, EventArgs e)
        {
           this.roomsTableAdapter.Fill(this.accessControlSystemDataSet.Rooms);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string filtrString = "";
            long _checked = 0;
            foreach (Control cb in panelFindRoom.Controls)
            {
                if (cb is CheckBox)
                {
                    if (((CheckBox)cb).Checked)
                    {
                        if (_checked != 0)
                            filtrString += @" AND";

                        switch (cb.Name)
                        {
                            case "checkBoxName":
                                filtrString += string.Format(" Name LIKE '%{0}%'", textBoxName.Text);
                                break;
                            case "checkBoxDes":
                                filtrString += string.Format(" Description LIKE '%{0}%'", textBoxDes.Text);
                                break;
                            case "checkBoxFloor":
                                filtrString += string.Format(" Floor LIKE '%{0}%'", textBoxFloor.Text);
                                break;
                            case "checkBoxBlock":
                                filtrString += string.Format(" Block LIKE '%{0}%'", textBoxBlock.Text);
                                break;
                            case "checkBoxType":
                                filtrString += string.Format(" Type_room LIKE '%{0}%'", textBoxType.Text);
                                break;
                        }
                        _checked++;
                    }
                }
            }
            this.roomsBindingSource.Filter = filtrString;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.roomsBindingSource.Filter = "";
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            this.roomsBindingSource.Filter = "";
            this.roomsTableAdapter.Fill(this.accessControlSystemDataSet.Rooms);
        }

        private void toolStripButtonAddRoom_Click(object sender, EventArgs e)
        {
            FormRoomAddEdit frmAddRoom = new FormRoomAddEdit();
            frmAddRoom.ShowDialog();
        }

        private void toolStripButtonEditRoom_Click(object sender, EventArgs e)
        {
            FormRoomAddEdit frmEditRoom = new FormRoomAddEdit(Convert.ToInt32(((DataRowView)this.roomsBindingSource.Current).Row["ID_room"].ToString()),
               ((DataRowView)this.roomsBindingSource.Current).Row["Name"].ToString(),
               ((DataRowView)this.roomsBindingSource.Current).Row["Description"].ToString(),
               ((DataRowView)this.roomsBindingSource.Current).Row["Floor"].ToString(), 
               ((DataRowView)this.roomsBindingSource.Current).Row["Block"].ToString(),
               ((DataRowView)this.roomsBindingSource.Current).Row["Type_room"].ToString());
            frmEditRoom.ShowDialog();
        }

        private void toolStripButtonDeleteRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.roomsTableAdapter.DeleteQuery(Convert.ToInt32(((DataRowView)this.roomsBindingSource.Current).Row["ID_room"].ToString()));
                    MessageBox.Show("Запись удалена", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления!\nОбратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonRules_Click(object sender, EventArgs e)
        {
            FormRegulationRoom frmRegRoom;
            if(id_user != -1)
            {
                frmRegRoom = new FormRegulationRoom(
                Convert.ToInt32(((DataRowView)this.roomsBindingSource.Current).Row["ID_room"].ToString()),
                ((DataRowView)this.roomsBindingSource.Current).Row["Name"].ToString(), id_user);
            }
            else
            {
                frmRegRoom = new FormRegulationRoom(
                Convert.ToInt32(((DataRowView)this.roomsBindingSource.Current).Row["ID_room"].ToString()),
                ((DataRowView)this.roomsBindingSource.Current).Row["Name"].ToString());
            }
            frmRegRoom.ShowDialog();
        }
    }
}
