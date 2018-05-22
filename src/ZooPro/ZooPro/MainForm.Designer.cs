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
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleStatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabDesk = new System.Windows.Forms.TabControl();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.saleMenuItem,
            this.reportMenuItem,
            this.helpMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(864, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStripMain";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileMenuItem.Text = "Файл";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // saleMenuItem
            // 
            this.saleMenuItem.Name = "saleMenuItem";
            this.saleMenuItem.Size = new System.Drawing.Size(69, 20);
            this.saleMenuItem.Text = "Продажа";
            this.saleMenuItem.Click += new System.EventHandler(this.saleMenuItem_Click);
            // 
            // reportMenuItem
            // 
            this.reportMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleStatMenuItem});
            this.reportMenuItem.Name = "reportMenuItem";
            this.reportMenuItem.Size = new System.Drawing.Size(82, 20);
            this.reportMenuItem.Text = "Отчетность";
            // 
            // saleStatMenuItem
            // 
            this.saleStatMenuItem.Name = "saleStatMenuItem";
            this.saleStatMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saleStatMenuItem.Text = "Продажи...";
            this.saleStatMenuItem.Click += new System.EventHandler(this.saleStatMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketTypeMenuItem,
            this.promoMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpMenuItem.Text = "Справка";
            // 
            // ticketTypeMenuItem
            // 
            this.ticketTypeMenuItem.Name = "ticketTypeMenuItem";
            this.ticketTypeMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ticketTypeMenuItem.Text = "Типы билетов...";
            this.ticketTypeMenuItem.Click += new System.EventHandler(this.ticketTypeMenuItem_Click);
            // 
            // promoMenuItem
            // 
            this.promoMenuItem.Name = "promoMenuItem";
            this.promoMenuItem.Size = new System.Drawing.Size(161, 22);
            this.promoMenuItem.Text = "Акции...";
            this.promoMenuItem.Click += new System.EventHandler(this.promoMenuItem_Click);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleMenuItem;
        private System.Windows.Forms.TabControl tabDesk;
        private System.Windows.Forms.ToolStripMenuItem promoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleStatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketTypeMenuItem;
    }
}

