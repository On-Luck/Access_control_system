using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AccessControlSystem
{
    public partial class FormWorker_AddEdit : Form
    {
        private UInt32 id_worker;
        private MemoryStream  msPhoto;

        public FormWorker_AddEdit()
        {
            InitializeComponent();
        }

        public FormWorker_AddEdit(UInt32 id_worker, string sName, string name, string patronymic, Image photo, string phone, string email, string passport, string education, UInt32 id_department, UInt32 id_position)
        {
            InitializeComponent();
            msPhoto = new MemoryStream();
            this.id_worker = id_worker;
            textBoxSname.Text = sName;
            textBoxName.Text = name;
            textBoxPat.Text = patronymic;
            pictureBoxWorAddEdit.Image = photo;
            photo.Save(msPhoto, System.Drawing.Imaging.ImageFormat.Bmp); 
            textBoxPh.Text = phone;
            textBoxEmail.Text = email;
            textBoxPas.Text = passport;
            textBoxEdu.Text = education;
            comboBoxDep.SelectedValue = id_department;
            comboBoxPos.SelectedValue = id_position;

            this.Text = "Изменение записи";
            this.buttonAddEdit.Text = "Изменить запись";
        }

        private void buttonLoadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            opf.Filter = "Изображения (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png|All files (*.*)|*.*";
            opf.FilterIndex = 1;
            opf.RestoreDirectory = true;
            opf.Multiselect = false;

            if (opf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (opf.OpenFile() != null)
                    {
                        msPhoto = new MemoryStream();
                        Image image = Image.FromFile(opf.FileName);
                        pictureBoxWorAddEdit.Image = image;
                        image.Save(msPhoto, System.Drawing.Imaging.ImageFormat.Bmp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка чтения файла.\nТекст ошибки:" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAddEdit_Click(object sender, EventArgs e)
        {
            bool can_we_do_that = true;
            foreach (Control txt in this.Controls)
            {
                if (txt is TextBox)
                {
                    if (((TextBox)txt).Name != "textBoxPat" && ((TextBox)txt).Name != "textBoxPh" && ((TextBox)txt).Name != "textBoxEmail")
                        if (((TextBox)txt).Text.Equals(String.Empty))
                            can_we_do_that = false;
                }
            }
            if (can_we_do_that)
            {
                if (this.Text.Equals("Изменение записи"))
                {
                    try
                    {
                        this.workerTableAdapter.UpdateQuery(textBoxSname.Text, textBoxName.Text, textBoxPat.Text, msPhoto.Length > 0 ? msPhoto.ToArray() : null, textBoxPh.Text, textBoxEmail.Text, textBoxPas.Text, textBoxEdu.Text, Convert.ToInt32(comboBoxDep.SelectedValue.ToString()), Convert.ToInt32(comboBoxPos.SelectedValue.ToString()), Convert.ToInt32(id_worker));
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
                        this.workerTableAdapter.InsertQuery(textBoxSname.Text, textBoxName.Text, textBoxPat.Text, msPhoto.Length>0 ? msPhoto.ToArray() : null, textBoxPh.Text, textBoxEmail.Text, textBoxPas.Text, textBoxEdu.Text, Convert.ToInt32(comboBoxDep.SelectedValue.ToString()), Convert.ToInt32(comboBoxPos.SelectedValue.ToString()));
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

        private void FormWorker_AddEdit_Load(object sender, EventArgs e)
        {
            this.positionTableAdapter.Fill(this.accessControlSystemDataSet.Position);
            this.departmentTableAdapter.Fill(this.accessControlSystemDataSet.Department);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) return;
            else
                if ((((TextBox)sender).Name == "textBoxEdu") && Char.IsWhiteSpace(e.KeyChar))
                    return;
                else 
                    e.Handled = true;
        }

        private void textBoxDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
