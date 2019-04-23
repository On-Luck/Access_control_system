namespace AccessControlSystem
{
    partial class FormJournal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJournal));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.view_journal_key_userBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.view_journal_key_userDataGridView = new System.Windows.Forms.DataGridView();
            this.panelfind = new System.Windows.Forms.Panel();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.textBoxPat = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSname = new System.Windows.Forms.TextBox();
            this.checkBoxPat = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxSname = new System.Windows.Forms.CheckBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.checkBoxRoom = new System.Windows.Forms.CheckBox();
            this.checkBoxAction = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxRoom = new System.Windows.Forms.TextBox();
            this.textBoxAction = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_journal_key_userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.view_journal_key_userTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.View_journal_key_userTableAdapter();
            this.tableAdapterManager = new AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_journal_key_userBindingNavigator)).BeginInit();
            this.view_journal_key_userBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_journal_key_userDataGridView)).BeginInit();
            this.panelfind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_journal_key_userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.view_journal_key_userDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelfind, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(739, 342);
            this.tableLayoutPanel1.TabIndex = 0;
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
            // view_journal_key_userBindingNavigator
            // 
            this.view_journal_key_userBindingNavigator.AddNewItem = null;
            this.view_journal_key_userBindingNavigator.BindingSource = this.view_journal_key_userBindingSource;
            this.view_journal_key_userBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.view_journal_key_userBindingNavigator.DeleteItem = null;
            this.view_journal_key_userBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.view_journal_key_userBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.view_journal_key_userBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.view_journal_key_userBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.view_journal_key_userBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.view_journal_key_userBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.view_journal_key_userBindingNavigator.Name = "view_journal_key_userBindingNavigator";
            this.view_journal_key_userBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.view_journal_key_userBindingNavigator.Size = new System.Drawing.Size(739, 25);
            this.view_journal_key_userBindingNavigator.TabIndex = 1;
            this.view_journal_key_userBindingNavigator.Text = "bindingNavigator1";
            // 
            // view_journal_key_userDataGridView
            // 
            this.view_journal_key_userDataGridView.AllowUserToAddRows = false;
            this.view_journal_key_userDataGridView.AllowUserToDeleteRows = false;
            this.view_journal_key_userDataGridView.AutoGenerateColumns = false;
            this.view_journal_key_userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_journal_key_userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn9});
            this.view_journal_key_userDataGridView.DataSource = this.view_journal_key_userBindingSource;
            this.view_journal_key_userDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_journal_key_userDataGridView.Location = new System.Drawing.Point(3, 3);
            this.view_journal_key_userDataGridView.Name = "view_journal_key_userDataGridView";
            this.view_journal_key_userDataGridView.ReadOnly = true;
            this.view_journal_key_userDataGridView.Size = new System.Drawing.Size(733, 236);
            this.view_journal_key_userDataGridView.TabIndex = 0;
            // 
            // panelfind
            // 
            this.panelfind.Controls.Add(this.buttonRefresh);
            this.panelfind.Controls.Add(this.buttonFind);
            this.panelfind.Controls.Add(this.textBoxAction);
            this.panelfind.Controls.Add(this.textBoxRoom);
            this.panelfind.Controls.Add(this.dateTimePickerDate);
            this.panelfind.Controls.Add(this.checkBoxAction);
            this.panelfind.Controls.Add(this.checkBoxRoom);
            this.panelfind.Controls.Add(this.checkBoxDate);
            this.panelfind.Controls.Add(this.textBoxStatus);
            this.panelfind.Controls.Add(this.textBoxPat);
            this.panelfind.Controls.Add(this.textBoxName);
            this.panelfind.Controls.Add(this.textBoxSname);
            this.panelfind.Controls.Add(this.checkBoxPat);
            this.panelfind.Controls.Add(this.checkBoxName);
            this.panelfind.Controls.Add(this.checkBoxSname);
            this.panelfind.Controls.Add(this.checkBoxStatus);
            this.panelfind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelfind.Location = new System.Drawing.Point(3, 245);
            this.panelfind.Name = "panelfind";
            this.panelfind.Size = new System.Drawing.Size(733, 94);
            this.panelfind.TabIndex = 1;
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(9, 3);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(60, 17);
            this.checkBoxStatus.TabIndex = 0;
            this.checkBoxStatus.Text = "Статус";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // textBoxPat
            // 
            this.textBoxPat.Location = new System.Drawing.Point(90, 70);
            this.textBoxPat.Name = "textBoxPat";
            this.textBoxPat.Size = new System.Drawing.Size(150, 20);
            this.textBoxPat.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(90, 47);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxSname
            // 
            this.textBoxSname.Location = new System.Drawing.Point(90, 24);
            this.textBoxSname.Name = "textBoxSname";
            this.textBoxSname.Size = new System.Drawing.Size(150, 20);
            this.textBoxSname.TabIndex = 7;
            // 
            // checkBoxPat
            // 
            this.checkBoxPat.AutoSize = true;
            this.checkBoxPat.Location = new System.Drawing.Point(9, 72);
            this.checkBoxPat.Name = "checkBoxPat";
            this.checkBoxPat.Size = new System.Drawing.Size(73, 17);
            this.checkBoxPat.TabIndex = 10;
            this.checkBoxPat.Text = "Отчество";
            this.checkBoxPat.UseVisualStyleBackColor = true;
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(9, 49);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(48, 17);
            this.checkBoxName.TabIndex = 8;
            this.checkBoxName.Text = "Имя";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // checkBoxSname
            // 
            this.checkBoxSname.AutoSize = true;
            this.checkBoxSname.Location = new System.Drawing.Point(9, 26);
            this.checkBoxSname.Name = "checkBoxSname";
            this.checkBoxSname.Size = new System.Drawing.Size(75, 17);
            this.checkBoxSname.TabIndex = 6;
            this.checkBoxSname.Text = "Фамилия";
            this.checkBoxSname.UseVisualStyleBackColor = true;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(90, 3);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(150, 20);
            this.textBoxStatus.TabIndex = 12;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(272, 3);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(52, 17);
            this.checkBoxDate.TabIndex = 13;
            this.checkBoxDate.Text = "Дата";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // checkBoxRoom
            // 
            this.checkBoxRoom.AutoSize = true;
            this.checkBoxRoom.Location = new System.Drawing.Point(272, 26);
            this.checkBoxRoom.Name = "checkBoxRoom";
            this.checkBoxRoom.Size = new System.Drawing.Size(64, 17);
            this.checkBoxRoom.TabIndex = 14;
            this.checkBoxRoom.Text = "Объект";
            this.checkBoxRoom.UseVisualStyleBackColor = true;
            // 
            // checkBoxAction
            // 
            this.checkBoxAction.AutoSize = true;
            this.checkBoxAction.Location = new System.Drawing.Point(272, 49);
            this.checkBoxAction.Name = "checkBoxAction";
            this.checkBoxAction.Size = new System.Drawing.Size(76, 17);
            this.checkBoxAction.TabIndex = 15;
            this.checkBoxAction.Text = "Действие";
            this.checkBoxAction.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(365, 3);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerDate.TabIndex = 16;
            // 
            // textBoxRoom
            // 
            this.textBoxRoom.Location = new System.Drawing.Point(365, 24);
            this.textBoxRoom.Name = "textBoxRoom";
            this.textBoxRoom.Size = new System.Drawing.Size(150, 20);
            this.textBoxRoom.TabIndex = 17;
            // 
            // textBoxAction
            // 
            this.textBoxAction.Location = new System.Drawing.Point(365, 46);
            this.textBoxAction.Name = "textBoxAction";
            this.textBoxAction.Size = new System.Drawing.Size(150, 20);
            this.textBoxAction.TabIndex = 18;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(613, 49);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(92, 23);
            this.buttonRefresh.TabIndex = 21;
            this.buttonRefresh.Text = "Сброс";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(613, 20);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(92, 23);
            this.buttonFind.TabIndex = 20;
            this.buttonFind.Text = "Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn4.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 66;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Second_name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 81;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 54;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Patronymic";
            this.dataGridViewTextBoxColumn7.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 79;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DataTime";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата и время";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 102;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Room_name";
            this.dataGridViewTextBoxColumn11.HeaderText = "Объект";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 70;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Action";
            this.dataGridViewTextBoxColumn9.HeaderText = "Действие";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 82;
            // 
            // view_journal_key_userBindingSource
            // 
            this.view_journal_key_userBindingSource.DataMember = "View_journal_key_user";
            this.view_journal_key_userBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // accessControlSystemDataSet
            // 
            this.accessControlSystemDataSet.DataSetName = "accessControlSystemDataSet";
            this.accessControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_journal_key_userTableAdapter
            // 
            this.view_journal_key_userTableAdapter.ClearBeforeFill = true;
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
            // FormJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 367);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.view_journal_key_userBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(755, 405);
            this.Name = "FormJournal";
            this.Text = "Журнал доступа";
            this.Load += new System.EventHandler(this.FormJournal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_journal_key_userBindingNavigator)).EndInit();
            this.view_journal_key_userBindingNavigator.ResumeLayout(false);
            this.view_journal_key_userBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_journal_key_userDataGridView)).EndInit();
            this.panelfind.ResumeLayout(false);
            this.panelfind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_journal_key_userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private System.Windows.Forms.BindingSource view_journal_key_userBindingSource;
        private accessControlSystemDataSetTableAdapters.View_journal_key_userTableAdapter view_journal_key_userTableAdapter;
        private accessControlSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView view_journal_key_userDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Panel panelfind;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator view_journal_key_userBindingNavigator;
        private System.Windows.Forms.TextBox textBoxAction;
        private System.Windows.Forms.TextBox textBoxRoom;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.CheckBox checkBoxAction;
        private System.Windows.Forms.CheckBox checkBoxRoom;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxPat;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSname;
        private System.Windows.Forms.CheckBox checkBoxPat;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxSname;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonFind;
    }
}