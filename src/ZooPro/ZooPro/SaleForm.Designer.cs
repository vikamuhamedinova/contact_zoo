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
            this.costLabel = new System.Windows.Forms.Label();
            this.addTicketButton = new System.Windows.Forms.Button();
            this.ticketLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.FoodSetLabel = new System.Windows.Forms.Label();
            this.foodSetTable = new System.Windows.Forms.DataGridView();
            this.foodSetGroup = new System.Windows.Forms.GroupBox();
            this.setType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodSetLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.summaryLayout = new System.Windows.Forms.TableLayoutPanel();
            this.totalTicketCostLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.totalFoodsetCostLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.submitSaleButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            this.ticketLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodSetTable)).BeginInit();
            this.foodSetGroup.SuspendLayout();
            this.foodSetLayout.SuspendLayout();
            this.summaryLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicketLabel
            // 
            this.TicketLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketLabel.Location = new System.Drawing.Point(12, 34);
            this.TicketLabel.Name = "TicketLabel";
            this.TicketLabel.Size = new System.Drawing.Size(740, 23);
            this.TicketLabel.TabIndex = 1;
            this.TicketLabel.Text = "Билеты";
            this.TicketLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // adultLabel
            // 
            this.adultLabel.AutoSize = true;
            this.adultLabel.Location = new System.Drawing.Point(5, 28);
            this.adultLabel.Margin = new System.Windows.Forms.Padding(5);
            this.adultLabel.Name = "adultLabel";
            this.adultLabel.Size = new System.Drawing.Size(58, 13);
            this.adultLabel.TabIndex = 2;
            this.adultLabel.Text = "Взрослый";
            this.adultLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // childLabel
            // 
            this.childLabel.AutoSize = true;
            this.childLabel.Location = new System.Drawing.Point(5, 57);
            this.childLabel.Margin = new System.Windows.Forms.Padding(5);
            this.childLabel.Name = "childLabel";
            this.childLabel.Size = new System.Drawing.Size(51, 13);
            this.childLabel.TabIndex = 3;
            this.childLabel.Text = "Детский";
            this.childLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // promoComboBox
            // 
            this.promoComboBox.FormattingEnabled = true;
            this.promoComboBox.Location = new System.Drawing.Point(119, 26);
            this.promoComboBox.Name = "promoComboBox";
            this.promoComboBox.Size = new System.Drawing.Size(96, 21);
            this.promoComboBox.TabIndex = 4;
            // 
            // promoLabel
            // 
            this.promoLabel.AutoSize = true;
            this.promoLabel.Location = new System.Drawing.Point(73, 28);
            this.promoLabel.Margin = new System.Windows.Forms.Padding(5);
            this.promoLabel.Name = "promoLabel";
            this.promoLabel.Size = new System.Drawing.Size(38, 13);
            this.promoLabel.TabIndex = 5;
            this.promoLabel.Text = "Акция";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(223, 28);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(5);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(66, 13);
            this.quantityLabel.TabIndex = 6;
            this.quantityLabel.Text = "Количество";
            this.quantityLabel.UseWaitCursor = true;
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.Location = new System.Drawing.Point(297, 26);
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(40, 20);
            this.quantityUpDown.TabIndex = 7;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(345, 5);
            this.costLabel.Margin = new System.Windows.Forms.Padding(5);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(33, 13);
            this.costLabel.TabIndex = 8;
            this.costLabel.Text = "Цена";
            this.costLabel.UseWaitCursor = true;
            this.costLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // addTicketButton
            // 
            this.addTicketButton.Location = new System.Drawing.Point(386, 26);
            this.addTicketButton.Name = "addTicketButton";
            this.addTicketButton.Size = new System.Drawing.Size(75, 23);
            this.addTicketButton.TabIndex = 9;
            this.addTicketButton.Text = "Добавить";
            this.addTicketButton.UseVisualStyleBackColor = true;
            // 
            // ticketLayout
            // 
            this.ticketLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketLayout.AutoSize = true;
            this.ticketLayout.ColumnCount = 7;
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.Controls.Add(this.adultLabel, 0, 1);
            this.ticketLayout.Controls.Add(this.addTicketButton, 6, 1);
            this.ticketLayout.Controls.Add(this.label1, 1, 2);
            this.ticketLayout.Controls.Add(this.promoLabel, 1, 1);
            this.ticketLayout.Controls.Add(this.costLabel, 5, 0);
            this.ticketLayout.Controls.Add(this.promoComboBox, 2, 1);
            this.ticketLayout.Controls.Add(this.childLabel, 0, 2);
            this.ticketLayout.Controls.Add(this.quantityUpDown, 4, 1);
            this.ticketLayout.Controls.Add(this.quantityLabel, 3, 1);
            this.ticketLayout.Location = new System.Drawing.Point(15, 60);
            this.ticketLayout.Name = "ticketLayout";
            this.ticketLayout.RowCount = 3;
            this.ticketLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ticketLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ticketLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ticketLayout.Size = new System.Drawing.Size(737, 75);
            this.ticketLayout.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Акция";
            // 
            // FoodSetLabel
            // 
            this.FoodSetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FoodSetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoodSetLabel.Location = new System.Drawing.Point(6, 16);
            this.FoodSetLabel.Name = "FoodSetLabel";
            this.FoodSetLabel.Size = new System.Drawing.Size(352, 23);
            this.FoodSetLabel.TabIndex = 1;
            this.FoodSetLabel.Text = "Наборы";
            this.FoodSetLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // foodSetTable
            // 
            this.foodSetTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodSetTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.foodSetTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodSetTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.setType,
            this.setQuantity,
            this.setCost});
            this.foodSetTable.Location = new System.Drawing.Point(9, 42);
            this.foodSetTable.MultiSelect = false;
            this.foodSetTable.Name = "foodSetTable";
            this.foodSetTable.Size = new System.Drawing.Size(349, 179);
            this.foodSetTable.TabIndex = 11;
            // 
            // foodSetGroup
            // 
            this.foodSetGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodSetGroup.Controls.Add(this.foodSetLayout);
            this.foodSetGroup.Controls.Add(this.FoodSetLabel);
            this.foodSetGroup.Controls.Add(this.foodSetTable);
            this.foodSetGroup.Location = new System.Drawing.Point(15, 141);
            this.foodSetGroup.Name = "foodSetGroup";
            this.foodSetGroup.Size = new System.Drawing.Size(364, 262);
            this.foodSetGroup.TabIndex = 12;
            this.foodSetGroup.TabStop = false;
            // 
            // setType
            // 
            this.setType.HeaderText = "Тип набора";
            this.setType.Name = "setType";
            this.setType.Width = 90;
            // 
            // setQuantity
            // 
            this.setQuantity.HeaderText = "Количество";
            this.setQuantity.Name = "setQuantity";
            this.setQuantity.Width = 91;
            // 
            // setCost
            // 
            this.setCost.HeaderText = "Стоимость";
            this.setCost.Name = "setCost";
            this.setCost.Width = 87;
            // 
            // foodSetLayout
            // 
            this.foodSetLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodSetLayout.AutoSize = true;
            this.foodSetLayout.ColumnCount = 3;
            this.foodSetLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.foodSetLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.foodSetLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.foodSetLayout.Controls.Add(this.button1, 0, 0);
            this.foodSetLayout.Controls.Add(this.button2, 1, 0);
            this.foodSetLayout.Controls.Add(this.button3, 2, 0);
            this.foodSetLayout.Location = new System.Drawing.Point(9, 227);
            this.foodSetLayout.Name = "foodSetLayout";
            this.foodSetLayout.RowCount = 1;
            this.foodSetLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.foodSetLayout.Size = new System.Drawing.Size(349, 29);
            this.foodSetLayout.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(119, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(235, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // summaryLayout
            // 
            this.summaryLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryLayout.AutoSize = true;
            this.summaryLayout.ColumnCount = 2;
            this.summaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.summaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.summaryLayout.Controls.Add(this.totalTicketCostLabel, 0, 0);
            this.summaryLayout.Controls.Add(this.textBox1, 1, 0);
            this.summaryLayout.Controls.Add(this.totalFoodsetCostLabel, 0, 1);
            this.summaryLayout.Controls.Add(this.textBox2, 1, 1);
            this.summaryLayout.Controls.Add(this.totalCostLabel, 0, 2);
            this.summaryLayout.Controls.Add(this.label2, 1, 2);
            this.summaryLayout.Location = new System.Drawing.Point(387, 278);
            this.summaryLayout.Name = "summaryLayout";
            this.summaryLayout.RowCount = 3;
            this.summaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.summaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.summaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.summaryLayout.Size = new System.Drawing.Size(365, 90);
            this.summaryLayout.TabIndex = 13;
            // 
            // totalTicketCostLabel
            // 
            this.totalTicketCostLabel.AutoSize = true;
            this.totalTicketCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalTicketCostLabel.Location = new System.Drawing.Point(5, 5);
            this.totalTicketCostLabel.Margin = new System.Windows.Forms.Padding(5);
            this.totalTicketCostLabel.Name = "totalTicketCostLabel";
            this.totalTicketCostLabel.Size = new System.Drawing.Size(158, 17);
            this.totalTicketCostLabel.TabIndex = 0;
            this.totalTicketCostLabel.Text = "Стоимость билетов:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(172, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 1;
            // 
            // totalFoodsetCostLabel
            // 
            this.totalFoodsetCostLabel.AutoSize = true;
            this.totalFoodsetCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalFoodsetCostLabel.Location = new System.Drawing.Point(5, 32);
            this.totalFoodsetCostLabel.Margin = new System.Windows.Forms.Padding(5);
            this.totalFoodsetCostLabel.Name = "totalFoodsetCostLabel";
            this.totalFoodsetCostLabel.Size = new System.Drawing.Size(159, 17);
            this.totalFoodsetCostLabel.TabIndex = 2;
            this.totalFoodsetCostLabel.Text = "Стоимость наборов:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(172, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(190, 20);
            this.textBox2.TabIndex = 3;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalCostLabel.Location = new System.Drawing.Point(5, 59);
            this.totalCostLabel.Margin = new System.Windows.Forms.Padding(5);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(82, 26);
            this.totalCostLabel.TabIndex = 4;
            this.totalCostLabel.Text = "Итого:";
            // 
            // submitSaleButton
            // 
            this.submitSaleButton.Location = new System.Drawing.Point(650, 374);
            this.submitSaleButton.Name = "submitSaleButton";
            this.submitSaleButton.Size = new System.Drawing.Size(124, 23);
            this.submitSaleButton.TabIndex = 14;
            this.submitSaleButton.Text = "Закончить продажу";
            this.submitSaleButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(174, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(764, 415);
            this.Controls.Add(this.submitSaleButton);
            this.Controls.Add(this.summaryLayout);
            this.Controls.Add(this.foodSetGroup);
            this.Controls.Add(this.ticketLayout);
            this.Controls.Add(this.TicketLabel);
            this.Name = "SaleForm";
            this.Controls.SetChildIndex(this.TicketLabel, 0);
            this.Controls.SetChildIndex(this.ticketLayout, 0);
            this.Controls.SetChildIndex(this.foodSetGroup, 0);
            this.Controls.SetChildIndex(this.summaryLayout, 0);
            this.Controls.SetChildIndex(this.submitSaleButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            this.ticketLayout.ResumeLayout(false);
            this.ticketLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodSetTable)).EndInit();
            this.foodSetGroup.ResumeLayout(false);
            this.foodSetGroup.PerformLayout();
            this.foodSetLayout.ResumeLayout(false);
            this.summaryLayout.ResumeLayout(false);
            this.summaryLayout.PerformLayout();
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
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Button addTicketButton;
        private System.Windows.Forms.TableLayoutPanel ticketLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FoodSetLabel;
        private System.Windows.Forms.DataGridView foodSetTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn setType;
        private System.Windows.Forms.DataGridViewTextBoxColumn setQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn setCost;
        private System.Windows.Forms.GroupBox foodSetGroup;
        private System.Windows.Forms.TableLayoutPanel foodSetLayout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel summaryLayout;
        private System.Windows.Forms.Label totalTicketCostLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label totalFoodsetCostLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitSaleButton;
    }
}
