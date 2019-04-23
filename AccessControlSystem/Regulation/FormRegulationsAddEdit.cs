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
    public partial class FormRegulationsAddEdit : Form
    {
        int ID_regulation;
        public FormRegulationsAddEdit()
        {
            InitializeComponent();
        }
        public FormRegulationsAddEdit(int ID_regulation, string DaysOfWeek, string AccessTimeFrom, string AccessTimeTo, string description)
        {
            InitializeComponent();
            this.Text = "Изменение записи";
            this.buttonAddEdit.Text = "Изменить данные";
            this.ID_regulation = ID_regulation;
            this.dateTimePickerAccessTimeTo.Value = Convert.ToDateTime(AccessTimeTo);
            this.dateTimePickerAccessTimeFrom.Value = Convert.ToDateTime(AccessTimeFrom);
            this.richTextBoxDes.Text = description;
            
            string[] days = DaysOfWeek.Split(',');
            for (int i = 0; i < days.Length; i++)
            {
                switch (days[i])
                {
                    case "Пн":
                        this.checkBoxMo.Checked = true;
                        break;
                    case "Вт":
                        this.checkBoxTu.Checked = true;
                        break;
                    case "Ср":
                        this.checkBoxWe.Checked = true;
                        break;
                    case "Чт":
                        this.checkBoxTh.Checked = true;
                        break;
                    case "Пт":
                        this.checkBoxFr.Checked = true;
                        break;
                    case "Сб":
                        this.checkBoxSa.Checked = true;
                        break;
                    case "Вс":
                        this.checkBoxSu.Checked = true;
                        break;
                }
            }

        } 

        private void buttonAddEdit_Click(object sender, EventArgs e)
        {
            string DaysString = "";
            long _day_checked = 0;

            if (checkBoxMo.Checked)
            {
                DaysString += "Пн";
                _day_checked++;
            }
            if (checkBoxTu.Checked)
            {
                if (_day_checked != 0)
                    DaysString += ",Вт";
                else
                {
                    DaysString += "Вт";
                    _day_checked++;
                }
            }
            if (checkBoxWe.Checked)
                if (_day_checked != 0)
                    DaysString += ",Ср";
                else
                {
                    DaysString += "Ср";
                    _day_checked++;
                }

            if (checkBoxTh.Checked)
                if (_day_checked != 0)
                    DaysString += ",Чт";
                else
                {
                    DaysString += "Чт";
                    _day_checked++;
                }

            if (checkBoxFr.Checked)
                if (_day_checked != 0)
                    DaysString += ",Пт";
                else
                {
                    DaysString += "Пт";
                    _day_checked++;
                }

            if (checkBoxSa.Checked)
                if (_day_checked != 0)
                    DaysString += ",Сб";
                else
                {
                    DaysString += "Сб";
                    _day_checked++;
                }

            if (checkBoxSu.Checked)
                if (_day_checked != 0)
                    DaysString += ",Вс";
                else
                {
                    DaysString += "Вс";
                    _day_checked++;
                }

            if (this.Text.Equals("Изменение записи"))
            {
                try
                {
                    this.regulationsTableAdapter.UpdateQuery(richTextBoxDes.Text,dateTimePickerAccessTimeFrom.Value.ToShortTimeString(),DaysString,dateTimePickerAccessTimeTo.Value.ToShortTimeString(),ID_regulation);
                    MessageBox.Show("Запись изменена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ошибка изменения записи. Проверьте введеные данные.\nТекст ошибки:" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    this.regulationsTableAdapter.InsertQuery(richTextBoxDes.Text, dateTimePickerAccessTimeFrom.Value.ToShortTimeString(), DaysString, dateTimePickerAccessTimeTo.Value.ToShortTimeString());
                    MessageBox.Show("Запись добавлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка добавления записи. Проверьте введеные данные.\nТекст ошибки:" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormRegulationsAddEdit_Load(object sender, EventArgs e)
        {
        }
    }
}
