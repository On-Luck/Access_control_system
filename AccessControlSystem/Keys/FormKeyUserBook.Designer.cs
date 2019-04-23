namespace AccessControlSystem
{
    partial class FormKeyUserBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKeyUserBook));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.view_key_userDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_key_userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.panelFind = new System.Windows.Forms.Panel();
            this.dateTimePickerActTo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerActFrom = new System.Windows.Forms.DateTimePicker();
            this.textBoxPat = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSname = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.view_key_userTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.View_key_userTableAdapter();
            this.tableAdapterManager = new AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager();
            this.view_key_userBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.checkBoxSname = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxPat = new System.Windows.Forms.CheckBox();
            this.checkBoxPerAct = new System.Windows.Forms.CheckBox();
            this.checkBoxKeyNum = new System.Windows.Forms.CheckBox();
            this.checkBoxKey = new System.Windows.Forms.CheckBox();
            this.textBoxKeyNum = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonReadKey = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.checkBoxPerIssue = new System.Windows.Forms.CheckBox();
            this.dateTimePickerIssueTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerIssueFrom = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_key_userDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_key_userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            this.panelFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_key_userBindingNavigator)).BeginInit();
            this.view_key_userBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.view_key_userDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelFind, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 357);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // view_key_userDataGridView
            // 
            this.view_key_userDataGridView.AllowUserToAddRows = false;
            this.view_key_userDataGridView.AllowUserToDeleteRows = false;
            this.view_key_userDataGridView.AutoGenerateColumns = false;
            this.view_key_userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_key_userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.view_key_userDataGridView.DataSource = this.view_key_userBindingSource;
            this.view_key_userDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_key_userDataGridView.Location = new System.Drawing.Point(3, 3);
            this.view_key_userDataGridView.Name = "view_key_userDataGridView";
            this.view_key_userDataGridView.Size = new System.Drawing.Size(818, 238);
            this.view_key_userDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_user";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn2.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 66;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Second_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 81;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 54;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Patronymic";
            this.dataGridViewTextBoxColumn5.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 79;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Date_of_issue";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата выдачи";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Date_of_start_action";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата начала действия";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 133;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Date_expiration";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата окончания действия";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Visit_purpose";
            this.dataGridViewTextBoxColumn9.HeaderText = "Цель визита";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 88;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ID_key";
            this.dataGridViewTextBoxColumn10.HeaderText = "№ ключа";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 71;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Key_value";
            this.dataGridViewTextBoxColumn11.HeaderText = "Ключ";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 58;
            // 
            // view_key_userBindingSource
            // 
            this.view_key_userBindingSource.DataMember = "View_key_user";
            this.view_key_userBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // accessControlSystemDataSet
            // 
            this.accessControlSystemDataSet.DataSetName = "accessControlSystemDataSet";
            this.accessControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelFind
            // 
            this.panelFind.Controls.Add(this.checkBoxPerIssue);
            this.panelFind.Controls.Add(this.dateTimePickerIssueTo);
            this.panelFind.Controls.Add(this.label1);
            this.panelFind.Controls.Add(this.dateTimePickerIssueFrom);
            this.panelFind.Controls.Add(this.buttonRefresh);
            this.panelFind.Controls.Add(this.buttonFind);
            this.panelFind.Controls.Add(this.buttonReadKey);
            this.panelFind.Controls.Add(this.textBoxKey);
            this.panelFind.Controls.Add(this.textBoxKeyNum);
            this.panelFind.Controls.Add(this.checkBoxKey);
            this.panelFind.Controls.Add(this.checkBoxKeyNum);
            this.panelFind.Controls.Add(this.checkBoxPerAct);
            this.panelFind.Controls.Add(this.checkBoxPat);
            this.panelFind.Controls.Add(this.checkBoxName);
            this.panelFind.Controls.Add(this.checkBoxSname);
            this.panelFind.Controls.Add(this.checkBoxStatus);
            this.panelFind.Controls.Add(this.dateTimePickerActTo);
            this.panelFind.Controls.Add(this.label6);
            this.panelFind.Controls.Add(this.dateTimePickerActFrom);
            this.panelFind.Controls.Add(this.textBoxPat);
            this.panelFind.Controls.Add(this.textBoxName);
            this.panelFind.Controls.Add(this.textBoxSname);
            this.panelFind.Controls.Add(this.textBoxStatus);
            this.panelFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFind.Location = new System.Drawing.Point(3, 247);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(818, 107);
            this.panelFind.TabIndex = 1;
            // 
            // dateTimePickerActTo
            // 
            this.dateTimePickerActTo.Location = new System.Drawing.Point(548, 3);
            this.dateTimePickerActTo.Name = "dateTimePickerActTo";
            this.dateTimePickerActTo.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerActTo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "по";
            // 
            // dateTimePickerActFrom
            // 
            this.dateTimePickerActFrom.Location = new System.Drawing.Point(395, 3);
            this.dateTimePickerActFrom.Name = "dateTimePickerActFrom";
            this.dateTimePickerActFrom.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerActFrom.TabIndex = 10;
            // 
            // textBoxPat
            // 
            this.textBoxPat.Location = new System.Drawing.Point(90, 81);
            this.textBoxPat.Name = "textBoxPat";
            this.textBoxPat.Size = new System.Drawing.Size(150, 20);
            this.textBoxPat.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(90, 56);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxSname
            // 
            this.textBoxSname.Location = new System.Drawing.Point(90, 30);
            this.textBoxSname.Name = "textBoxSname";
            this.textBoxSname.Size = new System.Drawing.Size(150, 20);
            this.textBoxSname.TabIndex = 4;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(90, 4);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(150, 20);
            this.textBoxStatus.TabIndex = 2;
            // 
            // view_key_userTableAdapter
            // 
            this.view_key_userTableAdapter.ClearBeforeFill = true;
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
            // view_key_userBindingNavigator
            // 
            this.view_key_userBindingNavigator.AddNewItem = null;
            this.view_key_userBindingNavigator.BindingSource = this.view_key_userBindingSource;
            this.view_key_userBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.view_key_userBindingNavigator.DeleteItem = null;
            this.view_key_userBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButtonRefresh});
            this.view_key_userBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.view_key_userBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.view_key_userBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.view_key_userBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.view_key_userBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.view_key_userBindingNavigator.Name = "view_key_userBindingNavigator";
            this.view_key_userBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.view_key_userBindingNavigator.Size = new System.Drawing.Size(824, 25);
            this.view_key_userBindingNavigator.TabIndex = 1;
            this.view_key_userBindingNavigator.Text = "bindingNavigator1";
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
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(9, 6);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(60, 17);
            this.checkBoxStatus.TabIndex = 1;
            this.checkBoxStatus.Text = "Статус";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // checkBoxSname
            // 
            this.checkBoxSname.AutoSize = true;
            this.checkBoxSname.Location = new System.Drawing.Point(9, 32);
            this.checkBoxSname.Name = "checkBoxSname";
            this.checkBoxSname.Size = new System.Drawing.Size(75, 17);
            this.checkBoxSname.TabIndex = 3;
            this.checkBoxSname.Text = "Фамилия";
            this.checkBoxSname.UseVisualStyleBackColor = true;
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(9, 58);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(48, 17);
            this.checkBoxName.TabIndex = 5;
            this.checkBoxName.Text = "Имя";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // checkBoxPat
            // 
            this.checkBoxPat.AutoSize = true;
            this.checkBoxPat.Location = new System.Drawing.Point(9, 84);
            this.checkBoxPat.Name = "checkBoxPat";
            this.checkBoxPat.Size = new System.Drawing.Size(73, 17);
            this.checkBoxPat.TabIndex = 7;
            this.checkBoxPat.Text = "Отчество";
            this.checkBoxPat.UseVisualStyleBackColor = true;
            // 
            // checkBoxPerAct
            // 
            this.checkBoxPerAct.AutoSize = true;
            this.checkBoxPerAct.Location = new System.Drawing.Point(266, 6);
            this.checkBoxPerAct.Name = "checkBoxPerAct";
            this.checkBoxPerAct.Size = new System.Drawing.Size(123, 17);
            this.checkBoxPerAct.TabIndex = 9;
            this.checkBoxPerAct.Text = "Период действия с";
            this.checkBoxPerAct.UseVisualStyleBackColor = true;
            // 
            // checkBoxKeyNum
            // 
            this.checkBoxKeyNum.AutoSize = true;
            this.checkBoxKeyNum.Location = new System.Drawing.Point(266, 58);
            this.checkBoxKeyNum.Name = "checkBoxKeyNum";
            this.checkBoxKeyNum.Size = new System.Drawing.Size(94, 17);
            this.checkBoxKeyNum.TabIndex = 15;
            this.checkBoxKeyNum.Text = "Номер ключа";
            this.checkBoxKeyNum.UseVisualStyleBackColor = true;
            // 
            // checkBoxKey
            // 
            this.checkBoxKey.AutoSize = true;
            this.checkBoxKey.Location = new System.Drawing.Point(266, 84);
            this.checkBoxKey.Name = "checkBoxKey";
            this.checkBoxKey.Size = new System.Drawing.Size(52, 17);
            this.checkBoxKey.TabIndex = 17;
            this.checkBoxKey.Text = "Ключ";
            this.checkBoxKey.UseVisualStyleBackColor = true;
            // 
            // textBoxKeyNum
            // 
            this.textBoxKeyNum.Location = new System.Drawing.Point(395, 56);
            this.textBoxKeyNum.Name = "textBoxKeyNum";
            this.textBoxKeyNum.Size = new System.Drawing.Size(150, 20);
            this.textBoxKeyNum.TabIndex = 16;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(395, 80);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(150, 20);
            this.textBoxKey.TabIndex = 18;
            // 
            // buttonReadKey
            // 
            this.buttonReadKey.Location = new System.Drawing.Point(548, 78);
            this.buttonReadKey.Name = "buttonReadKey";
            this.buttonReadKey.Size = new System.Drawing.Size(122, 23);
            this.buttonReadKey.TabIndex = 19;
            this.buttonReadKey.Text = "Считать ключ";
            this.buttonReadKey.UseVisualStyleBackColor = true;
            this.buttonReadKey.Click += new System.EventHandler(this.buttonReadKey_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(689, 28);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(122, 23);
            this.buttonFind.TabIndex = 20;
            this.buttonFind.Text = "Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(689, 54);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(122, 23);
            this.buttonRefresh.TabIndex = 21;
            this.buttonRefresh.Text = "Сброс";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = global::AccessControlSystem.Properties.Resources.if_refresh27_216529;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "toolStripButton4";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // checkBoxPerIssue
            // 
            this.checkBoxPerIssue.AutoSize = true;
            this.checkBoxPerIssue.Location = new System.Drawing.Point(266, 32);
            this.checkBoxPerIssue.Name = "checkBoxPerIssue";
            this.checkBoxPerIssue.Size = new System.Drawing.Size(123, 17);
            this.checkBoxPerIssue.TabIndex = 12;
            this.checkBoxPerIssue.Text = "Период действия с";
            this.checkBoxPerIssue.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerIssueTo
            // 
            this.dateTimePickerIssueTo.Location = new System.Drawing.Point(548, 29);
            this.dateTimePickerIssueTo.Name = "dateTimePickerIssueTo";
            this.dateTimePickerIssueTo.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerIssueTo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "по";
            // 
            // dateTimePickerIssueFrom
            // 
            this.dateTimePickerIssueFrom.Location = new System.Drawing.Point(395, 29);
            this.dateTimePickerIssueFrom.Name = "dateTimePickerIssueFrom";
            this.dateTimePickerIssueFrom.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerIssueFrom.TabIndex = 13;
            // 
            // FormKeyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 382);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.view_key_userBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(840, 420);
            this.Name = "FormKeyUser";
            this.Text = "Пользователи ключей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKeyUser_FormClosing);
            this.Load += new System.EventHandler(this.FormKeyUser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_key_userDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_key_userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_key_userBindingNavigator)).EndInit();
            this.view_key_userBindingNavigator.ResumeLayout(false);
            this.view_key_userBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private System.Windows.Forms.BindingSource view_key_userBindingSource;
        private accessControlSystemDataSetTableAdapters.View_key_userTableAdapter view_key_userTableAdapter;
        private accessControlSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator view_key_userBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView view_key_userDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.DateTimePicker dateTimePickerActTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerActFrom;
        private System.Windows.Forms.TextBox textBoxPat;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSname;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonReadKey;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxKeyNum;
        private System.Windows.Forms.CheckBox checkBoxKey;
        private System.Windows.Forms.CheckBox checkBoxKeyNum;
        private System.Windows.Forms.CheckBox checkBoxPerAct;
        private System.Windows.Forms.CheckBox checkBoxPat;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxSname;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.CheckBox checkBoxPerIssue;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssueTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssueFrom;
    }
}