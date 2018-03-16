namespace ZooPro
{
    partial class SaleForm
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
            this.TicketLabel = new System.Windows.Forms.Label();
            this.adultLabel = new System.Windows.Forms.Label();
            this.childLabel = new System.Windows.Forms.Label();
            this.promoComboBox = new System.Windows.Forms.ComboBox();
            this.promoLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.costLable = new System.Windows.Forms.Label();
            this.addTicketButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TicketLabel
            // 
            this.TicketLabel.Location = new System.Drawing.Point(12, 34);
            this.TicketLabel.Name = "TicketLabel";
            this.TicketLabel.Size = new System.Drawing.Size(100, 23);
            this.TicketLabel.TabIndex = 1;
            this.TicketLabel.Text = "Билеты";
            this.TicketLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // adultLabel
            // 
            this.adultLabel.AutoSize = true;
            this.adultLabel.Location = new System.Drawing.Point(12, 70);
            this.adultLabel.Name = "adultLabel";
            this.adultLabel.Size = new System.Drawing.Size(58, 13);
            this.adultLabel.TabIndex = 2;
            this.adultLabel.Text = "Взрослый";
            this.adultLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // childLabel
            // 
            this.childLabel.AutoSize = true;
            this.childLabel.Location = new System.Drawing.Point(12, 117);
            this.childLabel.Name = "childLabel";
            this.childLabel.Size = new System.Drawing.Size(51, 13);
            this.childLabel.TabIndex = 3;
            this.childLabel.Text = "Детский";
            this.childLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // promoComboBox
            // 
            this.promoComboBox.FormattingEnabled = true;
            this.promoComboBox.Location = new System.Drawing.Point(170, 67);
            this.promoComboBox.Name = "promoComboBox";
            this.promoComboBox.Size = new System.Drawing.Size(96, 21);
            this.promoComboBox.TabIndex = 4;
            // 
            // promoLabel
            // 
            this.promoLabel.AutoSize = true;
            this.promoLabel.Location = new System.Drawing.Point(126, 70);
            this.promoLabel.Name = "promoLabel";
            this.promoLabel.Size = new System.Drawing.Size(38, 13);
            this.promoLabel.TabIndex = 5;
            this.promoLabel.Text = "Акция";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(316, 70);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(66, 13);
            this.quantityLabel.TabIndex = 6;
            this.quantityLabel.Text = "Количество";
            this.quantityLabel.UseWaitCursor = true;
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.Location = new System.Drawing.Point(388, 68);
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(40, 20);
            this.quantityUpDown.TabIndex = 7;
            // 
            // costLable
            // 
            this.costLable.AutoSize = true;
            this.costLable.Location = new System.Drawing.Point(479, 70);
            this.costLable.Name = "costLable";
            this.costLable.Size = new System.Drawing.Size(33, 13);
            this.costLable.TabIndex = 8;
            this.costLable.Text = "Цена";
            this.costLable.UseWaitCursor = true;
            this.costLable.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // addTicketButton
            // 
            this.addTicketButton.Location = new System.Drawing.Point(732, 70);
            this.addTicketButton.Name = "addTicketButton";
            this.addTicketButton.Size = new System.Drawing.Size(75, 23);
            this.addTicketButton.TabIndex = 9;
            this.addTicketButton.Text = "Добавить";
            this.addTicketButton.UseVisualStyleBackColor = true;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 413);
            this.Controls.Add(this.addTicketButton);
            this.Controls.Add(this.costLable);
            this.Controls.Add(this.quantityUpDown);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.promoLabel);
            this.Controls.Add(this.promoComboBox);
            this.Controls.Add(this.childLabel);
            this.Controls.Add(this.adultLabel);
            this.Controls.Add(this.TicketLabel);
            this.Name = "SaleForm";
            this.Controls.SetChildIndex(this.TicketLabel, 0);
            this.Controls.SetChildIndex(this.adultLabel, 0);
            this.Controls.SetChildIndex(this.childLabel, 0);
            this.Controls.SetChildIndex(this.promoComboBox, 0);
            this.Controls.SetChildIndex(this.promoLabel, 0);
            this.Controls.SetChildIndex(this.quantityLabel, 0);
            this.Controls.SetChildIndex(this.quantityUpDown, 0);
            this.Controls.SetChildIndex(this.costLable, 0);
            this.Controls.SetChildIndex(this.addTicketButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TicketLabel;
        private System.Windows.Forms.Label adultLabel;
        private System.Windows.Forms.Label childLabel;
        private System.Windows.Forms.ComboBox promoComboBox;
        private System.Windows.Forms.Label promoLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
        private System.Windows.Forms.Label costLable;
        private System.Windows.Forms.Button addTicketButton;
    }
}
