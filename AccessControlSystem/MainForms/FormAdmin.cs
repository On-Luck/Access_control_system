using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace AccessControlSystem
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void списокСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWorkerBook frmWork = new FormWorkerBook();
            frmWork.ShowDialog();
        }

        private void должностиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPosition frmPos = new FormPosition();
            frmPos.ShowDialog();
        }

        private void отделыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDepartment frmDep = new FormDepartment();
            frmDep.ShowDialog();
        }

        private void посетителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVisitorBook frmVis = new FormVisitorBook();
            frmVis.Show();
        }

        private void списокКлючейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKeysBook frmKey = new FormKeysBook();
            frmKey.ShowDialog();
        }

        private void типыКлючейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKeyType frmType = new FormKeyType();
            frmType.ShowDialog();
        }

        private void статусКлючейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKeyStatus frmStatus = new FormKeyStatus();
            frmStatus.ShowDialog();
        }

        private void помещенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRoomsBook frmRoom = new FormRoomsBook();
            frmRoom.ShowDialog();
        }

       // private void button1_Click(object sender, EventArgs e)
       // {
            //Выводит текущую дату в формате из двух букв: Пн, Вт, Ср    и т.д.
            //MessageBox.Show(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dateTimePicker1.Value.ToString("ddd")));
        //}

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegulationBook frmReg = new FormRegulationBook();
            frmReg.ShowDialog();
        }

        private void привзякаКлючаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void списокПрикрепленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKeyUserBook frmKeyUser = new FormKeyUserBook();
            frmKeyUser.ShowDialog();
        }

        private void отчетЖурналДоступаКОбъектуВЗаданныйДеньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportJournalDateRoom frmRep = new FormReportJournalDateRoom();
            frmRep.ShowDialog();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
        }

        private void журналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJournal frmjournal = new FormJournal();
            frmjournal.ShowDialog();
        }
    }
}
