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
    public partial class FormRoomAddEdit : Form
    {
        int id_room;
        public FormRoomAddEdit()
        {
            InitializeComponent();
        }
        public FormRoomAddEdit(int id_room, string name, string description, string floor, string block, string type)
        {
            InitializeComponent();

            this.id_room = id_room;
            this.textBoxName.Text = name;
            this.richTextBoxDes.Text = description;
            this.textBoxFloor.Text = floor;
            this.textBoxBlock.Text = block;
            this.textBoxType.Text = type;
        }

        private void buttonAddEdit_Click(object sender, EventArgs e)
        {
            bool can_we_do_that = true;

            foreach (Control txt in this.Controls)
            {
                if (txt is TextBox)
                {
                    if (((TextBox)txt).Text == String.Empty)
                        can_we_do_that = false;
                }
            }

            if (can_we_do_that)
            {
                if (this.Text.Equals("Изменение записи"))
                {
                    try
                    {
                        this.roomsTableAdapter.UpdateQuery(textBoxName.Text, richTextBoxDes.Text, textBoxFloor.Text, textBoxBlock.Text, textBoxType.Text, id_room);
                        MessageBox.Show("Запись изменена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка изменения записи. Проверьте введеные данные.\nТекст ошибки:" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        this.roomsTableAdapter.InsertQuery(textBoxName.Text, richTextBoxDes.Text, textBoxFloor.Text, textBoxBlock.Text, textBoxType.Text);
                        MessageBox.Show("Запись добавлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавления записи. Проверьте введеные данные.\nТекст ошибки:" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Проверьте введенные значения.\nПоля помеченные * обязательны для заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)) return;
                else
                    e.Handled = true;
        }

        private void textBoxDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void FormRoomAddEdit_Load(object sender, EventArgs e)
        {
        }
    }
}
