namespace AccessControlSystem
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отделыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.посетителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помещенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ключиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокКлючейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПрикрепленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыКлючейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусКлючейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.привзякаКлючаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закреплениеПравилЗаВыданнымКлючомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетЖурналДоступаКОбъектуВЗаданныйДеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessControlSystemDataSet = new AccessControlSystem.accessControlSystemDataSet();
            this.Report_Journal_date_roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Report_Journal_date_roomTableAdapter = new AccessControlSystem.accessControlSystemDataSetTableAdapters.Report_Journal_date_roomTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Journal_date_roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.операцииToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.посетителиToolStripMenuItem,
            this.помещенияToolStripMenuItem,
            this.правилаToolStripMenuItem,
            this.toolStripSeparator1,
            this.ключиToolStripMenuItem,
            this.журналToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокСотрудниковToolStripMenuItem,
            this.должностиToolStripMenuItem1,
            this.отделыToolStripMenuItem1});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // списокСотрудниковToolStripMenuItem
            // 
            this.списокСотрудниковToolStripMenuItem.Name = "списокСотрудниковToolStripMenuItem";
            this.списокСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.списокСотрудниковToolStripMenuItem.Text = "Список сотрудников";
            this.списокСотрудниковToolStripMenuItem.Click += new System.EventHandler(this.списокСотрудниковToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem1
            // 
            this.должностиToolStripMenuItem1.Name = "должностиToolStripMenuItem1";
            this.должностиToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.должностиToolStripMenuItem1.Text = "Должности";
            this.должностиToolStripMenuItem1.Click += new System.EventHandler(this.должностиToolStripMenuItem1_Click);
            // 
            // отделыToolStripMenuItem1
            // 
            this.отделыToolStripMenuItem1.Name = "отделыToolStripMenuItem1";
            this.отделыToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.отделыToolStripMenuItem1.Text = "Отделы";
            this.отделыToolStripMenuItem1.Click += new System.EventHandler(this.отделыToolStripMenuItem1_Click);
            // 
            // посетителиToolStripMenuItem
            // 
            this.посетителиToolStripMenuItem.Name = "посетителиToolStripMenuItem";
            this.посетителиToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.посетителиToolStripMenuItem.Text = "Посетители";
            this.посетителиToolStripMenuItem.Click += new System.EventHandler(this.посетителиToolStripMenuItem_Click);
            // 
            // помещенияToolStripMenuItem
            // 
            this.помещенияToolStripMenuItem.Name = "помещенияToolStripMenuItem";
            this.помещенияToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.помещенияToolStripMenuItem.Text = "Объекты предприятия";
            this.помещенияToolStripMenuItem.Click += new System.EventHandler(this.помещенияToolStripMenuItem_Click);
            // 
            // правилаToolStripMenuItem
            // 
            this.правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            this.правилаToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.правилаToolStripMenuItem.Text = "Правила";
            this.правилаToolStripMenuItem.Click += new System.EventHandler(this.правилаToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // ключиToolStripMenuItem
            // 
            this.ключиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокКлючейToolStripMenuItem,
            this.списокПрикрепленияToolStripMenuItem,
            this.типыКлючейToolStripMenuItem,
            this.статусКлючейToolStripMenuItem});
            this.ключиToolStripMenuItem.Name = "ключиToolStripMenuItem";
            this.ключиToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ключиToolStripMenuItem.Text = "Ключи";
            // 
            // списокКлючейToolStripMenuItem
            // 
            this.списокКлючейToolStripMenuItem.Name = "списокКлючейToolStripMenuItem";
            this.списокКлючейToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.списокКлючейToolStripMenuItem.Text = "Список ключей";
            this.списокКлючейToolStripMenuItem.Click += new System.EventHandler(this.списокКлючейToolStripMenuItem_Click);
            // 
            // списокПрикрепленияToolStripMenuItem
            // 
            this.списокПрикрепленияToolStripMenuItem.Name = "списокПрикрепленияToolStripMenuItem";
            this.списокПрикрепленияToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.списокПрикрепленияToolStripMenuItem.Text = "Список прикреплений";
            this.списокПрикрепленияToolStripMenuItem.Click += new System.EventHandler(this.списокПрикрепленияToolStripMenuItem_Click);
            // 
            // типыКлючейToolStripMenuItem
            // 
            this.типыКлючейToolStripMenuItem.Name = "типыКлючейToolStripMenuItem";
            this.типыКлючейToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.типыКлючейToolStripMenuItem.Text = "Типы ключей";
            this.типыКлючейToolStripMenuItem.Click += new System.EventHandler(this.типыКлючейToolStripMenuItem_Click);
            // 
            // статусКлючейToolStripMenuItem
            // 
            this.статусКлючейToolStripMenuItem.Name = "статусКлючейToolStripMenuItem";
            this.статусКлючейToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.статусКлючейToolStripMenuItem.Text = "Статусы ключей";
            this.статусКлючейToolStripMenuItem.Click += new System.EventHandler(this.статусКлючейToolStripMenuItem_Click);
            // 
            // журналToolStripMenuItem
            // 
            this.журналToolStripMenuItem.Name = "журналToolStripMenuItem";
            this.журналToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.журналToolStripMenuItem.Text = "Журнал доступа";
            this.журналToolStripMenuItem.Click += new System.EventHandler(this.журналToolStripMenuItem_Click);
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.привзякаКлючаToolStripMenuItem,
            this.закреплениеПравилЗаВыданнымКлючомToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            this.операцииToolStripMenuItem.Visible = false;
            // 
            // привзякаКлючаToolStripMenuItem
            // 
            this.привзякаКлючаToolStripMenuItem.Name = "привзякаКлючаToolStripMenuItem";
            this.привзякаКлючаToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.привзякаКлючаToolStripMenuItem.Text = "Прикрепление ключа к сотруднику или посетителю";
            this.привзякаКлючаToolStripMenuItem.Click += new System.EventHandler(this.привзякаКлючаToolStripMenuItem_Click);
            // 
            // закреплениеПравилЗаВыданнымКлючомToolStripMenuItem
            // 
            this.закреплениеПравилЗаВыданнымКлючомToolStripMenuItem.Name = "закреплениеПравилЗаВыданнымКлючомToolStripMenuItem";
            this.закреплениеПравилЗаВыданнымКлючомToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.закреплениеПравилЗаВыданнымКлючомToolStripMenuItem.Text = "Закрепление правил за выданным ключом";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетЖурналДоступаКОбъектуВЗаданныйДеньToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // отчетЖурналДоступаКОбъектуВЗаданныйДеньToolStripMenuItem
            // 
            this.отчетЖурналДоступаКОбъектуВЗаданныйДеньToolStripMenuItem.Name = "отчетЖурналДоступаКОбъектуВЗаданныйДеньToolStripMenuItem";
            this.отчетЖурналДоступаКОбъектуВЗаданныйДеньToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.отчетЖурналДоступаКОбъектуВЗаданныйДеньToolStripMenuItem.Text = "Отчет \"Журнал доступа к объекту в заданный день\"";
            this.отчетЖурналДоступаКОбъектуВЗаданныйДеньToolStripMenuItem.Click += new System.EventHandler(this.отчетЖурналДоступаКОбъектуВЗаданныйДеньToolStripMenuItem_Click);
            // 
            // accessControlSystemDataSet
            // 
            this.accessControlSystemDataSet.DataSetName = "accessControlSystemDataSet";
            this.accessControlSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Report_Journal_date_roomBindingSource
            // 
            this.Report_Journal_date_roomBindingSource.DataMember = "Report_Journal_date_room";
            this.Report_Journal_date_roomBindingSource.DataSource = this.accessControlSystemDataSet;
            // 
            // Report_Journal_date_roomTableAdapter
            // 
            this.Report_Journal_date_roomTableAdapter.ClearBeforeFill = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 396);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма администратора";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Journal_date_roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem отделыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem посетителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помещенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ключиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокКлючейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыКлючейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусКлючейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem привзякаКлючаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закреплениеПравилЗаВыданнымКлючомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПрикрепленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетЖурналДоступаКОбъектуВЗаданныйДеньToolStripMenuItem;
        private System.Windows.Forms.BindingSource Report_Journal_date_roomBindingSource;
        private accessControlSystemDataSet accessControlSystemDataSet;
        private accessControlSystemDataSetTableAdapters.Report_Journal_date_roomTableAdapter Report_Journal_date_roomTableAdapter;
    }
}