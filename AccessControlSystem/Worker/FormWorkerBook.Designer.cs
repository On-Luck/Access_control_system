namespace AccessControlSystem
{
    partial class FormWorkerBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorkerBook));
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxPos = new System.Windows.Forms.TextBox();
            this.textBoxDep = new System.Windows.Forms.TextBox();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPh = new System.Windows.Forms.TextBox();
            this.textBoxEdu = new System.Windows.Forms.TextBox();
            this.textBoxPat = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.view_workerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.pictureBoxWorker = new System.Windows.Forms.PictureBox();
            this.panelFindWorker = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSname = new System.Windows.Forms.TextBox();
            this.checkBoxPos = new System.Windows.Forms.CheckBox();
            this.checkBoxDep = new System.Windows.Forms.CheckBox();
            this.checkBoxEdu = new System.Windows.Forms.CheckBox();
            this.checkBoxPas = new System.Windows.Forms.CheckBox();
            this.checkBoxEmail = new System.Windows.Forms.CheckBox();
            this.checkBoxPhone = new System.Windows.Forms.CheckBox();
            this.checkBoxPat = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxSname = new System.Windows.Forms.CheckBox();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.WorkerTableAdapter();
            this.tableAdapterManager = new AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.workerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddWorker = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditWorker = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteWorker = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.view_workerTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.View_workerTableAdapter();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonBindKey = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_workerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorker)).BeginInit();
            this.panelFindWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingNavigator)).BeginInit();
            this.workerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(764, 37);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(92, 23);
            this.buttonRefresh.TabIndex = 19;
            this.buttonRefresh.Text = "Сброс";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click_1);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(764, 8);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(92, 23);
            this.buttonFind.TabIndex = 18;
            this.buttonFind.Text = "Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxPos
            // 
            this.textBoxPos.Location = new System.Drawing.Point(600, 47);
            this.textBoxPos.Name = "textBoxPos";
            this.textBoxPos.Size = new System.Drawing.Size(150, 20);
            this.textBoxPos.TabIndex = 17;
            this.textBoxPos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxDep
            // 
            this.textBoxDep.Location = new System.Drawing.Point(600, 24);
            this.textBoxDep.Name = "textBoxDep";
            this.textBoxDep.Size = new System.Drawing.Size(150, 20);
            this.textBoxDep.TabIndex = 15;
            this.textBoxDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxPas
            // 
            this.textBoxPas.Location = new System.Drawing.Point(335, 47);
            this.textBoxPas.Name = "textBoxPas";
            this.textBoxPas.Size = new System.Drawing.Size(150, 20);
            this.textBoxPas.TabIndex = 11;
            this.textBoxPas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDigit_KeyPress);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(335, 24);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(150, 20);
            this.textBoxEmail.TabIndex = 9;
            // 
            // textBoxPh
            // 
            this.textBoxPh.Location = new System.Drawing.Point(335, 1);
            this.textBoxPh.Name = "textBoxPh";
            this.textBoxPh.Size = new System.Drawing.Size(150, 20);
            this.textBoxPh.TabIndex = 7;
            this.textBoxPh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDigit_KeyPress);
            // 
            // textBoxEdu
            // 
            this.textBoxEdu.Location = new System.Drawing.Point(600, 1);
            this.textBoxEdu.Name = "textBoxEdu";
            this.textBoxEdu.Size = new System.Drawing.Size(150, 20);
            this.textBoxEdu.TabIndex = 13;
            this.textBoxEdu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxPat
            // 
            this.textBoxPat.Location = new System.Drawing.Point(90, 47);
            this.textBoxPat.Name = "textBoxPat";
            this.textBoxPat.Size = new System.Drawing.Size(150, 20);
            this.textBoxPat.TabIndex = 5;
            this.textBoxPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelFindWorker, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(879, 407);
            this.tableLayoutPanelMain.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.view_workerDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxWorker, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(873, 321);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // view_workerDataGridView
            // 
            this.view_workerDataGridView.AllowUserToAddRows = false;
            this.view_workerDataGridView.AllowUserToDeleteRows = false;
            this.view_workerDataGridView.AutoGenerateColumns = false;
            this.view_workerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_workerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn11});
            this.view_workerDataGridView.DataSource = this.view_workerBindingSource;
            this.view_workerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_workerDataGridView.Location = new System.Drawing.Point(3, 3);
            this.view_workerDataGridView.Name = "view_workerDataGridView";
            this.view_workerDataGridView.ReadOnly = true;
            this.view_workerDataGridView.Size = new System.Drawing.Size(667, 315);
            this.view_workerDataGridView.TabIndex = 1;
            this.view_workerDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_workerDataGridView_RowEnter);
            this.view_workerDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.view_workerDataGridView_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_worker";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Second_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 81;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 54;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Patronymic";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 79;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 77;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 57;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Passport";
            this.dataGridViewTextBoxColumn7.HeaderText = "Паспорт";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 75;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Education";
            this.dataGridViewTextBoxColumn8.HeaderText = "Образование";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Dep";
            this.dataGridViewTextBoxColumn12.HeaderText = "Отдел";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 63;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Pos";
            this.dataGridViewTextBoxColumn11.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 90;
            // 
            // view_workerBindingSource
            // 
            this.view_workerBindingSource.DataMember = "View_worker";
            this.view_workerBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // accessControlSystemDataSet
            // 
            this.accessControlSystemDataSet.DataSetName = "accessControlSystemDataSet";
            this.accessControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBoxWorker
            // 
            this.pictureBoxWorker.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxWorker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxWorker.ErrorImage = global::AccessControlSystem.Properties.Resources.if_image_cancel_103591;
            this.pictureBoxWorker.Image = global::AccessControlSystem.Properties.Resources.if_image_cancel_103591;
            this.pictureBoxWorker.InitialImage = global::AccessControlSystem.Properties.Resources.if_image_cancel_103591;
            this.pictureBoxWorker.Location = new System.Drawing.Point(676, 3);
            this.pictureBoxWorker.Name = "pictureBoxWorker";
            this.pictureBoxWorker.Size = new System.Drawing.Size(194, 315);
            this.pictureBoxWorker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWorker.TabIndex = 1;
            this.pictureBoxWorker.TabStop = false;
            // 
            // panelFindWorker
            // 
            this.panelFindWorker.Controls.Add(this.buttonRefresh);
            this.panelFindWorker.Controls.Add(this.buttonFind);
            this.panelFindWorker.Controls.Add(this.textBoxPos);
            this.panelFindWorker.Controls.Add(this.textBoxDep);
            this.panelFindWorker.Controls.Add(this.textBoxEdu);
            this.panelFindWorker.Controls.Add(this.textBoxPas);
            this.panelFindWorker.Controls.Add(this.textBoxEmail);
            this.panelFindWorker.Controls.Add(this.textBoxPh);
            this.panelFindWorker.Controls.Add(this.textBoxPat);
            this.panelFindWorker.Controls.Add(this.textBoxName);
            this.panelFindWorker.Controls.Add(this.textBoxSname);
            this.panelFindWorker.Controls.Add(this.checkBoxPos);
            this.panelFindWorker.Controls.Add(this.checkBoxDep);
            this.panelFindWorker.Controls.Add(this.checkBoxEdu);
            this.panelFindWorker.Controls.Add(this.checkBoxPas);
            this.panelFindWorker.Controls.Add(this.checkBoxEmail);
            this.panelFindWorker.Controls.Add(this.checkBoxPhone);
            this.panelFindWorker.Controls.Add(this.checkBoxPat);
            this.panelFindWorker.Controls.Add(this.checkBoxName);
            this.panelFindWorker.Controls.Add(this.checkBoxSname);
            this.panelFindWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFindWorker.Location = new System.Drawing.Point(3, 330);
            this.panelFindWorker.Name = "panelFindWorker";
            this.panelFindWorker.Size = new System.Drawing.Size(873, 74);
            this.panelFindWorker.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(90, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 20);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxSname
            // 
            this.textBoxSname.Location = new System.Drawing.Point(90, 1);
            this.textBoxSname.Name = "textBoxSname";
            this.textBoxSname.Size = new System.Drawing.Size(150, 20);
            this.textBoxSname.TabIndex = 1;
            this.textBoxSname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // checkBoxPos
            // 
            this.checkBoxPos.AutoSize = true;
            this.checkBoxPos.Location = new System.Drawing.Point(500, 49);
            this.checkBoxPos.Name = "checkBoxPos";
            this.checkBoxPos.Size = new System.Drawing.Size(84, 17);
            this.checkBoxPos.TabIndex = 16;
            this.checkBoxPos.Text = "Должность";
            this.checkBoxPos.UseVisualStyleBackColor = true;
            // 
            // checkBoxDep
            // 
            this.checkBoxDep.AutoSize = true;
            this.checkBoxDep.Location = new System.Drawing.Point(500, 26);
            this.checkBoxDep.Name = "checkBoxDep";
            this.checkBoxDep.Size = new System.Drawing.Size(57, 17);
            this.checkBoxDep.TabIndex = 14;
            this.checkBoxDep.Text = "Отдел";
            this.checkBoxDep.UseVisualStyleBackColor = true;
            // 
            // checkBoxEdu
            // 
            this.checkBoxEdu.AutoSize = true;
            this.checkBoxEdu.Location = new System.Drawing.Point(500, 3);
            this.checkBoxEdu.Name = "checkBoxEdu";
            this.checkBoxEdu.Size = new System.Drawing.Size(94, 17);
            this.checkBoxEdu.TabIndex = 12;
            this.checkBoxEdu.Text = "Образование";
            this.checkBoxEdu.UseVisualStyleBackColor = true;
            // 
            // checkBoxPas
            // 
            this.checkBoxPas.AutoSize = true;
            this.checkBoxPas.Location = new System.Drawing.Point(258, 49);
            this.checkBoxPas.Name = "checkBoxPas";
            this.checkBoxPas.Size = new System.Drawing.Size(69, 17);
            this.checkBoxPas.TabIndex = 10;
            this.checkBoxPas.Text = "Паспорт";
            this.checkBoxPas.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.Location = new System.Drawing.Point(258, 26);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(51, 17);
            this.checkBoxEmail.TabIndex = 8;
            this.checkBoxEmail.Text = "Email";
            this.checkBoxEmail.UseVisualStyleBackColor = true;
            // 
            // checkBoxPhone
            // 
            this.checkBoxPhone.AutoSize = true;
            this.checkBoxPhone.Location = new System.Drawing.Point(258, 3);
            this.checkBoxPhone.Name = "checkBoxPhone";
            this.checkBoxPhone.Size = new System.Drawing.Size(71, 17);
            this.checkBoxPhone.TabIndex = 6;
            this.checkBoxPhone.Text = "Телефон";
            this.checkBoxPhone.UseVisualStyleBackColor = true;
            // 
            // checkBoxPat
            // 
            this.checkBoxPat.AutoSize = true;
            this.checkBoxPat.Location = new System.Drawing.Point(9, 49);
            this.checkBoxPat.Name = "checkBoxPat";
            this.checkBoxPat.Size = new System.Drawing.Size(73, 17);
            this.checkBoxPat.TabIndex = 4;
            this.checkBoxPat.Text = "Отчество";
            this.checkBoxPat.UseVisualStyleBackColor = true;
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(9, 26);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(48, 17);
            this.checkBoxName.TabIndex = 2;
            this.checkBoxName.Text = "Имя";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // checkBoxSname
            // 
            this.checkBoxSname.AutoSize = true;
            this.checkBoxSname.Location = new System.Drawing.Point(9, 3);
            this.checkBoxSname.Name = "checkBoxSname";
            this.checkBoxSname.Size = new System.Drawing.Size(75, 17);
            this.checkBoxSname.TabIndex = 0;
            this.checkBoxSname.Text = "Фамилия";
            this.checkBoxSname.UseVisualStyleBackColor = true;
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
            this.tableAdapterManager.WorkerTableAdapter = this.workerTableAdapter;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // workerBindingNavigator
            // 
            this.workerBindingNavigator.AddNewItem = null;
            this.workerBindingNavigator.BindingSource = this.view_workerBindingSource;
            this.workerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.workerBindingNavigator.DeleteItem = null;
            this.workerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButtonAddWorker,
            this.toolStripButtonEditWorker,
            this.toolStripButtonDeleteWorker,
            this.toolStripButtonRefresh,
            this.toolStripSeparator1,
            this.toolStripButtonBindKey});
            this.workerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.workerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.workerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.workerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.workerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.workerBindingNavigator.Name = "workerBindingNavigator";
            this.workerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.workerBindingNavigator.Size = new System.Drawing.Size(879, 25);
            this.workerBindingNavigator.TabIndex = 3;
            this.workerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::AccessControlSystem.Properties.Resources._326513_512;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::AccessControlSystem.Properties.Resources._326513_512__1_;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::AccessControlSystem.Properties.Resources._326513_512__2_;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::AccessControlSystem.Properties.Resources.if_skip_next_3265131;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // toolStripButtonAddWorker
            // 
            this.toolStripButtonAddWorker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddWorker.Image = global::AccessControlSystem.Properties.Resources.if_plus_24_103172;
            this.toolStripButtonAddWorker.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddWorker.Name = "toolStripButtonAddWorker";
            this.toolStripButtonAddWorker.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAddWorker.Text = "Добавить запись в таблицу";
            this.toolStripButtonAddWorker.ToolTipText = "Добавить запись в таблицу";
            this.toolStripButtonAddWorker.Click += new System.EventHandler(this.toolStripButtonAddWorker_Click);
            // 
            // toolStripButtonEditWorker
            // 
            this.toolStripButtonEditWorker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditWorker.Image = global::AccessControlSystem.Properties.Resources.if_new_24_103173;
            this.toolStripButtonEditWorker.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditWorker.Name = "toolStripButtonEditWorker";
            this.toolStripButtonEditWorker.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditWorker.Text = "Изменить выбранную запись";
            this.toolStripButtonEditWorker.ToolTipText = "Изменить выбранную запись в таблице";
            this.toolStripButtonEditWorker.Click += new System.EventHandler(this.toolStripButtonEditWorker_Click);
            // 
            // toolStripButtonDeleteWorker
            // 
            this.toolStripButtonDeleteWorker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteWorker.Image = global::AccessControlSystem.Properties.Resources._186389_512;
            this.toolStripButtonDeleteWorker.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteWorker.Name = "toolStripButtonDeleteWorker";
            this.toolStripButtonDeleteWorker.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDeleteWorker.Text = "Удалить выбранную запись";
            this.toolStripButtonDeleteWorker.ToolTipText = "Удалить выбранную запись";
            this.toolStripButtonDeleteWorker.Click += new System.EventHandler(this.toolStripButtonDeleteWorker_Click);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = global::AccessControlSystem.Properties.Resources.if_refresh27_216529;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.ToolTipText = "Обновить набор данных";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // view_workerTableAdapter
            // 
            this.view_workerTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonBindKey
            // 
            this.toolStripButtonBindKey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBindKey.Image = global::AccessControlSystem.Properties.Resources.if_rules_3018564;
            this.toolStripButtonBindKey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBindKey.Name = "toolStripButtonBindKey";
            this.toolStripButtonBindKey.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBindKey.Text = "toolStripButton1";
            this.toolStripButtonBindKey.ToolTipText = "Список активных привязанных ключей\r\n";
            this.toolStripButtonBindKey.Click += new System.EventHandler(this.toolStripButtonBindKey_Click);
            // 
            // FormWorkerBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 432);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.workerBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(895, 470);
            this.Name = "FormWorkerBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник сотрудников";
            this.Load += new System.EventHandler(this.FormWorkerBook_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_workerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorker)).EndInit();
            this.panelFindWorker.ResumeLayout(false);
            this.panelFindWorker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingNavigator)).EndInit();
            this.workerBindingNavigator.ResumeLayout(false);
            this.workerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxPos;
        private System.Windows.Forms.TextBox textBoxDep;
        private System.Windows.Forms.TextBox textBoxPas;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPh;
        private System.Windows.Forms.TextBox textBoxEdu;
        private System.Windows.Forms.TextBox textBoxPat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxWorker;
        private System.Windows.Forms.Panel panelFindWorker;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSname;
        private System.Windows.Forms.CheckBox checkBoxPos;
        private System.Windows.Forms.CheckBox checkBoxDep;
        private System.Windows.Forms.CheckBox checkBoxEdu;
        private System.Windows.Forms.CheckBox checkBoxPas;
        private System.Windows.Forms.CheckBox checkBoxEmail;
        private System.Windows.Forms.CheckBox checkBoxPhone;
        private System.Windows.Forms.CheckBox checkBoxPat;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxSname;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private accessControlSystemDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
        private accessControlSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddWorker;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditWorker;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteWorker;
        private System.Windows.Forms.BindingNavigator workerBindingNavigator;
        private System.Windows.Forms.BindingSource view_workerBindingSource;
        private accessControlSystemDataSetTableAdapters.View_workerTableAdapter view_workerTableAdapter;
        private System.Windows.Forms.DataGridView view_workerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBindKey;
    }
}