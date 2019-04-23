namespace AccessControlSystem
{
    partial class FormVisitorBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisitorBook));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.visitorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.pictureBoxVisitor = new System.Windows.Forms.PictureBox();
            this.panelFindVisitor = new System.Windows.Forms.Panel();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxPat = new System.Windows.Forms.TextBox();
            this.textBoxSname = new System.Windows.Forms.TextBox();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.checkBoxPas = new System.Windows.Forms.CheckBox();
            this.checkBoxPat = new System.Windows.Forms.CheckBox();
            this.checkBoxPhone = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxSname = new System.Windows.Forms.CheckBox();
            this.visitorTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.VisitorTableAdapter();
            this.tableAdapterManager = new AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager();
            this.visitorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAddVisitor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditVisitor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteVisitor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBindKey = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisitor)).BeginInit();
            this.panelFindVisitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingNavigator)).BeginInit();
            this.visitorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelFindVisitor, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 407);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.visitorDataGridView, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxVisitor, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 321F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(753, 321);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // visitorDataGridView
            // 
            this.visitorDataGridView.AllowUserToAddRows = false;
            this.visitorDataGridView.AllowUserToDeleteRows = false;
            this.visitorDataGridView.AutoGenerateColumns = false;
            this.visitorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.visitorDataGridView.DataSource = this.visitorBindingSource;
            this.visitorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visitorDataGridView.Location = new System.Drawing.Point(3, 3);
            this.visitorDataGridView.Name = "visitorDataGridView";
            this.visitorDataGridView.ReadOnly = true;
            this.visitorDataGridView.Size = new System.Drawing.Size(547, 315);
            this.visitorDataGridView.TabIndex = 1;
            this.visitorDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.visitorDataGridView_CellEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_visitor";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Second_Name";
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
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Passport";
            this.dataGridViewTextBoxColumn6.HeaderText = "Паспорт";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 75;
            // 
            // visitorBindingSource
            // 
            this.visitorBindingSource.DataMember = "Visitor";
            this.visitorBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // accessControlSystemDataSet
            // 
            this.accessControlSystemDataSet.DataSetName = "accessControlSystemDataSet";
            this.accessControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBoxVisitor
            // 
            this.pictureBoxVisitor.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxVisitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxVisitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxVisitor.ErrorImage = global::AccessControlSystem.Properties.Resources.if_image_cancel_103591;
            this.pictureBoxVisitor.Image = global::AccessControlSystem.Properties.Resources.if_image_cancel_103591;
            this.pictureBoxVisitor.InitialImage = global::AccessControlSystem.Properties.Resources.if_image_cancel_103591;
            this.pictureBoxVisitor.Location = new System.Drawing.Point(556, 3);
            this.pictureBoxVisitor.Name = "pictureBoxVisitor";
            this.pictureBoxVisitor.Size = new System.Drawing.Size(194, 315);
            this.pictureBoxVisitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVisitor.TabIndex = 0;
            this.pictureBoxVisitor.TabStop = false;
            // 
            // panelFindVisitor
            // 
            this.panelFindVisitor.Controls.Add(this.textBoxPhone);
            this.panelFindVisitor.Controls.Add(this.textBoxPat);
            this.panelFindVisitor.Controls.Add(this.textBoxSname);
            this.panelFindVisitor.Controls.Add(this.textBoxPas);
            this.panelFindVisitor.Controls.Add(this.textBoxName);
            this.panelFindVisitor.Controls.Add(this.buttonRefresh);
            this.panelFindVisitor.Controls.Add(this.buttonFind);
            this.panelFindVisitor.Controls.Add(this.checkBoxPas);
            this.panelFindVisitor.Controls.Add(this.checkBoxPat);
            this.panelFindVisitor.Controls.Add(this.checkBoxPhone);
            this.panelFindVisitor.Controls.Add(this.checkBoxName);
            this.panelFindVisitor.Controls.Add(this.checkBoxSname);
            this.panelFindVisitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFindVisitor.Location = new System.Drawing.Point(3, 330);
            this.panelFindVisitor.Name = "panelFindVisitor";
            this.panelFindVisitor.Size = new System.Drawing.Size(753, 74);
            this.panelFindVisitor.TabIndex = 1;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(353, 1);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(150, 20);
            this.textBoxPhone.TabIndex = 7;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDigit_KeyPress);
            // 
            // textBoxPat
            // 
            this.textBoxPat.Location = new System.Drawing.Point(95, 48);
            this.textBoxPat.Name = "textBoxPat";
            this.textBoxPat.Size = new System.Drawing.Size(150, 20);
            this.textBoxPat.TabIndex = 5;
            this.textBoxPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxSname
            // 
            this.textBoxSname.Location = new System.Drawing.Point(95, 1);
            this.textBoxSname.Name = "textBoxSname";
            this.textBoxSname.Size = new System.Drawing.Size(150, 20);
            this.textBoxSname.TabIndex = 1;
            this.textBoxSname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxPas
            // 
            this.textBoxPas.Location = new System.Drawing.Point(353, 24);
            this.textBoxPas.Name = "textBoxPas";
            this.textBoxPas.Size = new System.Drawing.Size(150, 20);
            this.textBoxPas.TabIndex = 9;
            this.textBoxPas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDigit_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(95, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 20);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(652, 37);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(92, 23);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "Сброс";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(652, 8);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(92, 23);
            this.buttonFind.TabIndex = 10;
            this.buttonFind.Text = "Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // checkBoxPas
            // 
            this.checkBoxPas.AutoSize = true;
            this.checkBoxPas.Location = new System.Drawing.Point(267, 26);
            this.checkBoxPas.Name = "checkBoxPas";
            this.checkBoxPas.Size = new System.Drawing.Size(69, 17);
            this.checkBoxPas.TabIndex = 8;
            this.checkBoxPas.Text = "Паспорт";
            this.checkBoxPas.UseVisualStyleBackColor = true;
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
            // checkBoxPhone
            // 
            this.checkBoxPhone.AutoSize = true;
            this.checkBoxPhone.Location = new System.Drawing.Point(267, 3);
            this.checkBoxPhone.Name = "checkBoxPhone";
            this.checkBoxPhone.Size = new System.Drawing.Size(71, 17);
            this.checkBoxPhone.TabIndex = 6;
            this.checkBoxPhone.Text = "Телефон";
            this.checkBoxPhone.UseVisualStyleBackColor = true;
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
            // visitorBindingNavigator
            // 
            this.visitorBindingNavigator.AddNewItem = null;
            this.visitorBindingNavigator.BindingSource = this.visitorBindingSource;
            this.visitorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.visitorBindingNavigator.DeleteItem = null;
            this.visitorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButtonAddVisitor,
            this.toolStripButtonEditVisitor,
            this.toolStripButtonDeleteVisitor,
            this.toolStripButtonRefresh,
            this.toolStripSeparator1,
            this.toolStripButtonBindKey});
            this.visitorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.visitorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.visitorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.visitorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.visitorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.visitorBindingNavigator.Name = "visitorBindingNavigator";
            this.visitorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.visitorBindingNavigator.Size = new System.Drawing.Size(759, 25);
            this.visitorBindingNavigator.TabIndex = 1;
            this.visitorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorMoveLastItem.Image = global::AccessControlSystem.Properties.Resources.if_skip_next_326513;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAddVisitor
            // 
            this.toolStripButtonAddVisitor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddVisitor.Image = global::AccessControlSystem.Properties.Resources.if_plus_24_103172;
            this.toolStripButtonAddVisitor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddVisitor.Name = "toolStripButtonAddVisitor";
            this.toolStripButtonAddVisitor.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAddVisitor.Text = "Добавить нового посетителя";
            this.toolStripButtonAddVisitor.Click += new System.EventHandler(this.toolStripButtonAddVisitor_Click);
            // 
            // toolStripButtonEditVisitor
            // 
            this.toolStripButtonEditVisitor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditVisitor.Image = global::AccessControlSystem.Properties.Resources.if_new_24_103173;
            this.toolStripButtonEditVisitor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditVisitor.Name = "toolStripButtonEditVisitor";
            this.toolStripButtonEditVisitor.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditVisitor.Text = "Изменить даные посетителя";
            this.toolStripButtonEditVisitor.Click += new System.EventHandler(this.toolStripButtonEditVisitor_Click);
            // 
            // toolStripButtonDeleteVisitor
            // 
            this.toolStripButtonDeleteVisitor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteVisitor.Image = global::AccessControlSystem.Properties.Resources._186389_512;
            this.toolStripButtonDeleteVisitor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteVisitor.Name = "toolStripButtonDeleteVisitor";
            this.toolStripButtonDeleteVisitor.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDeleteVisitor.Text = "Удалить запись о посетителе";
            this.toolStripButtonDeleteVisitor.Click += new System.EventHandler(this.toolStripButtonDeleteVisitor_Click);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = global::AccessControlSystem.Properties.Resources.if_refresh27_216529;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "toolStripButton1";
            this.toolStripButtonRefresh.ToolTipText = "Обновить набор данных";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripButtonBindKey
            // 
            this.toolStripButtonBindKey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBindKey.Image = global::AccessControlSystem.Properties.Resources.if_rules_3018564;
            this.toolStripButtonBindKey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBindKey.Name = "toolStripButtonBindKey";
            this.toolStripButtonBindKey.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBindKey.Text = "toolStripButton1";
            this.toolStripButtonBindKey.ToolTipText = "Прикрепленные ключи";
            this.toolStripButtonBindKey.Click += new System.EventHandler(this.toolStripButtonBindKey_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // FormVisitorBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 432);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.visitorBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(775, 470);
            this.Name = "FormVisitorBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник посетителей";
            this.Load += new System.EventHandler(this.FormVisitorBook_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visitorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisitor)).EndInit();
            this.panelFindVisitor.ResumeLayout(false);
            this.panelFindVisitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingNavigator)).EndInit();
            this.visitorBindingNavigator.ResumeLayout(false);
            this.visitorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxVisitor;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private System.Windows.Forms.BindingSource visitorBindingSource;
        private accessControlSystemDataSetTableAdapters.VisitorTableAdapter visitorTableAdapter;
        private accessControlSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator visitorBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView visitorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddVisitor;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditVisitor;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteVisitor;
        private System.Windows.Forms.Panel panelFindVisitor;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxPat;
        private System.Windows.Forms.TextBox textBoxSname;
        private System.Windows.Forms.TextBox textBoxPas;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.CheckBox checkBoxPas;
        private System.Windows.Forms.CheckBox checkBoxPat;
        private System.Windows.Forms.CheckBox checkBoxPhone;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxSname;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBindKey;

    }
}