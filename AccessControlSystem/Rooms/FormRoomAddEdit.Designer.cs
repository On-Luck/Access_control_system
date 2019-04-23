namespace AccessControlSystem
{
    partial class FormRoomAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoomAddEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.textBoxBlock = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.richTextBoxDes = new System.Windows.Forms.RichTextBox();
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.RoomsTableAdapter();
            this.tableAdapterManager = new AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Этаж";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Корпус";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тип";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(75, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(230, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Location = new System.Drawing.Point(75, 32);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(230, 20);
            this.textBoxFloor.TabIndex = 2;
            // 
            // textBoxBlock
            // 
            this.textBoxBlock.Location = new System.Drawing.Point(75, 58);
            this.textBoxBlock.Name = "textBoxBlock";
            this.textBoxBlock.Size = new System.Drawing.Size(230, 20);
            this.textBoxBlock.TabIndex = 3;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(75, 84);
            this.textBoxType.MaxLength = 20;
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(230, 20);
            this.textBoxType.TabIndex = 4;
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.Location = new System.Drawing.Point(195, 254);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(110, 23);
            this.buttonAddEdit.TabIndex = 6;
            this.buttonAddEdit.Text = "Добавить запись";
            this.buttonAddEdit.UseVisualStyleBackColor = true;
            this.buttonAddEdit.Click += new System.EventHandler(this.buttonAddEdit_Click);
            // 
            // richTextBoxDes
            // 
            this.richTextBoxDes.Location = new System.Drawing.Point(75, 110);
            this.richTextBoxDes.MaxLength = 254;
            this.richTextBoxDes.Name = "richTextBoxDes";
            this.richTextBoxDes.Size = new System.Drawing.Size(230, 138);
            this.richTextBoxDes.TabIndex = 5;
            this.richTextBoxDes.Text = "";
            // 
            // accessControlSystemDataSet
            // 
            this.accessControlSystemDataSet.DataSetName = "accessControlSystemDataSet";
            this.accessControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // FormRoomAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 282);
            this.Controls.Add(this.richTextBoxDes);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxBlock);
            this.Controls.Add(this.textBoxFloor);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 320);
            this.MinimumSize = new System.Drawing.Size(330, 320);
            this.Name = "FormRoomAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление объектов";
            this.Load += new System.EventHandler(this.FormRoomAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.TextBox textBoxBlock;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Button buttonAddEdit;
        private System.Windows.Forms.RichTextBox richTextBoxDes;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private accessControlSystemDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private accessControlSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}