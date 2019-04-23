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
    public partial class FormVisitorAddEdit : Form
    {
        private UInt32 id_visitor;
        MemoryStream msPhoto;
        public FormVisitorAddEdit()
        {
            InitializeComponent();
        }

        public FormVisitorAddEdit(UInt32 id_visitor, string sName, string name, string patronymic, Image photo, string phone, string passport)
        {
            InitializeComponent();
            msPhoto = new MemoryStream();
            this.id_visitor = id_visitor;
            textBoxSname.Text = sName;
            textBoxName.Text = name;
            textBoxPat.Text = patronymic;
            pictureBoxVisitorAddEdit.Image = photo;
            photo.Save(msPhoto, System.Drawing.Imaging.ImageFormat.Bmp); 
            textBoxPh.Text = phone;
            textBoxPas.Text = passport;

            this.Text = "Изменение записи";
            this.buttonAddEdit.Text = "Изменить запись";
        }

        private void FormVisitorAddEdit_Load(object sender, EventArgs e)
        {
          
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
                        pictureBoxVisitorAddEdit.Image = image;
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
                    if (((TextBox)txt).Name != "textBoxPat" || ((TextBox)txt).Name != "textBoxPh")
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
                        this.visitorTableAdapter.UpdateQuery(textBoxSname.Text, textBoxName.Text, textBoxPat.Text, msPhoto.Length > 0 ? msPhoto.ToArray() : null, textBoxPh.Text, textBoxPas.Text, Convert.ToInt32(id_visitor));
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
                        this.visitorTableAdapter.InsertQuery(textBoxSname.Text, textBoxName.Text, textBoxPat.Text, msPhoto.Length > 0 ? msPhoto.ToArray() : null, textBoxPh.Text, textBoxPas.Text);
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
            if (Char.IsLetter(e.KeyChar)) return;
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
    }
}
