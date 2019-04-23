namespace AccessControlSystem
{
    partial class FormSecurity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecurity));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelAccess = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPat = new System.Windows.Forms.Label();
            this.labelSname = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelObject = new System.Windows.Forms.Label();
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.view_key_userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_key_userTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.View_key_userTableAdapter();
            this.tableAdapterManager = new AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager();
            this.view_user_regulation_roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_user_regulation_roomTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.View_user_regulation_roomTableAdapter();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.RoomsTableAdapter();
            this.journalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.JournalTableAdapter();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_key_userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_user_regulation_roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo,
            this.toolStripStatusLabelTime,
            this.toolStripStatusLabelDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(609, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(518, 19);
            this.toolStripStatusLabelInfo.Spring = true;
            this.toolStripStatusLabelInfo.Text = "Текущая дата и время:";
            this.toolStripStatusLabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(38, 19);
            this.toolStripStatusLabelTime.Text = "Time";
            // 
            // toolStripStatusLabelDate
            // 
            this.toolStripStatusLabelDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            this.toolStripStatusLabelDate.Size = new System.Drawing.Size(38, 19);
            this.toolStripStatusLabelDate.Text = "Date";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxPhoto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelInfo, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(609, 428);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPhoto.Image = global::AccessControlSystem.Properties.Resources.if_image_cancel_103591;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(294, 422);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 6;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // panelInfo
            // 
            this.panelInfo.AutoScroll = true;
            this.panelInfo.Controls.Add(this.labelAccess);
            this.panelInfo.Controls.Add(this.label5);
            this.panelInfo.Controls.Add(this.labelName);
            this.panelInfo.Controls.Add(this.labelPat);
            this.panelInfo.Controls.Add(this.labelSname);
            this.panelInfo.Controls.Add(this.labelStatus);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.labelObject);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelInfo.Location = new System.Drawing.Point(303, 3);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(303, 422);
            this.panelInfo.TabIndex = 4;
            // 
            // labelAccess
            // 
            this.labelAccess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAccess.BackColor = System.Drawing.SystemColors.Control;
            this.labelAccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAccess.Location = new System.Drawing.Point(105, 230);
            this.labelAccess.Name = "labelAccess";
            this.labelAccess.Size = new System.Drawing.Size(189, 20);
            this.labelAccess.TabIndex = 11;
            this.labelAccess.Text = "5";
            this.labelAccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Доступ:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(105, 150);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(18, 20);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "3";
            // 
            // labelPat
            // 
            this.labelPat.AutoSize = true;
            this.labelPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPat.Location = new System.Drawing.Point(105, 190);
            this.labelPat.Name = "labelPat";
            this.labelPat.Size = new System.Drawing.Size(18, 20);
            this.labelPat.TabIndex = 8;
            this.labelPat.Text = "4";
            // 
            // labelSname
            // 
            this.labelSname.AutoSize = true;
            this.labelSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSname.Location = new System.Drawing.Point(105, 110);
            this.labelSname.Name = "labelSname";
            this.labelSname.Size = new System.Drawing.Size(18, 20);
            this.labelSname.TabIndex = 7;
            this.labelSname.Text = "2";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(105, 70);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(18, 20);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Отчество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Статус:";
            // 
            // labelObject
            // 
            this.labelObject.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelObject.Location = new System.Drawing.Point(0, 0);
            this.labelObject.Name = "labelObject";
            this.labelObject.Size = new System.Drawing.Size(303, 23);
            this.labelObject.TabIndex = 0;
            this.labelObject.Text = "Объект: ";
            this.labelObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accessControlSystemDataSet
            // 
            this.accessControlSystemDataSet.DataSetName = "accessControlSystemDataSet";
            this.accessControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_key_userBindingSource
            // 
            this.view_key_userBindingSource.DataMember = "View_key_user";
            this.view_key_userBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // view_key_userTableAdapter
            // 
            this.view_key_userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitorTableAdapter = null;
            this.tableAdapterManager.WorkerTableAdapter = null;
            // 
            // view_user_regulation_roomBindingSource
            // 
            this.view_user_regulation_roomBindingSource.DataMember = "View_user_regulation_room";
            this.view_user_regulation_roomBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // view_user_regulation_roomTableAdapter
            // 
            this.view_user_regulation_roomTableAdapter.ClearBeforeFill = true;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // journalBindingSource
            // 
            this.journalBindingSource.DataMember = "Journal";
            this.journalBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // journalTableAdapter
            // 
            this.journalTableAdapter.ClearBeforeFill = true;
            // 
            // FormSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 452);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(625, 490);
            this.Name = "FormSecurity";
            this.Text = "Контроль";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSecurity_FormClosing);
            this.Load += new System.EventHandler(this.FormSecurity_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_key_userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_user_regulation_roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPat;
        private System.Windows.Forms.Label labelSname;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelObject;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private System.Windows.Forms.BindingSource view_key_userBindingSource;
        private accessControlSystemDataSetTableAdapters.View_key_userTableAdapter view_key_userTableAdapter;
        private accessControlSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource view_user_regulation_roomBindingSource;
        private accessControlSystemDataSetTableAdapters.View_user_regulation_roomTableAdapter view_user_regulation_roomTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private accessControlSystemDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.Label labelAccess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource journalBindingSource;
        private accessControlSystemDataSetTableAdapters.JournalTableAdapter journalTableAdapter;

    }
}