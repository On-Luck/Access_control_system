namespace AccessControlSystem
{
    partial class FormWorker_AddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorker_AddEdit));
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.buttonLoadPhoto = new System.Windows.Forms.Button();
            this.textBoxEdu = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPh = new System.Windows.Forms.TextBox();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.textBoxPat = new System.Windows.Forms.TextBox();
            this.textBoxSname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPos = new System.Windows.Forms.ComboBox();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.comboBoxDep = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxWorAddEdit = new System.Windows.Forms.PictureBox();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.WorkerTableAdapter();
            this.tableAdapterManager = new AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager();
            this.departmentTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.DepartmentTableAdapter();
            this.positionTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.PositionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorAddEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(379, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Поля, отмеченные звездочкой, обязательны для заполнения.";
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.Location = new System.Drawing.Point(315, 241);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(153, 23);
            this.buttonAddEdit.TabIndex = 11;
            this.buttonAddEdit.Text = "Добавить запись";
            this.buttonAddEdit.UseVisualStyleBackColor = true;
            this.buttonAddEdit.Click += new System.EventHandler(this.buttonAddEdit_Click);
            // 
            // buttonLoadPhoto
            // 
            this.buttonLoadPhoto.Location = new System.Drawing.Point(315, 212);
            this.buttonLoadPhoto.Name = "buttonLoadPhoto";
            this.buttonLoadPhoto.Size = new System.Drawing.Size(153, 23);
            this.buttonLoadPhoto.TabIndex = 10;
            this.buttonLoadPhoto.Text = "Выбрать фотографию";
            this.buttonLoadPhoto.UseVisualStyleBackColor = true;
            this.buttonLoadPhoto.Click += new System.EventHandler(this.buttonLoadPhoto_Click);
            // 
            // textBoxEdu
            // 
            this.textBoxEdu.Location = new System.Drawing.Point(87, 188);
            this.textBoxEdu.Name = "textBoxEdu";
            this.textBoxEdu.Size = new System.Drawing.Size(204, 20);
            this.textBoxEdu.TabIndex = 7;
            this.textBoxEdu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(87, 162);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(204, 20);
            this.textBoxEmail.TabIndex = 6;
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmail_KeyPress);
            // 
            // textBoxPh
            // 
            this.textBoxPh.Location = new System.Drawing.Point(87, 136);
            this.textBoxPh.Name = "textBoxPh";
            this.textBoxPh.Size = new System.Drawing.Size(204, 20);
            this.textBoxPh.TabIndex = 5;
            this.textBoxPh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDigit_KeyPress);
            // 
            // textBoxPas
            // 
            this.textBoxPas.Location = new System.Drawing.Point(87, 110);
            this.textBoxPas.Name = "textBoxPas";
            this.textBoxPas.Size = new System.Drawing.Size(204, 20);
            this.textBoxPas.TabIndex = 4;
            this.textBoxPas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDigit_KeyPress);
            // 
            // textBoxPat
            // 
            this.textBoxPat.Location = new System.Drawing.Point(87, 84);
            this.textBoxPat.Name = "textBoxPat";
            this.textBoxPat.Size = new System.Drawing.Size(204, 20);
            this.textBoxPat.TabIndex = 3;
            this.textBoxPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxSname
            // 
            this.textBoxSname.Location = new System.Drawing.Point(87, 32);
            this.textBoxSname.Name = "textBoxSname";
            this.textBoxSname.Size = new System.Drawing.Size(204, 20);
            this.textBoxSname.TabIndex = 1;
            this.textBoxSname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(87, 58);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(204, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(312, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Фотография";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Должность *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Отдел *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Образование *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Паспорт *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Фамилия *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Имя *";
            // 
            // comboBoxPos
            // 
            this.comboBoxPos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxPos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPos.DataSource = this.positionBindingSource;
            this.comboBoxPos.DisplayMember = "Name";
            this.comboBoxPos.FormattingEnabled = true;
            this.comboBoxPos.Location = new System.Drawing.Point(87, 241);
            this.comboBoxPos.Name = "comboBoxPos";
            this.comboBoxPos.Size = new System.Drawing.Size(204, 21);
            this.comboBoxPos.TabIndex = 9;
            this.comboBoxPos.ValueMember = "ID_position";
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "Position";
            this.positionBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // accessControlSystemDataSet
            // 
            this.accessControlSystemDataSet.DataSetName = "accessControlSystemDataSet";
            this.accessControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxDep
            // 
            this.comboBoxDep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDep.DataSource = this.departmentBindingSource;
            this.comboBoxDep.DisplayMember = "Name";
            this.comboBoxDep.FormattingEnabled = true;
            this.comboBoxDep.Location = new System.Drawing.Point(87, 214);
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.Size = new System.Drawing.Size(204, 21);
            this.comboBoxDep.TabIndex = 8;
            this.comboBoxDep.ValueMember = "ID_department";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // pictureBoxWorAddEdit
            // 
            this.pictureBoxWorAddEdit.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxWorAddEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWorAddEdit.Location = new System.Drawing.Point(315, 51);
            this.pictureBoxWorAddEdit.Name = "pictureBoxWorAddEdit";
            this.pictureBoxWorAddEdit.Size = new System.Drawing.Size(153, 153);
            this.pictureBoxWorAddEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWorAddEdit.TabIndex = 42;
            this.pictureBoxWorAddEdit.TabStop = false;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentTableAdapter = this.departmentTableAdapter;
            this.tableAdapterManager.JournalTableAdapter = null;
            this.tableAdapterManager.Key_statusTableAdapter = null;
            this.tableAdapterManager.Key_typeTableAdapter = null;
            this.tableAdapterManager.Key_userTableAdapter = null;
            this.tableAdapterManager.KeysTableAdapter = null;
            this.tableAdapterManager.Login_tableTableAdapter = null;
            this.tableAdapterManager.PositionTableAdapter = this.positionTableAdapter;
            this.tableAdapterManager.Regulation_keyTableAdapter = null;
            this.tableAdapterManager.RegulationsTableAdapter = null;
            this.tableAdapterManager.Room_regulationTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitorTableAdapter = null;
            this.tableAdapterManager.WorkerTableAdapter = this.workerTableAdapter;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // FormWorker_AddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(474, 272);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.buttonLoadPhoto);
            this.Controls.Add(this.pictureBoxWorAddEdit);
            this.Controls.Add(this.textBoxEdu);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPh);
            this.Controls.Add(this.textBoxPas);
            this.Controls.Add(this.textBoxPat);
            this.Controls.Add(this.textBoxSname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPos);
            this.Controls.Add(this.comboBoxDep);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 310);
            this.MinimumSize = new System.Drawing.Size(490, 310);
            this.Name = "FormWorker_AddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление сотрудника";
            this.Load += new System.EventHandler(this.FormWorker_AddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorAddEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonAddEdit;
        private System.Windows.Forms.Button buttonLoadPhoto;
        private System.Windows.Forms.PictureBox pictureBoxWorAddEdit;
        private System.Windows.Forms.TextBox textBoxEdu;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPh;
        private System.Windows.Forms.TextBox textBoxPas;
        private System.Windows.Forms.TextBox textBoxPat;
        private System.Windows.Forms.TextBox textBoxSname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPos;
        private System.Windows.Forms.ComboBox comboBoxDep;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private accessControlSystemDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
        private accessControlSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private accessControlSystemDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private accessControlSystemDataSetTableAdapters.PositionTableAdapter positionTableAdapter;
        private System.Windows.Forms.BindingSource positionBindingSource;
    }
}