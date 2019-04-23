namespace AccessControlSystem
{
    partial class FormAnchoredKeys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnchoredKeys));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.view_key_user_keyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_key_user_keyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.panelFind = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonReadKey = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxKeyNum = new System.Windows.Forms.TextBox();
            this.checkBoxKey = new System.Windows.Forms.CheckBox();
            this.checkBoxKeyNum = new System.Windows.Forms.CheckBox();
            this.checkBoxPerIssue = new System.Windows.Forms.CheckBox();
            this.dateTimePickerIssueTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerIssueFrom = new System.Windows.Forms.DateTimePicker();
            this.checkBoxPerAct = new System.Windows.Forms.CheckBox();
            this.dateTimePickerActTo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerActFrom = new System.Windows.Forms.DateTimePicker();
            this.view_key_user_keyTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.View_key_user_keyTableAdapter();
            this.tableAdapterManager = new AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager();
            this.view_key_user_keyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRegulation = new System.Windows.Forms.ToolStripButton();
            this.key_userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.key_userTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.Key_userTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_key_user_keyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_key_user_keyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            this.panelFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_key_user_keyBindingNavigator)).BeginInit();
            this.view_key_user_keyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.key_userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.view_key_user_keyDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelFind, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 377);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // view_key_user_keyDataGridView
            // 
            this.view_key_user_keyDataGridView.AllowUserToAddRows = false;
            this.view_key_user_keyDataGridView.AllowUserToDeleteRows = false;
            this.view_key_user_keyDataGridView.AutoGenerateColumns = false;
            this.view_key_user_keyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_key_user_keyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5});
            this.view_key_user_keyDataGridView.DataSource = this.view_key_user_keyBindingSource;
            this.view_key_user_keyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_key_user_keyDataGridView.Location = new System.Drawing.Point(3, 3);
            this.view_key_user_keyDataGridView.Name = "view_key_user_keyDataGridView";
            this.view_key_user_keyDataGridView.ReadOnly = true;
            this.view_key_user_keyDataGridView.Size = new System.Drawing.Size(833, 291);
            this.view_key_user_keyDataGridView.TabIndex = 0;
            this.view_key_user_keyDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_key_user_keyDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_key";
            this.dataGridViewTextBoxColumn2.HeaderText = "№ ключа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 71;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Key_value";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ключ";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 58;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Type_name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 51;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn10.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 66;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date_of_issue";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата выдачи";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date_of_start_action";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата начала действия";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 133;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Date_expiration";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата окончания действия";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Visit_purpose";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цель визита";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 88;
            // 
            // view_key_user_keyBindingSource
            // 
            this.view_key_user_keyBindingSource.DataMember = "View_key_user_key";
            this.view_key_user_keyBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // accessControlSystemDataSet
            // 
            this.accessControlSystemDataSet.DataSetName = "accessControlSystemDataSet";
            this.accessControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelFind
            // 
            this.panelFind.AutoScroll = true;
            this.panelFind.Controls.Add(this.buttonRefresh);
            this.panelFind.Controls.Add(this.buttonReadKey);
            this.panelFind.Controls.Add(this.buttonFind);
            this.panelFind.Controls.Add(this.textBoxKey);
            this.panelFind.Controls.Add(this.textBoxKeyNum);
            this.panelFind.Controls.Add(this.checkBoxKey);
            this.panelFind.Controls.Add(this.checkBoxKeyNum);
            this.panelFind.Controls.Add(this.checkBoxPerIssue);
            this.panelFind.Controls.Add(this.dateTimePickerIssueTo);
            this.panelFind.Controls.Add(this.label1);
            this.panelFind.Controls.Add(this.dateTimePickerIssueFrom);
            this.panelFind.Controls.Add(this.checkBoxPerAct);
            this.panelFind.Controls.Add(this.dateTimePickerActTo);
            this.panelFind.Controls.Add(this.label6);
            this.panelFind.Controls.Add(this.dateTimePickerActFrom);
            this.panelFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFind.Location = new System.Drawing.Point(3, 300);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(833, 74);
            this.panelFind.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(701, 38);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(122, 23);
            this.buttonRefresh.TabIndex = 23;
            this.buttonRefresh.Text = "Сброс";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonReadKey
            // 
            this.buttonReadKey.Location = new System.Drawing.Point(532, 50);
            this.buttonReadKey.Name = "buttonReadKey";
            this.buttonReadKey.Size = new System.Drawing.Size(151, 23);
            this.buttonReadKey.TabIndex = 33;
            this.buttonReadKey.Text = "Считать ключ";
            this.buttonReadKey.UseVisualStyleBackColor = true;
            this.buttonReadKey.Click += new System.EventHandler(this.buttonReadKey_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(701, 12);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(122, 23);
            this.buttonFind.TabIndex = 22;
            this.buttonFind.Text = "Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(532, 26);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(150, 20);
            this.textBoxKey.TabIndex = 32;
            // 
            // textBoxKeyNum
            // 
            this.textBoxKeyNum.Location = new System.Drawing.Point(532, 1);
            this.textBoxKeyNum.Name = "textBoxKeyNum";
            this.textBoxKeyNum.Size = new System.Drawing.Size(150, 20);
            this.textBoxKeyNum.TabIndex = 30;
            // 
            // checkBoxKey
            // 
            this.checkBoxKey.AutoSize = true;
            this.checkBoxKey.Location = new System.Drawing.Point(432, 29);
            this.checkBoxKey.Name = "checkBoxKey";
            this.checkBoxKey.Size = new System.Drawing.Size(52, 17);
            this.checkBoxKey.TabIndex = 31;
            this.checkBoxKey.Text = "Ключ";
            this.checkBoxKey.UseVisualStyleBackColor = true;
            // 
            // checkBoxKeyNum
            // 
            this.checkBoxKeyNum.AutoSize = true;
            this.checkBoxKeyNum.Location = new System.Drawing.Point(432, 3);
            this.checkBoxKeyNum.Name = "checkBoxKeyNum";
            this.checkBoxKeyNum.Size = new System.Drawing.Size(94, 17);
            this.checkBoxKeyNum.TabIndex = 29;
            this.checkBoxKeyNum.Text = "Номер ключа";
            this.checkBoxKeyNum.UseVisualStyleBackColor = true;
            // 
            // checkBoxPerIssue
            // 
            this.checkBoxPerIssue.AutoSize = true;
            this.checkBoxPerIssue.Location = new System.Drawing.Point(9, 29);
            this.checkBoxPerIssue.Name = "checkBoxPerIssue";
            this.checkBoxPerIssue.Size = new System.Drawing.Size(123, 17);
            this.checkBoxPerIssue.TabIndex = 25;
            this.checkBoxPerIssue.Text = "Период действия с";
            this.checkBoxPerIssue.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerIssueTo
            // 
            this.dateTimePickerIssueTo.Location = new System.Drawing.Point(291, 26);
            this.dateTimePickerIssueTo.Name = "dateTimePickerIssueTo";
            this.dateTimePickerIssueTo.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerIssueTo.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "по";
            // 
            // dateTimePickerIssueFrom
            // 
            this.dateTimePickerIssueFrom.Location = new System.Drawing.Point(138, 26);
            this.dateTimePickerIssueFrom.Name = "dateTimePickerIssueFrom";
            this.dateTimePickerIssueFrom.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerIssueFrom.TabIndex = 26;
            // 
            // checkBoxPerAct
            // 
            this.checkBoxPerAct.AutoSize = true;
            this.checkBoxPerAct.Location = new System.Drawing.Point(9, 3);
            this.checkBoxPerAct.Name = "checkBoxPerAct";
            this.checkBoxPerAct.Size = new System.Drawing.Size(123, 17);
            this.checkBoxPerAct.TabIndex = 21;
            this.checkBoxPerAct.Text = "Период действия с";
            this.checkBoxPerAct.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerActTo
            // 
            this.dateTimePickerActTo.Location = new System.Drawing.Point(291, 0);
            this.dateTimePickerActTo.Name = "dateTimePickerActTo";
            this.dateTimePickerActTo.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerActTo.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "по";
            // 
            // dateTimePickerActFrom
            // 
            this.dateTimePickerActFrom.Location = new System.Drawing.Point(138, 0);
            this.dateTimePickerActFrom.Name = "dateTimePickerActFrom";
            this.dateTimePickerActFrom.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerActFrom.TabIndex = 23;
            // 
            // view_key_user_keyTableAdapter
            // 
            this.view_key_user_keyTableAdapter.ClearBeforeFill = true;
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
            // view_key_user_keyBindingNavigator
            // 
            this.view_key_user_keyBindingNavigator.AddNewItem = null;
            this.view_key_user_keyBindingNavigator.BindingSource = this.view_key_user_keyBindingSource;
            this.view_key_user_keyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.view_key_user_keyBindingNavigator.DeleteItem = null;
            this.view_key_user_keyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButtonEdit,
            this.toolStripButtonDelete,
            this.toolStripButtonRefresh,
            this.toolStripSeparator1,
            this.toolStripButtonRegulation});
            this.view_key_user_keyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.view_key_user_keyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.view_key_user_keyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.view_key_user_keyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.view_key_user_keyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.view_key_user_keyBindingNavigator.Name = "view_key_user_keyBindingNavigator";
            this.view_key_user_keyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.view_key_user_keyBindingNavigator.Size = new System.Drawing.Size(839, 25);
            this.view_key_user_keyBindingNavigator.TabIndex = 1;
            this.view_key_user_keyBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
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
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
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
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd.Text = "toolStripButton1";
            this.toolStripButtonAdd.ToolTipText = "Добавить запись";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEdit.Text = "toolStripButton2";
            this.toolStripButtonEdit.ToolTipText = "Изменить запись";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelete.Text = "toolStripButton3";
            this.toolStripButtonDelete.ToolTipText = "Удалить запись";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "toolStripButton4";
            this.toolStripButtonRefresh.ToolTipText = "Обновить набор данных";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonRegulation
            // 
            this.toolStripButtonRegulation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRegulation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRegulation.Image")));
            this.toolStripButtonRegulation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRegulation.Name = "toolStripButtonRegulation";
            this.toolStripButtonRegulation.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRegulation.Text = "toolStripButton5";
            this.toolStripButtonRegulation.ToolTipText = "Список правил";
            this.toolStripButtonRegulation.Click += new System.EventHandler(this.toolStripButtonRegulation_Click);
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
            // FormAnchoredKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 402);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.view_key_user_keyBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(855, 440);
            this.Name = "FormAnchoredKeys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прикрепленные ключи";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAnchoredKeys_FormClosing);
            this.Load += new System.EventHandler(this.FormAnchoredKeys_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_key_user_keyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_key_user_keyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_key_user_keyBindingNavigator)).EndInit();
            this.view_key_user_keyBindingNavigator.ResumeLayout(false);
            this.view_key_user_keyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.key_userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private System.Windows.Forms.BindingSource view_key_user_keyBindingSource;
        private accessControlSystemDataSetTableAdapters.View_key_user_keyTableAdapter view_key_user_keyTableAdapter;
        private accessControlSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator view_key_user_keyBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView view_key_user_keyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRegulation;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.CheckBox checkBoxPerIssue;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssueTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssueFrom;
        private System.Windows.Forms.CheckBox checkBoxPerAct;
        private System.Windows.Forms.DateTimePicker dateTimePickerActTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerActFrom;
        private System.Windows.Forms.Button buttonReadKey;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxKeyNum;
        private System.Windows.Forms.CheckBox checkBoxKey;
        private System.Windows.Forms.CheckBox checkBoxKeyNum;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.BindingSource key_userBindingSource;
        private accessControlSystemDataSetTableAdapters.Key_userTableAdapter key_userTableAdapter;
    }
}