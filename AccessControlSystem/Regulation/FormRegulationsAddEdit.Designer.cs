namespace AccessControlSystem
{
    partial class FormRegulationsAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegulationsAddEdit));
            this.dateTimePickerAccessTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAccessTimeTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxDes = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxSu = new System.Windows.Forms.CheckBox();
            this.checkBoxSa = new System.Windows.Forms.CheckBox();
            this.checkBoxFr = new System.Windows.Forms.CheckBox();
            this.checkBoxTh = new System.Windows.Forms.CheckBox();
            this.checkBoxWe = new System.Windows.Forms.CheckBox();
            this.checkBoxTu = new System.Windows.Forms.CheckBox();
            this.checkBoxMo = new System.Windows.Forms.CheckBox();
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.regulationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regulationsTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.RegulationsTableAdapter();
            this.tableAdapterManager = new AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regulationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerAccessTimeFrom
            // 
            this.dateTimePickerAccessTimeFrom.CustomFormat = "HH:mm";
            this.dateTimePickerAccessTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAccessTimeFrom.Location = new System.Drawing.Point(134, 13);
            this.dateTimePickerAccessTimeFrom.Name = "dateTimePickerAccessTimeFrom";
            this.dateTimePickerAccessTimeFrom.ShowUpDown = true;
            this.dateTimePickerAccessTimeFrom.Size = new System.Drawing.Size(89, 20);
            this.dateTimePickerAccessTimeFrom.TabIndex = 2;
            this.dateTimePickerAccessTimeFrom.Value = new System.DateTime(2018, 5, 22, 8, 0, 0, 0);
            // 
            // dateTimePickerAccessTimeTo
            // 
            this.dateTimePickerAccessTimeTo.CustomFormat = "HH:mm";
            this.dateTimePickerAccessTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAccessTimeTo.Location = new System.Drawing.Point(134, 39);
            this.dateTimePickerAccessTimeTo.Name = "dateTimePickerAccessTimeTo";
            this.dateTimePickerAccessTimeTo.ShowUpDown = true;
            this.dateTimePickerAccessTimeTo.Size = new System.Drawing.Size(89, 20);
            this.dateTimePickerAccessTimeTo.TabIndex = 4;
            this.dateTimePickerAccessTimeTo.Value = new System.DateTime(2018, 5, 22, 20, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Описание";
            // 
            // richTextBoxDes
            // 
            this.richTextBoxDes.Location = new System.Drawing.Point(21, 135);
            this.richTextBoxDes.Name = "richTextBoxDes";
            this.richTextBoxDes.Size = new System.Drawing.Size(343, 97);
            this.richTextBoxDes.TabIndex = 12;
            this.richTextBoxDes.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Дни недели:";
            // 
            // checkBoxSu
            // 
            this.checkBoxSu.AutoSize = true;
            this.checkBoxSu.Location = new System.Drawing.Point(325, 84);
            this.checkBoxSu.Name = "checkBoxSu";
            this.checkBoxSu.Size = new System.Drawing.Size(39, 17);
            this.checkBoxSu.TabIndex = 11;
            this.checkBoxSu.Text = "Вс";
            this.checkBoxSu.UseVisualStyleBackColor = true;
            // 
            // checkBoxSa
            // 
            this.checkBoxSa.AutoSize = true;
            this.checkBoxSa.Location = new System.Drawing.Point(275, 84);
            this.checkBoxSa.Name = "checkBoxSa";
            this.checkBoxSa.Size = new System.Drawing.Size(39, 17);
            this.checkBoxSa.TabIndex = 10;
            this.checkBoxSa.Text = "Сб";
            this.checkBoxSa.UseVisualStyleBackColor = true;
            // 
            // checkBoxFr
            // 
            this.checkBoxFr.AutoSize = true;
            this.checkBoxFr.Location = new System.Drawing.Point(225, 84);
            this.checkBoxFr.Name = "checkBoxFr";
            this.checkBoxFr.Size = new System.Drawing.Size(39, 17);
            this.checkBoxFr.TabIndex = 9;
            this.checkBoxFr.Text = "Пт";
            this.checkBoxFr.UseVisualStyleBackColor = true;
            // 
            // checkBoxTh
            // 
            this.checkBoxTh.AutoSize = true;
            this.checkBoxTh.Location = new System.Drawing.Point(175, 84);
            this.checkBoxTh.Name = "checkBoxTh";
            this.checkBoxTh.Size = new System.Drawing.Size(39, 17);
            this.checkBoxTh.TabIndex = 8;
            this.checkBoxTh.Text = "Чт";
            this.checkBoxTh.UseVisualStyleBackColor = true;
            // 
            // checkBoxWe
            // 
            this.checkBoxWe.AutoSize = true;
            this.checkBoxWe.Location = new System.Drawing.Point(125, 84);
            this.checkBoxWe.Name = "checkBoxWe";
            this.checkBoxWe.Size = new System.Drawing.Size(39, 17);
            this.checkBoxWe.TabIndex = 7;
            this.checkBoxWe.Text = "Ср";
            this.checkBoxWe.UseVisualStyleBackColor = true;
            // 
            // checkBoxTu
            // 
            this.checkBoxTu.AutoSize = true;
            this.checkBoxTu.Location = new System.Drawing.Point(75, 84);
            this.checkBoxTu.Name = "checkBoxTu";
            this.checkBoxTu.Size = new System.Drawing.Size(38, 17);
            this.checkBoxTu.TabIndex = 6;
            this.checkBoxTu.Text = "Вт";
            this.checkBoxTu.UseVisualStyleBackColor = true;
            // 
            // checkBoxMo
            // 
            this.checkBoxMo.AutoSize = true;
            this.checkBoxMo.Location = new System.Drawing.Point(25, 84);
            this.checkBoxMo.Name = "checkBoxMo";
            this.checkBoxMo.Size = new System.Drawing.Size(40, 17);
            this.checkBoxMo.TabIndex = 5;
            this.checkBoxMo.Text = "Пн";
            this.checkBoxMo.UseVisualStyleBackColor = true;
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.Location = new System.Drawing.Point(211, 238);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(153, 23);
            this.buttonAddEdit.TabIndex = 13;
            this.buttonAddEdit.Text = "Добавить запись";
            this.buttonAddEdit.UseVisualStyleBackColor = true;
            this.buttonAddEdit.Click += new System.EventHandler(this.buttonAddEdit_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Время доступа с";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 41);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(117, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Время доступа до";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // accessControlSystemDataSet
            // 
            this.accessControlSystemDataSet.DataSetName = "accessControlSystemDataSet";
            this.accessControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regulationsBindingSource
            // 
            this.regulationsBindingSource.DataMember = "Regulations";
            this.regulationsBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // regulationsTableAdapter
            // 
            this.regulationsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.RegulationsTableAdapter = this.regulationsTableAdapter;
            this.tableAdapterManager.Room_regulationTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitorTableAdapter = null;
            this.tableAdapterManager.WorkerTableAdapter = null;
            // 
            // FormRegulationsAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(379, 267);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxSu);
            this.Controls.Add(this.checkBoxSa);
            this.Controls.Add(this.checkBoxFr);
            this.Controls.Add(this.checkBoxTh);
            this.Controls.Add(this.checkBoxWe);
            this.Controls.Add(this.checkBoxTu);
            this.Controls.Add(this.checkBoxMo);
            this.Controls.Add(this.richTextBoxDes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerAccessTimeTo);
            this.Controls.Add(this.dateTimePickerAccessTimeFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(395, 305);
            this.MinimumSize = new System.Drawing.Size(395, 305);
            this.Name = "FormRegulationsAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление правила";
            this.Load += new System.EventHandler(this.FormRegulationsAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regulationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerAccessTimeFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerAccessTimeTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxDes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxSu;
        private System.Windows.Forms.CheckBox checkBoxSa;
        private System.Windows.Forms.CheckBox checkBoxFr;
        private System.Windows.Forms.CheckBox checkBoxTh;
        private System.Windows.Forms.CheckBox checkBoxWe;
        private System.Windows.Forms.CheckBox checkBoxTu;
        private System.Windows.Forms.CheckBox checkBoxMo;
        private System.Windows.Forms.Button buttonAddEdit;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private System.Windows.Forms.BindingSource regulationsBindingSource;
        private accessControlSystemDataSetTableAdapters.RegulationsTableAdapter regulationsTableAdapter;
        private accessControlSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}