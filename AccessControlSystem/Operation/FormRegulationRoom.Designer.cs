namespace AccessControlSystem
{
    partial class FormRegulationRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegulationRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDes = new System.Windows.Forms.TextBox();
            this.checkBoxSu = new System.Windows.Forms.CheckBox();
            this.checkBoxSa = new System.Windows.Forms.CheckBox();
            this.checkBoxFr = new System.Windows.Forms.CheckBox();
            this.checkBoxTh = new System.Windows.Forms.CheckBox();
            this.checkBoxWe = new System.Windows.Forms.CheckBox();
            this.checkBoxTu = new System.Windows.Forms.CheckBox();
            this.checkBoxMo = new System.Windows.Forms.CheckBox();
            this.checkBoxDes = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.view_regulation_roomDataGridView = new System.Windows.Forms.DataGridView();
            this.view_regulation_roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.view_regulation_roomTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.View_regulation_roomTableAdapter();
            this.tableAdapterManager = new AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager();
            this.view_regulation_roomBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.room_regulationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.room_regulationTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.Room_regulationTableAdapter();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.regulation_keyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regulation_keyTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.Regulation_keyTableAdapter();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_regulation_roomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_regulation_roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_regulation_roomBindingNavigator)).BeginInit();
            this.view_regulation_roomBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room_regulationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regulation_keyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.buttonFind);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxDes);
            this.panel1.Controls.Add(this.checkBoxSu);
            this.panel1.Controls.Add(this.checkBoxSa);
            this.panel1.Controls.Add(this.checkBoxFr);
            this.panel1.Controls.Add(this.checkBoxTh);
            this.panel1.Controls.Add(this.checkBoxWe);
            this.panel1.Controls.Add(this.checkBoxTu);
            this.panel1.Controls.Add(this.checkBoxMo);
            this.panel1.Controls.Add(this.checkBoxDes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 74);
            this.panel1.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(524, 42);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 23;
            this.buttonRefresh.Text = "Сброс";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(524, 13);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 22;
            this.buttonFind.Text = "Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Дни недели:";
            // 
            // textBoxDes
            // 
            this.textBoxDes.Location = new System.Drawing.Point(89, 7);
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.Size = new System.Drawing.Size(150, 20);
            this.textBoxDes.TabIndex = 20;
            // 
            // checkBoxSu
            // 
            this.checkBoxSu.AutoSize = true;
            this.checkBoxSu.Location = new System.Drawing.Point(389, 40);
            this.checkBoxSu.Name = "checkBoxSu";
            this.checkBoxSu.Size = new System.Drawing.Size(39, 17);
            this.checkBoxSu.TabIndex = 19;
            this.checkBoxSu.Text = "Вс";
            this.checkBoxSu.UseVisualStyleBackColor = true;
            // 
            // checkBoxSa
            // 
            this.checkBoxSa.AutoSize = true;
            this.checkBoxSa.Location = new System.Drawing.Point(339, 40);
            this.checkBoxSa.Name = "checkBoxSa";
            this.checkBoxSa.Size = new System.Drawing.Size(39, 17);
            this.checkBoxSa.TabIndex = 18;
            this.checkBoxSa.Text = "Сб";
            this.checkBoxSa.UseVisualStyleBackColor = true;
            // 
            // checkBoxFr
            // 
            this.checkBoxFr.AutoSize = true;
            this.checkBoxFr.Location = new System.Drawing.Point(289, 40);
            this.checkBoxFr.Name = "checkBoxFr";
            this.checkBoxFr.Size = new System.Drawing.Size(39, 17);
            this.checkBoxFr.TabIndex = 17;
            this.checkBoxFr.Text = "Пт";
            this.checkBoxFr.UseVisualStyleBackColor = true;
            // 
            // checkBoxTh
            // 
            this.checkBoxTh.AutoSize = true;
            this.checkBoxTh.Location = new System.Drawing.Point(239, 40);
            this.checkBoxTh.Name = "checkBoxTh";
            this.checkBoxTh.Size = new System.Drawing.Size(39, 17);
            this.checkBoxTh.TabIndex = 16;
            this.checkBoxTh.Text = "Чт";
            this.checkBoxTh.UseVisualStyleBackColor = true;
            // 
            // checkBoxWe
            // 
            this.checkBoxWe.AutoSize = true;
            this.checkBoxWe.Location = new System.Drawing.Point(189, 40);
            this.checkBoxWe.Name = "checkBoxWe";
            this.checkBoxWe.Size = new System.Drawing.Size(39, 17);
            this.checkBoxWe.TabIndex = 15;
            this.checkBoxWe.Text = "Ср";
            this.checkBoxWe.UseVisualStyleBackColor = true;
            // 
            // checkBoxTu
            // 
            this.checkBoxTu.AutoSize = true;
            this.checkBoxTu.Location = new System.Drawing.Point(139, 40);
            this.checkBoxTu.Name = "checkBoxTu";
            this.checkBoxTu.Size = new System.Drawing.Size(38, 17);
            this.checkBoxTu.TabIndex = 14;
            this.checkBoxTu.Text = "Вт";
            this.checkBoxTu.UseVisualStyleBackColor = true;
            // 
            // checkBoxMo
            // 
            this.checkBoxMo.AutoSize = true;
            this.checkBoxMo.Location = new System.Drawing.Point(89, 40);
            this.checkBoxMo.Name = "checkBoxMo";
            this.checkBoxMo.Size = new System.Drawing.Size(40, 17);
            this.checkBoxMo.TabIndex = 13;
            this.checkBoxMo.Text = "Пн";
            this.checkBoxMo.UseVisualStyleBackColor = true;
            // 
            // checkBoxDes
            // 
            this.checkBoxDes.AutoSize = true;
            this.checkBoxDes.Location = new System.Drawing.Point(7, 9);
            this.checkBoxDes.Name = "checkBoxDes";
            this.checkBoxDes.Size = new System.Drawing.Size(76, 17);
            this.checkBoxDes.TabIndex = 12;
            this.checkBoxDes.Text = "Описание";
            this.checkBoxDes.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.view_regulation_roomDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(614, 307);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // view_regulation_roomDataGridView
            // 
            this.view_regulation_roomDataGridView.AllowUserToAddRows = false;
            this.view_regulation_roomDataGridView.AllowUserToDeleteRows = false;
            this.view_regulation_roomDataGridView.AutoGenerateColumns = false;
            this.view_regulation_roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_regulation_roomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.ColumnAdd});
            this.view_regulation_roomDataGridView.DataSource = this.view_regulation_roomBindingSource;
            this.view_regulation_roomDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_regulation_roomDataGridView.Location = new System.Drawing.Point(3, 3);
            this.view_regulation_roomDataGridView.Name = "view_regulation_roomDataGridView";
            this.view_regulation_roomDataGridView.ReadOnly = true;
            this.view_regulation_roomDataGridView.Size = new System.Drawing.Size(608, 221);
            this.view_regulation_roomDataGridView.TabIndex = 1;
            this.view_regulation_roomDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_regulation_roomDataGridView_CellContentClick);
            // 
            // view_regulation_roomBindingSource
            // 
            this.view_regulation_roomBindingSource.DataMember = "View_regulation_room";
            this.view_regulation_roomBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // accessControlSystemDataSet
            // 
            this.accessControlSystemDataSet.DataSetName = "accessControlSystemDataSet";
            this.accessControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_regulation_roomTableAdapter
            // 
            this.view_regulation_roomTableAdapter.ClearBeforeFill = true;
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
            // view_regulation_roomBindingNavigator
            // 
            this.view_regulation_roomBindingNavigator.AddNewItem = null;
            this.view_regulation_roomBindingNavigator.BindingSource = this.view_regulation_roomBindingSource;
            this.view_regulation_roomBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.view_regulation_roomBindingNavigator.DeleteItem = null;
            this.view_regulation_roomBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButtonAdd,
            this.toolStripButtonDelete,
            this.toolStripButtonRefresh});
            this.view_regulation_roomBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.view_regulation_roomBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.view_regulation_roomBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.view_regulation_roomBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.view_regulation_roomBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.view_regulation_roomBindingNavigator.Name = "view_regulation_roomBindingNavigator";
            this.view_regulation_roomBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.view_regulation_roomBindingNavigator.Size = new System.Drawing.Size(614, 25);
            this.view_regulation_roomBindingNavigator.TabIndex = 1;
            this.view_regulation_roomBindingNavigator.Text = "bindingNavigator1";
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
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = global::AccessControlSystem.Properties.Resources.if_plus_24_1031722;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd.Text = "toolStripButton1";
            this.toolStripButtonAdd.ToolTipText = "Прикрепить новое правило для помещения";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = global::AccessControlSystem.Properties.Resources._186389_512;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelete.Text = "toolStripButton2";
            this.toolStripButtonDelete.ToolTipText = "Открепить выбранное правило от помещения";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = global::AccessControlSystem.Properties.Resources.if_refresh27_216529;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "toolStripButton1";
            this.toolStripButtonRefresh.ToolTipText = "Обновить данные";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // room_regulationBindingSource
            // 
            this.room_regulationBindingSource.DataMember = "Room_regulation";
            this.room_regulationBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // room_regulationTableAdapter
            // 
            this.room_regulationTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ID_regulation";
            this.dataGridViewTextBoxColumn7.HeaderText = "№ правила";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 88;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 25;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Access_time_from";
            this.dataGridViewTextBoxColumn4.HeaderText = "Время доступа с";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 107;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Access_time_to";
            this.dataGridViewTextBoxColumn6.HeaderText = "Время доступа до";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 102;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Days_of_week";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дни недели доступа";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 123;
            // 
            // ColumnAdd
            // 
            this.ColumnAdd.HeaderText = "Добавить";
            this.ColumnAdd.Name = "ColumnAdd";
            this.ColumnAdd.ReadOnly = true;
            this.ColumnAdd.Text = "Добавить";
            this.ColumnAdd.UseColumnTextForButtonValue = true;
            // 
            // regulation_keyBindingSource
            // 
            this.regulation_keyBindingSource.DataMember = "Regulation_key";
            this.regulation_keyBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // regulation_keyTableAdapter
            // 
            this.regulation_keyTableAdapter.ClearBeforeFill = true;
            // 
            // FormRegulationRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 332);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.view_regulation_roomBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(630, 370);
            this.Name = "FormRegulationRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр прикрепленных правил";
            this.Load += new System.EventHandler(this.FormRegulationRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_regulation_roomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_regulation_roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_regulation_roomBindingNavigator)).EndInit();
            this.view_regulation_roomBindingNavigator.ResumeLayout(false);
            this.view_regulation_roomBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room_regulationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regulation_keyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private System.Windows.Forms.BindingSource view_regulation_roomBindingSource;
        private accessControlSystemDataSetTableAdapters.View_regulation_roomTableAdapter view_regulation_roomTableAdapter;
        private accessControlSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator view_regulation_roomBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView view_regulation_roomDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDes;
        private System.Windows.Forms.CheckBox checkBoxSu;
        private System.Windows.Forms.CheckBox checkBoxSa;
        private System.Windows.Forms.CheckBox checkBoxFr;
        private System.Windows.Forms.CheckBox checkBoxTh;
        private System.Windows.Forms.CheckBox checkBoxWe;
        private System.Windows.Forms.CheckBox checkBoxTu;
        private System.Windows.Forms.CheckBox checkBoxMo;
        private System.Windows.Forms.CheckBox checkBoxDes;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.BindingSource room_regulationBindingSource;
        private accessControlSystemDataSetTableAdapters.Room_regulationTableAdapter room_regulationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnAdd;
        private System.Windows.Forms.BindingSource regulation_keyBindingSource;
        private accessControlSystemDataSetTableAdapters.Regulation_keyTableAdapter regulation_keyTableAdapter;

    }
}