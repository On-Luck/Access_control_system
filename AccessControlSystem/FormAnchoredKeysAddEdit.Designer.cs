namespace AccessControlSystem
{
    partial class FormAnchoredKeysAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnchoredKeysAddEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.dateTimePickerDateOfIssue = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateStartAction = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateExpiration = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxVisitPurpose = new System.Windows.Forms.RichTextBox();
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.key_userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.key_userTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.Key_userTableAdapter();
            this.tableAdapterManager = new AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key_userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата выдачи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата начала действия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата окончания действия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цель визита";
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddEdit.Location = new System.Drawing.Point(236, 209);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEdit.TabIndex = 4;
            this.buttonAddEdit.Text = "Добавить";
            this.buttonAddEdit.UseVisualStyleBackColor = true;
            this.buttonAddEdit.Click += new System.EventHandler(this.buttonAddEdit_Click);
            // 
            // dateTimePickerDateOfIssue
            // 
            this.dateTimePickerDateOfIssue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateOfIssue.Location = new System.Drawing.Point(158, 7);
            this.dateTimePickerDateOfIssue.Name = "dateTimePickerDateOfIssue";
            this.dateTimePickerDateOfIssue.Size = new System.Drawing.Size(153, 20);
            this.dateTimePickerDateOfIssue.TabIndex = 5;
            // 
            // dateTimePickerDateStartAction
            // 
            this.dateTimePickerDateStartAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateStartAction.Location = new System.Drawing.Point(158, 41);
            this.dateTimePickerDateStartAction.Name = "dateTimePickerDateStartAction";
            this.dateTimePickerDateStartAction.Size = new System.Drawing.Size(153, 20);
            this.dateTimePickerDateStartAction.TabIndex = 6;
            // 
            // dateTimePickerDateExpiration
            // 
            this.dateTimePickerDateExpiration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateExpiration.Location = new System.Drawing.Point(158, 75);
            this.dateTimePickerDateExpiration.Name = "dateTimePickerDateExpiration";
            this.dateTimePickerDateExpiration.Size = new System.Drawing.Size(153, 20);
            this.dateTimePickerDateExpiration.TabIndex = 7;
            // 
            // richTextBoxVisitPurpose
            // 
            this.richTextBoxVisitPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxVisitPurpose.Location = new System.Drawing.Point(158, 113);
            this.richTextBoxVisitPurpose.Name = "richTextBoxVisitPurpose";
            this.richTextBoxVisitPurpose.Size = new System.Drawing.Size(153, 90);
            this.richTextBoxVisitPurpose.TabIndex = 8;
            this.richTextBoxVisitPurpose.Text = "";
            // 
            // accessControlSystemDataSet
            // 
            this.accessControlSystemDataSet.DataSetName = "accessControlSystemDataSet";
            this.accessControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // key_userBindingSource
            // 
            this.key_userBindingSource.DataMember = "Key_user";
            this.key_userBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // key_userTableAdapter
            // 
            this.key_userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.JournalTableAdapter = null;
            this.tableAdapterManager.Key_statusTableAdapter = null;
            this.tableAdapterManager.Key_typeTableAdapter = null;
            this.tableAdapterManager.Key_userTableAdapter = this.key_userTableAdapter;
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
            // FormAnchoredKeysAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 237);
            this.Controls.Add(this.richTextBoxVisitPurpose);
            this.Controls.Add(this.dateTimePickerDateExpiration);
            this.Controls.Add(this.dateTimePickerDateStartAction);
            this.Controls.Add(this.dateTimePickerDateOfIssue);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(340, 275);
            this.Name = "FormAnchoredKeysAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметры";
            this.Load += new System.EventHandler(this.FormAnchoredKeysAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key_userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddEdit;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfIssue;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateStartAction;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateExpiration;
        private System.Windows.Forms.RichTextBox richTextBoxVisitPurpose;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private System.Windows.Forms.BindingSource key_userBindingSource;
        private accessControlSystemDataSetTableAdapters.Key_userTableAdapter key_userTableAdapter;
        private accessControlSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}