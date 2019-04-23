namespace AccessControlSystem
{
    partial class FormKeysBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKeysBook));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.view_keysDataGridView = new System.Windows.Forms.DataGridView();
            this.view_keysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.panelFindKey = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.checkBoxValue = new System.Windows.Forms.CheckBox();
            this.checkBoxType = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.view_keysTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.View_keysTableAdapter();
            this.tableAdapterManager = new AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager();
            this.view_keysBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.keysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keysTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.KeysTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_keysDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_keysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            this.panelFindKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_keysBindingNavigator)).BeginInit();
            this.view_keysBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keysBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.view_keysDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelFindKey, 0, 1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(404, 252);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // view_keysDataGridView
            // 
            this.view_keysDataGridView.AllowUserToAddRows = false;
            this.view_keysDataGridView.AllowUserToDeleteRows = false;
            this.view_keysDataGridView.AutoGenerateColumns = false;
            this.view_keysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_keysDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.ColumnAdd});
            this.view_keysDataGridView.DataSource = this.view_keysBindingSource;
            this.view_keysDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_keysDataGridView.Location = new System.Drawing.Point(3, 3);
            this.view_keysDataGridView.Name = "view_keysDataGridView";
            this.view_keysDataGridView.ReadOnly = true;
            this.view_keysDataGridView.Size = new System.Drawing.Size(398, 166);
            this.view_keysDataGridView.TabIndex = 0;
            this.view_keysDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_keysDataGridView_CellContentClick);
            // 
            // view_keysBindingSource
            // 
            this.view_keysBindingSource.DataMember = "View_keys";
            this.view_keysBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // accessControlSystemDataSet
            // 
            this.accessControlSystemDataSet.DataSetName = "accessControlSystemDataSet";
            this.accessControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelFindKey
            // 
            this.panelFindKey.AutoScroll = true;
            this.panelFindKey.Controls.Add(this.buttonRefresh);
            this.panelFindKey.Controls.Add(this.buttonFind);
            this.panelFindKey.Controls.Add(this.textBoxStatus);
            this.panelFindKey.Controls.Add(this.textBoxValue);
            this.panelFindKey.Controls.Add(this.textBoxType);
            this.panelFindKey.Controls.Add(this.checkBoxStatus);
            this.panelFindKey.Controls.Add(this.checkBoxValue);
            this.panelFindKey.Controls.Add(this.checkBoxType);
            this.panelFindKey.Controls.Add(this.label1);
            this.panelFindKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFindKey.Location = new System.Drawing.Point(3, 175);
            this.panelFindKey.Name = "panelFindKey";
            this.panelFindKey.Size = new System.Drawing.Size(398, 74);
            this.panelFindKey.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(312, 44);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "Сбросить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(218, 44);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 7;
            this.buttonFind.Text = "Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(287, 18);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(100, 20);
            this.textBoxStatus.TabIndex = 6;
            this.textBoxStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(92, 46);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxValue.TabIndex = 4;
            this.textBoxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(92, 18);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 20);
            this.textBoxType.TabIndex = 2;
            this.textBoxType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(218, 20);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(63, 17);
            this.checkBoxStatus.TabIndex = 5;
            this.checkBoxStatus.Text = "Статус:";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // checkBoxValue
            // 
            this.checkBoxValue.AutoSize = true;
            this.checkBoxValue.Location = new System.Drawing.Point(9, 48);
            this.checkBoxValue.Name = "checkBoxValue";
            this.checkBoxValue.Size = new System.Drawing.Size(77, 17);
            this.checkBoxValue.TabIndex = 3;
            this.checkBoxValue.Text = "Значение:";
            this.checkBoxValue.UseVisualStyleBackColor = true;
            // 
            // checkBoxType
            // 
            this.checkBoxType.AutoSize = true;
            this.checkBoxType.Location = new System.Drawing.Point(9, 20);
            this.checkBoxType.Name = "checkBoxType";
            this.checkBoxType.Size = new System.Drawing.Size(82, 17);
            this.checkBoxType.TabIndex = 1;
            this.checkBoxType.Text = "Тип ключа:";
            this.checkBoxType.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск:";
            // 
            // view_keysTableAdapter
            // 
            this.view_keysTableAdapter.ClearBeforeFill = true;
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
            // view_keysBindingNavigator
            // 
            this.view_keysBindingNavigator.AddNewItem = null;
            this.view_keysBindingNavigator.BindingSource = this.view_keysBindingSource;
            this.view_keysBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.view_keysBindingNavigator.DeleteItem = null;
            this.view_keysBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.view_keysBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.view_keysBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.view_keysBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.view_keysBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.view_keysBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.view_keysBindingNavigator.Name = "view_keysBindingNavigator";
            this.view_keysBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.view_keysBindingNavigator.Size = new System.Drawing.Size(404, 25);
            this.view_keysBindingNavigator.TabIndex = 1;
            this.view_keysBindingNavigator.Text = "bindingNavigator1";
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
            this.toolStripButtonAdd.Image = global::AccessControlSystem.Properties.Resources.if_plus_24_103172;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd.Text = "Добавить ключ";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Image = global::AccessControlSystem.Properties.Resources.if_new_24_103173;
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEdit.Text = "Изменить данные";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = global::AccessControlSystem.Properties.Resources._186389_512;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelete.Text = "Удалить данные";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = global::AccessControlSystem.Properties.Resources.if_refresh27_216529;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "Обновить данные";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // keysBindingSource
            // 
            this.keysBindingSource.DataMember = "Keys";
            this.keysBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // keysTableAdapter
            // 
            this.keysTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_key";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 51;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Key_value";
            this.dataGridViewTextBoxColumn2.HeaderText = "Значение";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn6.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 66;
            // 
            // ColumnAdd
            // 
            this.ColumnAdd.HeaderText = "Добавить";
            this.ColumnAdd.Name = "ColumnAdd";
            this.ColumnAdd.ReadOnly = true;
            this.ColumnAdd.Text = "Добавить";
            this.ColumnAdd.UseColumnTextForButtonValue = true;
            // 
            // FormKeysBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 277);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.view_keysBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 315);
            this.MinimumSize = new System.Drawing.Size(420, 315);
            this.Name = "FormKeysBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник ключей";
            this.Load += new System.EventHandler(this.FormKeysBook_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_keysDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_keysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            this.panelFindKey.ResumeLayout(false);
            this.panelFindKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_keysBindingNavigator)).EndInit();
            this.view_keysBindingNavigator.ResumeLayout(false);
            this.view_keysBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keysBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private System.Windows.Forms.BindingSource view_keysBindingSource;
        private accessControlSystemDataSetTableAdapters.View_keysTableAdapter view_keysTableAdapter;
        private accessControlSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator view_keysBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView view_keysDataGridView;
        private System.Windows.Forms.Panel panelFindKey;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.CheckBox checkBoxValue;
        private System.Windows.Forms.CheckBox checkBoxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.BindingSource keysBindingSource;
        private accessControlSystemDataSetTableAdapters.KeysTableAdapter keysTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnAdd;
    }
}