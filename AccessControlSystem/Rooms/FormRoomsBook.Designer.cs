namespace AccessControlSystem
{
    partial class FormRoomsBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoomsBook));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.roomsDataGridView = new System.Windows.Forms.DataGridView();
            this.panelFindRoom = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxBlock = new System.Windows.Forms.TextBox();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.textBoxDes = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxType = new System.Windows.Forms.CheckBox();
            this.checkBoxBlock = new System.Windows.Forms.CheckBox();
            this.checkBoxFloor = new System.Windows.Forms.CheckBox();
            this.checkBoxDes = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.roomsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAddRoom = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditRoom = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteRoom = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRules = new System.Windows.Forms.ToolStripButton();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.roomsTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.RoomsTableAdapter();
            this.tableAdapterManager = new AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).BeginInit();
            this.panelFindRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingNavigator)).BeginInit();
            this.roomsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.roomsDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelFindRoom, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(631, 378);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // roomsDataGridView
            // 
            this.roomsDataGridView.AllowUserToAddRows = false;
            this.roomsDataGridView.AllowUserToDeleteRows = false;
            this.roomsDataGridView.AutoGenerateColumns = false;
            this.roomsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.roomsDataGridView.DataSource = this.roomsBindingSource;
            this.roomsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.roomsDataGridView.Name = "roomsDataGridView";
            this.roomsDataGridView.ReadOnly = true;
            this.roomsDataGridView.Size = new System.Drawing.Size(625, 292);
            this.roomsDataGridView.TabIndex = 1;
            // 
            // panelFindRoom
            // 
            this.panelFindRoom.Controls.Add(this.buttonRefresh);
            this.panelFindRoom.Controls.Add(this.buttonFind);
            this.panelFindRoom.Controls.Add(this.textBoxType);
            this.panelFindRoom.Controls.Add(this.textBoxBlock);
            this.panelFindRoom.Controls.Add(this.textBoxFloor);
            this.panelFindRoom.Controls.Add(this.textBoxDes);
            this.panelFindRoom.Controls.Add(this.textBoxName);
            this.panelFindRoom.Controls.Add(this.checkBoxType);
            this.panelFindRoom.Controls.Add(this.checkBoxBlock);
            this.panelFindRoom.Controls.Add(this.checkBoxFloor);
            this.panelFindRoom.Controls.Add(this.checkBoxDes);
            this.panelFindRoom.Controls.Add(this.checkBoxName);
            this.panelFindRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFindRoom.Location = new System.Drawing.Point(3, 301);
            this.panelFindRoom.Name = "panelFindRoom";
            this.panelFindRoom.Size = new System.Drawing.Size(625, 74);
            this.panelFindRoom.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(524, 37);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(92, 23);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "Сброс";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(524, 8);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(92, 23);
            this.buttonFind.TabIndex = 10;
            this.buttonFind.Text = "Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(358, 25);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(150, 20);
            this.textBoxType.TabIndex = 9;
            // 
            // textBoxBlock
            // 
            this.textBoxBlock.Location = new System.Drawing.Point(358, 1);
            this.textBoxBlock.Name = "textBoxBlock";
            this.textBoxBlock.Size = new System.Drawing.Size(150, 20);
            this.textBoxBlock.TabIndex = 7;
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Location = new System.Drawing.Point(95, 49);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(150, 20);
            this.textBoxFloor.TabIndex = 5;
            // 
            // textBoxDes
            // 
            this.textBoxDes.Location = new System.Drawing.Point(95, 25);
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.Size = new System.Drawing.Size(150, 20);
            this.textBoxDes.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(95, 1);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // checkBoxType
            // 
            this.checkBoxType.AutoSize = true;
            this.checkBoxType.Location = new System.Drawing.Point(272, 27);
            this.checkBoxType.Name = "checkBoxType";
            this.checkBoxType.Size = new System.Drawing.Size(45, 17);
            this.checkBoxType.TabIndex = 8;
            this.checkBoxType.Text = "Тип";
            this.checkBoxType.UseVisualStyleBackColor = true;
            // 
            // checkBoxBlock
            // 
            this.checkBoxBlock.AutoSize = true;
            this.checkBoxBlock.Location = new System.Drawing.Point(272, 3);
            this.checkBoxBlock.Name = "checkBoxBlock";
            this.checkBoxBlock.Size = new System.Drawing.Size(62, 17);
            this.checkBoxBlock.TabIndex = 6;
            this.checkBoxBlock.Text = "Корпус";
            this.checkBoxBlock.UseVisualStyleBackColor = true;
            // 
            // checkBoxFloor
            // 
            this.checkBoxFloor.AutoSize = true;
            this.checkBoxFloor.Location = new System.Drawing.Point(9, 51);
            this.checkBoxFloor.Name = "checkBoxFloor";
            this.checkBoxFloor.Size = new System.Drawing.Size(52, 17);
            this.checkBoxFloor.TabIndex = 4;
            this.checkBoxFloor.Text = "Этаж";
            this.checkBoxFloor.UseVisualStyleBackColor = true;
            // 
            // checkBoxDes
            // 
            this.checkBoxDes.AutoSize = true;
            this.checkBoxDes.Location = new System.Drawing.Point(9, 27);
            this.checkBoxDes.Name = "checkBoxDes";
            this.checkBoxDes.Size = new System.Drawing.Size(76, 17);
            this.checkBoxDes.TabIndex = 2;
            this.checkBoxDes.Text = "Описание";
            this.checkBoxDes.UseVisualStyleBackColor = true;
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(9, 3);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(76, 17);
            this.checkBoxName.TabIndex = 0;
            this.checkBoxName.Text = "Название";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // roomsBindingNavigator
            // 
            this.roomsBindingNavigator.AddNewItem = null;
            this.roomsBindingNavigator.BindingSource = this.roomsBindingSource;
            this.roomsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.roomsBindingNavigator.DeleteItem = null;
            this.roomsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButtonAddRoom,
            this.toolStripButtonEditRoom,
            this.toolStripButtonDeleteRoom,
            this.toolStripButtonRefresh,
            this.toolStripSeparator1,
            this.toolStripButtonRules});
            this.roomsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.roomsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.roomsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.roomsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.roomsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.roomsBindingNavigator.Name = "roomsBindingNavigator";
            this.roomsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.roomsBindingNavigator.Size = new System.Drawing.Size(631, 25);
            this.roomsBindingNavigator.TabIndex = 1;
            this.roomsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorMoveLastItem.Image = global::AccessControlSystem.Properties.Resources.if_skip_next_3265131;
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
            // toolStripButtonAddRoom
            // 
            this.toolStripButtonAddRoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddRoom.Image = global::AccessControlSystem.Properties.Resources.if_plus_24_1031722;
            this.toolStripButtonAddRoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddRoom.Name = "toolStripButtonAddRoom";
            this.toolStripButtonAddRoom.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAddRoom.Text = "toolStripButton1";
            this.toolStripButtonAddRoom.ToolTipText = "Добавить новый объект";
            this.toolStripButtonAddRoom.Click += new System.EventHandler(this.toolStripButtonAddRoom_Click);
            // 
            // toolStripButtonEditRoom
            // 
            this.toolStripButtonEditRoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditRoom.Image = global::AccessControlSystem.Properties.Resources.if_new_24_103173;
            this.toolStripButtonEditRoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditRoom.Name = "toolStripButtonEditRoom";
            this.toolStripButtonEditRoom.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditRoom.Text = "toolStripButton2";
            this.toolStripButtonEditRoom.ToolTipText = "Изменить выбранный объект";
            this.toolStripButtonEditRoom.Click += new System.EventHandler(this.toolStripButtonEditRoom_Click);
            // 
            // toolStripButtonDeleteRoom
            // 
            this.toolStripButtonDeleteRoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteRoom.Image = global::AccessControlSystem.Properties.Resources._186389_512;
            this.toolStripButtonDeleteRoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteRoom.Name = "toolStripButtonDeleteRoom";
            this.toolStripButtonDeleteRoom.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDeleteRoom.Text = "toolStripButton3";
            this.toolStripButtonDeleteRoom.ToolTipText = "Удалить выбранный объект";
            this.toolStripButtonDeleteRoom.Click += new System.EventHandler(this.toolStripButtonDeleteRoom_Click);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonRules
            // 
            this.toolStripButtonRules.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRules.Image = global::AccessControlSystem.Properties.Resources.if_rules_3018564;
            this.toolStripButtonRules.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRules.Name = "toolStripButtonRules";
            this.toolStripButtonRules.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRules.Text = "Просмотр списка правил для выбранного объекта";
            this.toolStripButtonRules.ToolTipText = "Открыть набор правил для выбранного объекта";
            this.toolStripButtonRules.Click += new System.EventHandler(this.toolStripButtonRules_Click);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // accessControlSystemDataSet
            // 
            this.accessControlSystemDataSet.DataSetName = "accessControlSystemDataSet";
            this.accessControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_room";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 82;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 82;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Floor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Этаж";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 58;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Block";
            this.dataGridViewTextBoxColumn5.HeaderText = "Корпус";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 68;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Type_room";
            this.dataGridViewTextBoxColumn6.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 51;
            // 
            // FormRoomsBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 403);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.roomsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRoomsBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник объектов предприятия";
            this.Load += new System.EventHandler(this.FormRoomsBook_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).EndInit();
            this.panelFindRoom.ResumeLayout(false);
            this.panelFindRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingNavigator)).EndInit();
            this.roomsBindingNavigator.ResumeLayout(false);
            this.roomsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelFindRoom;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private accessControlSystemDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private accessControlSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator roomsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView roomsDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddRoom;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditRoom;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteRoom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRules;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxBlock;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.TextBox textBoxDes;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxType;
        private System.Windows.Forms.CheckBox checkBoxBlock;
        private System.Windows.Forms.CheckBox checkBoxFloor;
        private System.Windows.Forms.CheckBox checkBoxDes;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}