namespace AccessControlSystem
{
    partial class FormKeysAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKeysAddEdit));
            this.buttonReadKey = new System.Windows.Forms.Button();
            this.buttonKeyAddEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKeyType = new System.Windows.Forms.ComboBox();
            this.comboBoxKeyStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ключ = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.key_statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.key_statusTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.Key_statusTableAdapter();
            this.tableAdapterManager = new AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager();
            this.key_typeTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.Key_typeTableAdapter();
            this.keysTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.KeysTableAdapter();
            this.key_typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key_statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key_typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keysBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReadKey
            // 
            this.buttonReadKey.Location = new System.Drawing.Point(12, 92);
            this.buttonReadKey.Name = "buttonReadKey";
            this.buttonReadKey.Size = new System.Drawing.Size(106, 23);
            this.buttonReadKey.TabIndex = 16;
            this.buttonReadKey.Text = "Считать ключ";
            this.buttonReadKey.UseVisualStyleBackColor = true;
            this.buttonReadKey.Click += new System.EventHandler(this.buttonReadKey_Click);
            // 
            // buttonKeyAddEdit
            // 
            this.buttonKeyAddEdit.Location = new System.Drawing.Point(166, 92);
            this.buttonKeyAddEdit.Name = "buttonKeyAddEdit";
            this.buttonKeyAddEdit.Size = new System.Drawing.Size(106, 23);
            this.buttonKeyAddEdit.TabIndex = 15;
            this.buttonKeyAddEdit.Text = "Добавить запись";
            this.buttonKeyAddEdit.UseVisualStyleBackColor = true;
            this.buttonKeyAddEdit.Click += new System.EventHandler(this.buttonKeyAddEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Тип ключа";
            // 
            // comboBoxKeyType
            // 
            this.comboBoxKeyType.DataSource = this.key_typeBindingSource;
            this.comboBoxKeyType.DisplayMember = "Name";
            this.comboBoxKeyType.FormattingEnabled = true;
            this.comboBoxKeyType.Location = new System.Drawing.Point(104, 12);
            this.comboBoxKeyType.Name = "comboBoxKeyType";
            this.comboBoxKeyType.Size = new System.Drawing.Size(168, 21);
            this.comboBoxKeyType.TabIndex = 13;
            this.comboBoxKeyType.ValueMember = "ID_type";
            // 
            // comboBoxKeyStatus
            // 
            this.comboBoxKeyStatus.DataSource = this.key_statusBindingSource;
            this.comboBoxKeyStatus.DisplayMember = "Status";
            this.comboBoxKeyStatus.FormattingEnabled = true;
            this.comboBoxKeyStatus.Location = new System.Drawing.Point(104, 65);
            this.comboBoxKeyStatus.Name = "comboBoxKeyStatus";
            this.comboBoxKeyStatus.Size = new System.Drawing.Size(168, 21);
            this.comboBoxKeyStatus.TabIndex = 12;
            this.comboBoxKeyStatus.ValueMember = "ID_status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Статус ключа";
            // 
            // Ключ
            // 
            this.Ключ.AutoSize = true;
            this.Ключ.Location = new System.Drawing.Point(9, 42);
            this.Ключ.Name = "Ключ";
            this.Ключ.Size = new System.Drawing.Size(89, 13);
            this.Ключ.TabIndex = 10;
            this.Ключ.Text = "Значение ключа";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(104, 39);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(168, 20);
            this.textBoxKey.TabIndex = 9;
            // 
            // accessControlSystemDataSet
            // 
            this.accessControlSystemDataSet.DataSetName = "accessControlSystemDataSet";
            this.accessControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // key_statusBindingSource
            // 
            this.key_statusBindingSource.DataMember = "Key_status";
            this.key_statusBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // key_statusTableAdapter
            // 
            this.key_statusTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.JournalTableAdapter = null;
            this.tableAdapterManager.Key_statusTableAdapter = this.key_statusTableAdapter;
            this.tableAdapterManager.Key_typeTableAdapter = this.key_typeTableAdapter;
            this.tableAdapterManager.Key_userTableAdapter = null;
            this.tableAdapterManager.KeysTableAdapter = this.keysTableAdapter;
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
            // key_typeTableAdapter
            // 
            this.key_typeTableAdapter.ClearBeforeFill = true;
            // 
            // keysTableAdapter
            // 
            this.keysTableAdapter.ClearBeforeFill = true;
            // 
            // key_typeBindingSource
            // 
            this.key_typeBindingSource.DataMember = "Key_type";
            this.key_typeBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // keysBindingSource
            // 
            this.keysBindingSource.DataMember = "Keys";
            this.keysBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // FormKeysAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(283, 127);
            this.Controls.Add(this.buttonReadKey);
            this.Controls.Add(this.buttonKeyAddEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKeyType);
            this.Controls.Add(this.comboBoxKeyStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ключ);
            this.Controls.Add(this.textBoxKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(299, 165);
            this.MinimumSize = new System.Drawing.Size(299, 165);
            this.Name = "FormKeysAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление ключа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKeysAddEdit_FormClosing);
            this.Load += new System.EventHandler(this.FormKeysAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key_statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key_typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keysBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReadKey;
        private System.Windows.Forms.Button buttonKeyAddEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKeyType;
        private System.Windows.Forms.ComboBox comboBoxKeyStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ключ;
        private System.Windows.Forms.TextBox textBoxKey;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private System.Windows.Forms.BindingSource key_statusBindingSource;
        private accessControlSystemDataSetTableAdapters.Key_statusTableAdapter key_statusTableAdapter;
        private accessControlSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private accessControlSystemDataSetTableAdapters.Key_typeTableAdapter key_typeTableAdapter;
        private System.Windows.Forms.BindingSource key_typeBindingSource;
        private accessControlSystemDataSetTableAdapters.KeysTableAdapter keysTableAdapter;
        private System.Windows.Forms.BindingSource keysBindingSource;
    }
}