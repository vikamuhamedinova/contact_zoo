namespace ZooPro
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.животныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.животныеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.кормаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кормаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.наборыКормовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расхМатериалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.материалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabDesk = new System.Windows.Forms.TabControl();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.saleMenuItem,
            this.животныеToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.кормаToolStripMenuItem,
            this.расхМатериалыToolStripMenuItem,
            this.отчетностьToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(864, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStripMain";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // saleMenuItem
            // 
            this.saleMenuItem.Name = "saleMenuItem";
            this.saleMenuItem.Size = new System.Drawing.Size(65, 20);
            this.saleMenuItem.Text = "Продажа";
            this.saleMenuItem.Click += new System.EventHandler(this.saleMenuItem_Click);
            // 
            // животныеToolStripMenuItem
            // 
            this.животныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.животныеToolStripMenuItem1});
            this.животныеToolStripMenuItem.Name = "животныеToolStripMenuItem";
            this.животныеToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.животныеToolStripMenuItem.Text = "Животные";
            // 
            // животныеToolStripMenuItem1
            // 
            this.животныеToolStripMenuItem1.Name = "животныеToolStripMenuItem1";
            this.животныеToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.животныеToolStripMenuItem1.Text = "Животные...";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem1});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // сотрудникиToolStripMenuItem1
            // 
            this.сотрудникиToolStripMenuItem1.Name = "сотрудникиToolStripMenuItem1";
            this.сотрудникиToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.сотрудникиToolStripMenuItem1.Text = "Сотрудники";
            // 
            // кормаToolStripMenuItem
            // 
            this.кормаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кормаToolStripMenuItem1,
            this.наборыКормовToolStripMenuItem});
            this.кормаToolStripMenuItem.Name = "кормаToolStripMenuItem";
            this.кормаToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.кормаToolStripMenuItem.Text = "Корма";
            // 
            // кормаToolStripMenuItem1
            // 
            this.кормаToolStripMenuItem1.Name = "кормаToolStripMenuItem1";
            this.кормаToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.кормаToolStripMenuItem1.Text = "Корма...";
            // 
            // наборыКормовToolStripMenuItem
            // 
            this.наборыКормовToolStripMenuItem.Name = "наборыКормовToolStripMenuItem";
            this.наборыКормовToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.наборыКормовToolStripMenuItem.Text = "Наборы кормов...";
            // 
            // расхМатериалыToolStripMenuItem
            // 
            this.расхМатериалыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.материалыToolStripMenuItem});
            this.расхМатериалыToolStripMenuItem.Name = "расхМатериалыToolStripMenuItem";
            this.расхМатериалыToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.расхМатериалыToolStripMenuItem.Text = "Расх. материалы";
            // 
            // материалыToolStripMenuItem
            // 
            this.материалыToolStripMenuItem.Name = "материалыToolStripMenuItem";
            this.материалыToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.материалыToolStripMenuItem.Text = "Материалы...";
            // 
            // отчетностьToolStripMenuItem
            // 
            this.отчетностьToolStripMenuItem.Name = "отчетностьToolStripMenuItem";
            this.отчетностьToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.отчетностьToolStripMenuItem.Text = "Отчетность";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // tabDesk
            // 
            this.tabDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDesk.Location = new System.Drawing.Point(0, 24);
            this.tabDesk.Name = "tabDesk";
            this.tabDesk.SelectedIndex = 0;
            this.tabDesk.Size = new System.Drawing.Size(864, 389);
            this.tabDesk.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 413);
            this.Controls.Add(this.tabDesk);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.Text = "Контактный зоопарк";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem животныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кормаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расхМатериалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem животныеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem кормаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem наборыКормовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem материалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleMenuItem;
        private System.Windows.Forms.TabControl tabDesk;
    }
}

