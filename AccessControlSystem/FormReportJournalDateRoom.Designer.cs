namespace AccessControlSystem
{
    partial class FormReportJournalDateRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportJournalDateRoom));
            this.Report_Journal_date_roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reportViewerJournalDateRoom = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.Report_Journal_date_roomTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.Report_Journal_date_roomTableAdapter();
            this.roomsTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.RoomsTableAdapter();
            this.tableAdapterManager = new AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Journal_date_roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Report_Journal_date_roomBindingSource
            // 
            this.Report_Journal_date_roomBindingSource.DataMember = "Report_Journal_date_room";
            this.Report_Journal_date_roomBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // accessControlSystemDataSet
            // 
            this.accessControlSystemDataSet.DataSetName = "accessControlSystemDataSet";
            this.accessControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.reportViewerJournalDateRoom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(676, 390);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // reportViewerJournalDateRoom
            // 
            this.reportViewerJournalDateRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Report_Journal_date_roomBindingSource;
            this.reportViewerJournalDateRoom.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerJournalDateRoom.LocalReport.ReportEmbeddedResource = "AccessControlSystem.ReportJournalDateRoom.rdlc";
            this.reportViewerJournalDateRoom.Location = new System.Drawing.Point(238, 3);
            this.reportViewerJournalDateRoom.Name = "reportViewerJournalDateRoom";
            this.reportViewerJournalDateRoom.Size = new System.Drawing.Size(435, 384);
            this.reportViewerJournalDateRoom.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.buttonGenerate);
            this.panel1.Controls.Add(this.comboBoxRoom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePickerDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 384);
            this.panel1.TabIndex = 1;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(63, 62);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(163, 23);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Сформировать отчет";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxRoom.DataSource = this.roomsBindingSource;
            this.comboBoxRoom.DisplayMember = "Name";
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(63, 9);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(163, 21);
            this.comboBoxRoom.TabIndex = 3;
            this.comboBoxRoom.ValueMember = "ID_room";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Объект:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(63, 36);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(163, 20);
            this.dateTimePickerDate.TabIndex = 0;
            // 
            // Report_Journal_date_roomTableAdapter
            // 
            this.Report_Journal_date_roomTableAdapter.ClearBeforeFill = true;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.JournalTableAdapter = null;
            this.tableAdapterManager.Key_statusTableAdapter = null;
            this.tableAdapterManager.Key_typeTableAdapter = null;
            this.tableAdapterManager.Key_userTableAdapter = null;
            this.tableAdapterManager.KeysTableAdapter = null;
            this.tableAdapterManager.Login_tableTableAdapter = null;
            this.tableAdapterManager.PositionTableAdapter = null;
            this.tableAdapterManager.Regulation_keyTableAdapter = null;
            this.tableAdapterManager.RegulationsTableAdapter = null;
            this.tableAdapterManager.Room_regulationTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = this.roomsTableAdapter;
            this.tableAdapterManager.UpdateOrder = AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitorTableAdapter = null;
            this.tableAdapterManager.WorkerTableAdapter = null;
            // 
            // FormReportJournalDateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 390);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReportJournalDateRoom";
            this.Text = "Отчет \"Журнал доступа к объекту\"";
            this.Load += new System.EventHandler(this.FormReportJournalDateRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Report_Journal_date_roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerJournalDateRoom;
        private System.Windows.Forms.BindingSource Report_Journal_date_roomBindingSource;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private accessControlSystemDataSetTableAdapters.Report_Journal_date_roomTableAdapter Report_Journal_date_roomTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private accessControlSystemDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private accessControlSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button buttonGenerate;

    }
}