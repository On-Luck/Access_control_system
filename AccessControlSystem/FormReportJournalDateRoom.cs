using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace AccessControlSystem
{
    public partial class FormReportJournalDateRoom : Form
    {
        public FormReportJournalDateRoom()
        {
            InitializeComponent();
        }

        private void FormReportJournalDateRoom_Load(object sender, EventArgs e)
        {
            this.roomsTableAdapter.Fill(this.accessControlSystemDataSet.Rooms);          
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            this.Report_Journal_date_roomTableAdapter.Fill(this.accessControlSystemDataSet.Report_Journal_date_room, Convert.ToDateTime(this.dateTimePickerDate.Value.ToShortDateString()),Convert.ToInt32(comboBoxRoom.SelectedValue.ToString()));
            ReportParameter parDate = new ReportParameter("ReportParameterDate", this.dateTimePickerDate.Value.ToShortDateString());
            ReportParameter parRoom = new ReportParameter("ReportParameterRoom", this.comboBoxRoom.Text);
            reportViewerJournalDateRoom.LocalReport.SetParameters(new ReportParameter[] { parDate, parRoom });
            this.reportViewerJournalDateRoom.RefreshReport();
        }
    }
}
