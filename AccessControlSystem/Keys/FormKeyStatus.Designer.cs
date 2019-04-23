namespace AccessControlSystem
{
    partial class FormKeyStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKeyStatus));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelFindStatus = new System.Windows.Forms.Panel();
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.key_statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.key_statusTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.Key_statusTableAdapter();
            this.tableAdapterManager = new AccessControlSystem.accessControlSystemDataSetTableAdapters.TableAdapterManager();
            this.key_statusBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.key_statusBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.key_statusDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFindName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFindDescription = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonFindPosition = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelFindStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key_statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key_statusBindingNavigator)).BeginInit();
            this.key_statusBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.key_statusDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.key_statusDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelFindStatus, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 232);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelFindStatus
            // 
            this.panelFindStatus.Controls.Add(this.panel1);
            this.panelFindStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFindStatus.Location = new System.Drawing.Point(3, 155);
            this.panelFindStatus.Name = "panelFindStatus";
            this.panelFindStatus.Size = new System.Drawing.Size(418, 74);
            this.panelFindStatus.TabIndex = 0;
            // 
            // accessControlSystemDataSet
            // 
            this.accessControlSystemDataSet.DataSetName = "accessControlSystemDataSet";
            this.accessControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // key_statusBindingSource
            // 
            this.key_statusBindingSource.DataMember = "Key_status";
            this.key_statusBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // key_statusTableAdapter
            // 
            this.key_statusTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.JournalTableAdapter = null;
            this.tableAdapterManager.Key_statusTableAdapter = this.key_statusTableAdapter;
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
            // key_statusBindingNavigator
            // 
            this.key_statusBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.key_statusBindingNavigator.BindingSource = this.key_statusBindingSource;
            this.key_statusBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.key_statusBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.key_statusBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.key_statusBindingNavigatorSaveItem,
            this.toolStripButtonRefresh});
            this.key_statusBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.key_statusBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.key_statusBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.key_statusBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.key_statusBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.key_statusBindingNavigator.Name = "key_statusBindingNavigator";
            this.key_statusBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.key_statusBindingNavigator.Size = new System.Drawing.Size(424, 25);
            this.key_statusBindingNavigator.TabIndex = 2;
            this.key_statusBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::AccessControlSystem.Properties.Resources.if_plus_24_103172;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::AccessControlSystem.Properties.Resources._186389_512;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // key_statusBindingNavigatorSaveItem
            // 
            this.key_statusBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.key_statusBindingNavigatorSaveItem.Image = global::AccessControlSystem.Properties.Resources.if_save_1608823;
            this.key_statusBindingNavigatorSaveItem.Name = "key_statusBindingNavigatorSaveItem";
            this.key_statusBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.key_statusBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.key_statusBindingNavigatorSaveItem.Click += new System.EventHandler(this.key_statusBindingNavigatorSaveItem_Click);
            // 
            // key_statusDataGridView
            // 
            this.key_statusDataGridView.AutoGenerateColumns = false;
            this.key_statusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.key_statusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.key_statusDataGridView.DataSource = this.key_statusBindingSource;
            this.key_statusDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key_statusDataGridView.Location = new System.Drawing.Point(3, 3);
            this.key_statusDataGridView.Name = "key_statusDataGridView";
            this.key_statusDataGridView.Size = new System.Drawing.Size(418, 146);
            this.key_statusDataGridView.TabIndex = 1;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_status";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 82;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 82;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonFindPosition);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxFindDescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxFindName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 74);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поиск:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название";
            // 
            // textBoxFindName
            // 
            this.textBoxFindName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFindName.Location = new System.Drawing.Point(66, 16);
            this.textBoxFindName.Name = "textBoxFindName";
            this.textBoxFindName.Size = new System.Drawing.Size(260, 20);
            this.textBoxFindName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Описание";
            // 
            // textBoxFindDescription
            // 
            this.textBoxFindDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFindDescription.Location = new System.Drawing.Point(66, 42);
            this.textBoxFindDescription.Name = "textBoxFindDescription";
            this.textBoxFindDescription.Size = new System.Drawing.Size(260, 20);
            this.textBoxFindDescription.TabIndex = 9;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(334, 40);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Сброс";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonFindPosition
            // 
            this.buttonFindPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindPosition.Location = new System.Drawing.Point(334, 14);
            this.buttonFindPosition.Name = "buttonFindPosition";
            this.buttonFindPosition.Size = new System.Drawing.Size(75, 23);
            this.buttonFindPosition.TabIndex = 11;
            this.buttonFindPosition.Text = "Поиск";
            this.buttonFindPosition.UseVisualStyleBackColor = true;
            this.buttonFindPosition.Click += new System.EventHandler(this.buttonFindPosition_Click);
            // 
            // FormKeyStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 257);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.key_statusBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 295);
            this.MinimumSize = new System.Drawing.Size(440, 295);
            this.Name = "FormKeyStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статусы ключей";
            this.Load += new System.EventHandler(this.FormKeyStatus_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelFindStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key_statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key_statusBindingNavigator)).EndInit();
            this.key_statusBindingNavigator.ResumeLayout(false);
            this.key_statusBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.key_statusDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelFindStatus;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private System.Windows.Forms.BindingSource key_statusBindingSource;
        private accessControlSystemDataSetTableAdapters.Key_statusTableAdapter key_statusTableAdapter;
        private accessControlSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator key_statusBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton key_statusBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView key_statusDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFindDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFindName;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonFindPosition;
    }
}