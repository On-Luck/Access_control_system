namespace AccessControlSystem
{
    partial class FormVisitorAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisitorAddEdit));
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.buttonLoadPhoto = new System.Windows.Forms.Button();
            this.pictureBoxVisitorAddEdit = new System.Windows.Forms.PictureBox();
            this.textBoxPh = new System.Windows.Forms.TextBox();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.textBoxPat = new System.Windows.Forms.TextBox();
            this.textBoxSname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.visitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitorTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.VisitorTableAdapter();
            this.tableAdapterManager = new AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisitorAddEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(379, 13);
            this.label11.TabIndex = 64;
            this.label11.Text = "Поля, отмеченные звездочкой, обязательны для заполнения.";
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.Location = new System.Drawing.Point(315, 241);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(153, 23);
            this.buttonAddEdit.TabIndex = 7;
            this.buttonAddEdit.Text = "Добавить запись";
            this.buttonAddEdit.UseVisualStyleBackColor = true;
            this.buttonAddEdit.Click += new System.EventHandler(this.buttonAddEdit_Click);
            // 
            // buttonLoadPhoto
            // 
            this.buttonLoadPhoto.Location = new System.Drawing.Point(315, 212);
            this.buttonLoadPhoto.Name = "buttonLoadPhoto";
            this.buttonLoadPhoto.Size = new System.Drawing.Size(153, 23);
            this.buttonLoadPhoto.TabIndex = 6;
            this.buttonLoadPhoto.Text = "Выбрать фотографию";
            this.buttonLoadPhoto.UseVisualStyleBackColor = true;
            this.buttonLoadPhoto.Click += new System.EventHandler(this.buttonLoadPhoto_Click);
            // 
            // pictureBoxVisitorAddEdit
            // 
            this.pictureBoxVisitorAddEdit.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxVisitorAddEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxVisitorAddEdit.Location = new System.Drawing.Point(315, 51);
            this.pictureBoxVisitorAddEdit.Name = "pictureBoxVisitorAddEdit";
            this.pictureBoxVisitorAddEdit.Size = new System.Drawing.Size(153, 153);
            this.pictureBoxVisitorAddEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVisitorAddEdit.TabIndex = 61;
            this.pictureBoxVisitorAddEdit.TabStop = false;
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
            this.label10.TabIndex = 53;
            this.label10.Text = "Фотография";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Паспорт *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Фамилия *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Имя *";
            // 
            // accessControlSystemDataSet
            // 
            this.accessControlSystemDataSet.DataSetName = "accessControlSystemDataSet";
            this.accessControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitorBindingSource
            // 
            this.visitorBindingSource.DataMember = "Visitor";
            this.visitorBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // visitorTableAdapter
            // 
            this.visitorTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitorTableAdapter = this.visitorTableAdapter;
            this.tableAdapterManager.WorkerTableAdapter = null;
            // 
            // FormVisitorAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(474, 272);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.buttonLoadPhoto);
            this.Controls.Add(this.pictureBoxVisitorAddEdit);
            this.Controls.Add(this.textBoxPh);
            this.Controls.Add(this.textBoxPas);
            this.Controls.Add(this.textBoxPat);
            this.Controls.Add(this.textBoxSname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 310);
            this.MinimumSize = new System.Drawing.Size(490, 310);
            this.Name = "FormVisitorAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление посетителя";
            this.Load += new System.EventHandler(this.FormVisitorAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisitorAddEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonAddEdit;
        private System.Windows.Forms.Button buttonLoadPhoto;
        private System.Windows.Forms.PictureBox pictureBoxVisitorAddEdit;
        private System.Windows.Forms.TextBox textBoxPh;
        private System.Windows.Forms.TextBox textBoxPas;
        private System.Windows.Forms.TextBox textBoxPat;
        private System.Windows.Forms.TextBox textBoxSname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private System.Windows.Forms.BindingSource visitorBindingSource;
        private accessControlSystemDataSetTableAdapters.VisitorTableAdapter visitorTableAdapter;
        private accessControlSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;

    }
}