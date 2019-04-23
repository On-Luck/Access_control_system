namespace AccessControlSystem
{
    partial class FormRegulationBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegulationBook));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.regulationsDataGridView = new System.Windows.Forms.DataGridView();
            this.regulationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.panelFind = new System.Windows.Forms.Panel();
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
            this.regulationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.regulationsTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.RegulationsTableAdapter();
            this.tableAdapterManager = new AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.room_regulationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.room_regulationTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.Room_regulationTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regulationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regulationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            this.panelFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regulationsBindingNavigator)).BeginInit();
            this.regulationsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room_regulationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.regulationsDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelFind, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 287);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // regulationsDataGridView
            // 
            this.regulationsDataGridView.AllowUserToAddRows = false;
            this.regulationsDataGridView.AllowUserToDeleteRows = false;
            this.regulationsDataGridView.AutoGenerateColumns = false;
            this.regulationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regulationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.ColumnAdd});
            this.regulationsDataGridView.DataSource = this.regulationsBindingSource;
            this.regulationsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regulationsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.regulationsDataGridView.Name = "regulationsDataGridView";
            this.regulationsDataGridView.ReadOnly = true;
            this.regulationsDataGridView.Size = new System.Drawing.Size(601, 201);
            this.regulationsDataGridView.TabIndex = 1;
            this.regulationsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.regulationsDataGridView_CellContentClick);
            // 
            // regulationsBindingSource
            // 
            this.regulationsBindingSource.DataMember = "Regulations";
            this.regulationsBindingSource.DataSource = this.accessControlSystemDataSet;
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
            this.panelFind.Controls.Add(this.buttonFind);
            this.panelFind.Controls.Add(this.label1);
            this.panelFind.Controls.Add(this.textBoxDes);
            this.panelFind.Controls.Add(this.checkBoxSu);
            this.panelFind.Controls.Add(this.checkBoxSa);
            this.panelFind.Controls.Add(this.checkBoxFr);
            this.panelFind.Controls.Add(this.checkBoxTh);
            this.panelFind.Controls.Add(this.checkBoxWe);
            this.panelFind.Controls.Add(this.checkBoxTu);
            this.panelFind.Controls.Add(this.checkBoxMo);
            this.panelFind.Controls.Add(this.checkBoxDes);
            this.panelFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFind.Location = new System.Drawing.Point(3, 210);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(601, 74);
            this.panelFind.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(454, 39);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "Сброс";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(454, 10);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 10;
            this.buttonFind.Text = "Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Дни недели:";
            // 
            // textBoxDes
            // 
            this.textBoxDes.Location = new System.Drawing.Point(85, 1);
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.Size = new System.Drawing.Size(150, 20);
            this.textBoxDes.TabIndex = 8;
            // 
            // checkBoxSu
            // 
            this.checkBoxSu.AutoSize = true;
            this.checkBoxSu.Location = new System.Drawing.Point(385, 34);
            this.checkBoxSu.Name = "checkBoxSu";
            this.checkBoxSu.Size = new System.Drawing.Size(39, 17);
            this.checkBoxSu.TabIndex = 7;
            this.checkBoxSu.Text = "Вс";
            this.checkBoxSu.UseVisualStyleBackColor = true;
            // 
            // checkBoxSa
            // 
            this.checkBoxSa.AutoSize = true;
            this.checkBoxSa.Location = new System.Drawing.Point(335, 34);
            this.checkBoxSa.Name = "checkBoxSa";
            this.checkBoxSa.Size = new System.Drawing.Size(39, 17);
            this.checkBoxSa.TabIndex = 6;
            this.checkBoxSa.Text = "Сб";
            this.checkBoxSa.UseVisualStyleBackColor = true;
            // 
            // checkBoxFr
            // 
            this.checkBoxFr.AutoSize = true;
            this.checkBoxFr.Location = new System.Drawing.Point(285, 34);
            this.checkBoxFr.Name = "checkBoxFr";
            this.checkBoxFr.Size = new System.Drawing.Size(39, 17);
            this.checkBoxFr.TabIndex = 5;
            this.checkBoxFr.Text = "Пт";
            this.checkBoxFr.UseVisualStyleBackColor = true;
            // 
            // checkBoxTh
            // 
            this.checkBoxTh.AutoSize = true;
            this.checkBoxTh.Location = new System.Drawing.Point(235, 34);
            this.checkBoxTh.Name = "checkBoxTh";
            this.checkBoxTh.Size = new System.Drawing.Size(39, 17);
            this.checkBoxTh.TabIndex = 4;
            this.checkBoxTh.Text = "Чт";
            this.checkBoxTh.UseVisualStyleBackColor = true;
            // 
            // checkBoxWe
            // 
            this.checkBoxWe.AutoSize = true;
            this.checkBoxWe.Location = new System.Drawing.Point(185, 34);
            this.checkBoxWe.Name = "checkBoxWe";
            this.checkBoxWe.Size = new System.Drawing.Size(39, 17);
            this.checkBoxWe.TabIndex = 3;
            this.checkBoxWe.Text = "Ср";
            this.checkBoxWe.UseVisualStyleBackColor = true;
            // 
            // checkBoxTu
            // 
            this.checkBoxTu.AutoSize = true;
            this.checkBoxTu.Location = new System.Drawing.Point(135, 34);
            this.checkBoxTu.Name = "checkBoxTu";
            this.checkBoxTu.Size = new System.Drawing.Size(38, 17);
            this.checkBoxTu.TabIndex = 2;
            this.checkBoxTu.Text = "Вт";
            this.checkBoxTu.UseVisualStyleBackColor = true;
            // 
            // checkBoxMo
            // 
            this.checkBoxMo.AutoSize = true;
            this.checkBoxMo.Location = new System.Drawing.Point(85, 34);
            this.checkBoxMo.Name = "checkBoxMo";
            this.checkBoxMo.Size = new System.Drawing.Size(40, 17);
            this.checkBoxMo.TabIndex = 1;
            this.checkBoxMo.Text = "Пн";
            this.checkBoxMo.UseVisualStyleBackColor = true;
            // 
            // checkBoxDes
            // 
            this.checkBoxDes.AutoSize = true;
            this.checkBoxDes.Location = new System.Drawing.Point(3, 3);
            this.checkBoxDes.Name = "checkBoxDes";
            this.checkBoxDes.Size = new System.Drawing.Size(76, 17);
            this.checkBoxDes.TabIndex = 0;
            this.checkBoxDes.Text = "Описание";
            this.checkBoxDes.UseVisualStyleBackColor = true;
            // 
            // regulationsBindingNavigator
            // 
            this.regulationsBindingNavigator.AddNewItem = null;
            this.regulationsBindingNavigator.BindingSource = this.regulationsBindingSource;
            this.regulationsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.regulationsBindingNavigator.DeleteItem = null;
            this.regulationsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButtonRefresh});
            this.regulationsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.regulationsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.regulationsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.regulationsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.regulationsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.regulationsBindingNavigator.Name = "regulationsBindingNavigator";
            this.regulationsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.regulationsBindingNavigator.Size = new System.Drawing.Size(607, 25);
            this.regulationsBindingNavigator.TabIndex = 1;
            this.regulationsBindingNavigator.Text = "bindingNavigator1";
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
            this.toolStripButtonAdd.Text = "Добавить правило";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Image = global::AccessControlSystem.Properties.Resources.if_new_24_103173;
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEdit.Text = "Изменить данные выбранного правила";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = global::AccessControlSystem.Properties.Resources._186389_512;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelete.Text = "Удалить выбранное правило";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = global::AccessControlSystem.Properties.Resources.if_refresh27_216529;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "Обновить набор данных";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_regulation";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 40;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Access_time_from";
            this.dataGridViewTextBoxColumn3.HeaderText = "Время доступа с";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 107;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Access_time_to";
            this.dataGridViewTextBoxColumn5.HeaderText = "Время доступа до";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 102;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Days_of_week";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дни недели";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 85;
            // 
            // ColumnAdd
            // 
            this.ColumnAdd.HeaderText = "Добавить";
            this.ColumnAdd.Name = "ColumnAdd";
            this.ColumnAdd.ReadOnly = true;
            this.ColumnAdd.Text = "Добавить";
            this.ColumnAdd.UseColumnTextForButtonValue = true;
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
            // FormRegulationBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 312);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.regulationsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(555, 350);
            this.Name = "FormRegulationBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник правил";
            this.Load += new System.EventHandler(this.FormRegulationBook_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.regulationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regulationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regulationsBindingNavigator)).EndInit();
            this.regulationsBindingNavigator.ResumeLayout(false);
            this.regulationsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room_regulationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelFind;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private System.Windows.Forms.BindingSource regulationsBindingSource;
        private accessControlSystemDataSetTableAdapters.RegulationsTableAdapter regulationsTableAdapter;
        private accessControlSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator regulationsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView regulationsDataGridView;
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
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnAdd;
        private System.Windows.Forms.BindingSource room_regulationBindingSource;
        private accessControlSystemDataSetTableAdapters.Room_regulationTableAdapter room_regulationTableAdapter;
    }
}