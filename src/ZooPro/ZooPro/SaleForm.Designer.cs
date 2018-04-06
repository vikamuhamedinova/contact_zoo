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

        #region Код, автоматически созданный конструктором компонентов

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
            this.ticketLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.FoodSetLabel = new System.Windows.Forms.Label();
            this.foodSetTable = new System.Windows.Forms.DataGridView();
            this.setType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodSetGroup = new System.Windows.Forms.GroupBox();
            this.foodSetLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.summaryLayout = new System.Windows.Forms.TableLayoutPanel();
            this.totalTicketCostLabel = new System.Windows.Forms.Label();
            this.totalTicketCostBox = new System.Windows.Forms.TextBox();
            this.totalFoodsetCostLabel = new System.Windows.Forms.Label();
            this.totalFoodsetCostBox = new System.Windows.Forms.TextBox();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submitSaleButton = new System.Windows.Forms.Button();
            this.totalServiceCostLabel = new System.Windows.Forms.Label();
            this.totalServiceCostBox = new System.Windows.Forms.TextBox();
            this.serviceGroup = new System.Windows.Forms.GroupBox();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            this.ticketLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodSetTable)).BeginInit();
            this.foodSetGroup.SuspendLayout();
            this.foodSetLayout.SuspendLayout();
            this.summaryLayout.SuspendLayout();
            this.serviceGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TicketLabel
            // 
            this.TicketLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketLabel.Location = new System.Drawing.Point(8, 5);
            this.TicketLabel.Name = "TicketLabel";
            this.TicketLabel.Size = new System.Drawing.Size(712, 23);
            this.TicketLabel.TabIndex = 1;
            this.TicketLabel.Text = "Билеты";
            // 
            // adultLabel
            // 
            this.adultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adultLabel.AutoSize = true;
            this.adultLabel.Location = new System.Drawing.Point(8, 34);
            this.adultLabel.Margin = new System.Windows.Forms.Padding(5);
            this.adultLabel.Name = "adultLabel";
            this.adultLabel.Size = new System.Drawing.Size(58, 17);
            this.adultLabel.TabIndex = 2;
            this.adultLabel.Text = "Взрослый";
            this.adultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // childLabel
            // 
            this.childLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.childLabel.AutoSize = true;
            this.childLabel.Location = new System.Drawing.Point(8, 64);
            this.childLabel.Margin = new System.Windows.Forms.Padding(5);
            this.childLabel.Name = "childLabel";
            this.childLabel.Size = new System.Drawing.Size(58, 17);
            this.childLabel.TabIndex = 3;
            this.childLabel.Text = "Детский";
            this.childLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // promoComboBox
            // 
            this.promoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promoComboBox.FormattingEnabled = true;
            this.promoComboBox.Location = new System.Drawing.Point(131, 32);
            this.promoComboBox.Name = "promoComboBox";
            this.promoComboBox.Size = new System.Drawing.Size(96, 21);
            this.promoComboBox.TabIndex = 4;
            // 
            // promoLabel
            // 
            this.promoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promoLabel.AutoSize = true;
            this.promoLabel.Location = new System.Drawing.Point(79, 34);
            this.promoLabel.Margin = new System.Windows.Forms.Padding(5);
            this.promoLabel.Name = "promoLabel";
            this.promoLabel.Size = new System.Drawing.Size(41, 17);
            this.promoLabel.TabIndex = 5;
            this.promoLabel.Text = "Акция:";
            this.promoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(238, 34);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(5);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(69, 17);
            this.quantityLabel.TabIndex = 6;
            this.quantityLabel.Text = "Количество:";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quantityLabel.UseWaitCursor = true;
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityUpDown.Location = new System.Drawing.Point(318, 32);
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(40, 20);
            this.quantityUpDown.TabIndex = 7;
            // 
            // costLabel
            // 
            this.costLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(369, 8);
            this.costLabel.Margin = new System.Windows.Forms.Padding(5);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(332, 13);
            this.costLabel.TabIndex = 8;
            this.costLabel.Text = "Цена";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.costLabel.UseWaitCursor = true;
            // 
            // ticketLayout
            // 
            this.ticketLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketLayout.AutoSize = true;
            this.ticketLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.ticketLayout.ColumnCount = 6;
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.Controls.Add(this.adultLabel, 0, 1);
            this.ticketLayout.Controls.Add(this.label1, 1, 2);
            this.ticketLayout.Controls.Add(this.promoLabel, 1, 1);
            this.ticketLayout.Controls.Add(this.costLabel, 5, 0);
            this.ticketLayout.Controls.Add(this.promoComboBox, 2, 1);
            this.ticketLayout.Controls.Add(this.childLabel, 0, 2);
            this.ticketLayout.Controls.Add(this.quantityUpDown, 4, 1);
            this.ticketLayout.Controls.Add(this.quantityLabel, 3, 1);
            this.ticketLayout.Controls.Add(this.label3, 5, 1);
            this.ticketLayout.Controls.Add(this.comboBox1, 2, 2);
            this.ticketLayout.Controls.Add(this.label4, 3, 2);
            this.ticketLayout.Controls.Add(this.numericUpDown1, 4, 2);
            this.ticketLayout.Location = new System.Drawing.Point(11, 31);
            this.ticketLayout.Name = "ticketLayout";
            this.ticketLayout.RowCount = 3;
            this.ticketLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ticketLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ticketLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ticketLayout.Size = new System.Drawing.Size(709, 89);
            this.ticketLayout.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Акция:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(369, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "0,00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseWaitCursor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(318, 62);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // FoodSetLabel
            // 
            this.FoodSetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FoodSetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoodSetLabel.Location = new System.Drawing.Point(6, 16);
            this.FoodSetLabel.Name = "FoodSetLabel";
            this.FoodSetLabel.Size = new System.Drawing.Size(312, 23);
            this.FoodSetLabel.TabIndex = 1;
            this.FoodSetLabel.Text = "Наборы";
            // 
            // foodSetTable
            // 
            this.foodSetTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodSetTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.foodSetTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodSetTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.setType,
            this.setQuantity,
            this.setCost});
            this.foodSetTable.Location = new System.Drawing.Point(9, 42);
            this.foodSetTable.MultiSelect = false;
            this.foodSetTable.Name = "foodSetTable";
            this.foodSetTable.Size = new System.Drawing.Size(309, 216);
            this.foodSetTable.TabIndex = 11;
            // 
            // setType
            // 
            this.setType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.setType.HeaderText = "Тип набора";
            this.setType.MinimumWidth = 80;
            this.setType.Name = "setType";
            // 
            // setQuantity
            // 
            this.setQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.setQuantity.FillWeight = 75F;
            this.setQuantity.HeaderText = "Количество";
            this.setQuantity.Name = "setQuantity";
            this.setQuantity.Width = 91;
            // 
            // setCost
            // 
            this.setCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.setCost.FillWeight = 75F;
            this.setCost.HeaderText = "Стоимость";
            this.setCost.Name = "setCost";
            this.setCost.Width = 87;
            // 
            // foodSetGroup
            // 
            this.foodSetGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodSetGroup.Controls.Add(this.foodSetLayout);
            this.foodSetGroup.Controls.Add(this.FoodSetLabel);
            this.foodSetGroup.Controls.Add(this.foodSetTable);
            this.foodSetGroup.Location = new System.Drawing.Point(11, 126);
            this.foodSetGroup.Name = "foodSetGroup";
            this.foodSetGroup.Size = new System.Drawing.Size(324, 299);
            this.foodSetGroup.TabIndex = 12;
            this.foodSetGroup.TabStop = false;
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
            this.foodSetLayout.Location = new System.Drawing.Point(6, 264);
            this.foodSetLayout.Name = "foodSetLayout";
            this.foodSetLayout.RowCount = 1;
            this.foodSetLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.foodSetLayout.Size = new System.Drawing.Size(312, 29);
            this.foodSetLayout.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(107, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(211, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // summaryLayout
            // 
            this.summaryLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryLayout.AutoSize = true;
            this.summaryLayout.ColumnCount = 2;
            this.summaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.summaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.summaryLayout.Controls.Add(this.totalTicketCostLabel, 0, 0);
            this.summaryLayout.Controls.Add(this.totalTicketCostBox, 1, 0);
            this.summaryLayout.Controls.Add(this.totalFoodsetCostLabel, 0, 1);
            this.summaryLayout.Controls.Add(this.totalFoodsetCostBox, 1, 1);
            this.summaryLayout.Controls.Add(this.totalCostLabel, 0, 3);
            this.summaryLayout.Controls.Add(this.totalServiceCostLabel, 0, 2);
            this.summaryLayout.Controls.Add(this.label2, 1, 3);
            this.summaryLayout.Controls.Add(this.totalServiceCostBox, 1, 2);
            this.summaryLayout.Location = new System.Drawing.Point(341, 267);
            this.summaryLayout.Name = "summaryLayout";
            this.summaryLayout.RowCount = 4;
            this.summaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.summaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.summaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.summaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.summaryLayout.Size = new System.Drawing.Size(379, 117);
            this.summaryLayout.TabIndex = 13;
            // 
            // totalTicketCostLabel
            // 
            this.totalTicketCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTicketCostLabel.AutoSize = true;
            this.totalTicketCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalTicketCostLabel.Location = new System.Drawing.Point(5, 5);
            this.totalTicketCostLabel.Margin = new System.Windows.Forms.Padding(5);
            this.totalTicketCostLabel.Name = "totalTicketCostLabel";
            this.totalTicketCostLabel.Size = new System.Drawing.Size(173, 17);
            this.totalTicketCostLabel.TabIndex = 0;
            this.totalTicketCostLabel.Text = "Стоимость билетов:";
            // 
            // totalTicketCostBox
            // 
            this.totalTicketCostBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalTicketCostBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalTicketCostBox.Location = new System.Drawing.Point(186, 3);
            this.totalTicketCostBox.MinimumSize = new System.Drawing.Size(50, 0);
            this.totalTicketCostBox.Name = "totalTicketCostBox";
            this.totalTicketCostBox.ReadOnly = true;
            this.totalTicketCostBox.Size = new System.Drawing.Size(190, 20);
            this.totalTicketCostBox.TabIndex = 1;
            // 
            // totalFoodsetCostLabel
            // 
            this.totalFoodsetCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalFoodsetCostLabel.AutoSize = true;
            this.totalFoodsetCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalFoodsetCostLabel.Location = new System.Drawing.Point(5, 32);
            this.totalFoodsetCostLabel.Margin = new System.Windows.Forms.Padding(5);
            this.totalFoodsetCostLabel.Name = "totalFoodsetCostLabel";
            this.totalFoodsetCostLabel.Size = new System.Drawing.Size(173, 17);
            this.totalFoodsetCostLabel.TabIndex = 2;
            this.totalFoodsetCostLabel.Text = "Стоимость наборов:";
            // 
            // totalFoodsetCostBox
            // 
            this.totalFoodsetCostBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalFoodsetCostBox.Location = new System.Drawing.Point(186, 30);
            this.totalFoodsetCostBox.MinimumSize = new System.Drawing.Size(50, 0);
            this.totalFoodsetCostBox.Name = "totalFoodsetCostBox";
            this.totalFoodsetCostBox.ReadOnly = true;
            this.totalFoodsetCostBox.Size = new System.Drawing.Size(190, 20);
            this.totalFoodsetCostBox.TabIndex = 3;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalCostLabel.Location = new System.Drawing.Point(5, 86);
            this.totalCostLabel.Margin = new System.Windows.Forms.Padding(5);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(173, 26);
            this.totalCostLabel.TabIndex = 4;
            this.totalCostLabel.Text = "Итого:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(188, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "0,00";
            // 
            // submitSaleButton
            // 
            this.submitSaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitSaleButton.Location = new System.Drawing.Point(596, 393);
            this.submitSaleButton.Name = "submitSaleButton";
            this.submitSaleButton.Size = new System.Drawing.Size(124, 23);
            this.submitSaleButton.TabIndex = 14;
            this.submitSaleButton.Text = "Закончить продажу";
            this.submitSaleButton.UseVisualStyleBackColor = true;
            this.submitSaleButton.Click += new System.EventHandler(this.submitSaleButton_Click);
            // 
            // totalServiceCostLabel
            // 
            this.totalServiceCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalServiceCostLabel.AutoSize = true;
            this.totalServiceCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalServiceCostLabel.Location = new System.Drawing.Point(5, 59);
            this.totalServiceCostLabel.Margin = new System.Windows.Forms.Padding(5);
            this.totalServiceCostLabel.Name = "totalServiceCostLabel";
            this.totalServiceCostLabel.Size = new System.Drawing.Size(173, 17);
            this.totalServiceCostLabel.TabIndex = 2;
            this.totalServiceCostLabel.Text = "Стоимость доп. услуг:";
            // 
            // totalServiceCostBox
            // 
            this.totalServiceCostBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalServiceCostBox.Location = new System.Drawing.Point(186, 57);
            this.totalServiceCostBox.MinimumSize = new System.Drawing.Size(50, 0);
            this.totalServiceCostBox.Name = "totalServiceCostBox";
            this.totalServiceCostBox.ReadOnly = true;
            this.totalServiceCostBox.Size = new System.Drawing.Size(190, 20);
            this.totalServiceCostBox.TabIndex = 3;
            // 
            // serviceGroup
            // 
            this.serviceGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceGroup.Controls.Add(this.dataGridView1);
            this.serviceGroup.Controls.Add(this.serviceLabel);
            this.serviceGroup.Location = new System.Drawing.Point(341, 126);
            this.serviceGroup.Name = "serviceGroup";
            this.serviceGroup.Size = new System.Drawing.Size(379, 135);
            this.serviceGroup.TabIndex = 15;
            this.serviceGroup.TabStop = false;
            // 
            // serviceLabel
            // 
            this.serviceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceLabel.Location = new System.Drawing.Point(6, 16);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(367, 23);
            this.serviceLabel.TabIndex = 1;
            this.serviceLabel.Text = "Дополнительные услуги";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceName,
            this.servicePrice});
            this.dataGridView1.Location = new System.Drawing.Point(6, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(367, 87);
            this.dataGridView1.TabIndex = 2;
            // 
            // serviceName
            // 
            this.serviceName.HeaderText = "Название услуги";
            this.serviceName.Name = "serviceName";
            this.serviceName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // servicePrice
            // 
            this.servicePrice.HeaderText = "Стоимость";
            this.servicePrice.Name = "servicePrice";
            // 
            // SaleForm
            // 
            this.AutoSize = true;
            this.Controls.Add(this.serviceGroup);
            this.Controls.Add(this.submitSaleButton);
            this.Controls.Add(this.summaryLayout);
            this.Controls.Add(this.foodSetGroup);
            this.Controls.Add(this.ticketLayout);
            this.Controls.Add(this.TicketLabel);
            this.MinimumSize = new System.Drawing.Size(700, 340);
            this.Name = "SaleForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(728, 433);
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            this.ticketLayout.ResumeLayout(false);
            this.ticketLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodSetTable)).EndInit();
            this.foodSetGroup.ResumeLayout(false);
            this.foodSetGroup.PerformLayout();
            this.foodSetLayout.ResumeLayout(false);
            this.summaryLayout.ResumeLayout(false);
            this.summaryLayout.PerformLayout();
            this.serviceGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label TicketLabel;
        private System.Windows.Forms.Label adultLabel;
        private System.Windows.Forms.Label childLabel;
        private System.Windows.Forms.ComboBox promoComboBox;
        private System.Windows.Forms.Label promoLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TableLayoutPanel ticketLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FoodSetLabel;
        private System.Windows.Forms.DataGridView foodSetTable;
        private System.Windows.Forms.GroupBox foodSetGroup;
        private System.Windows.Forms.TableLayoutPanel foodSetLayout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel summaryLayout;
        private System.Windows.Forms.Label totalTicketCostLabel;
        private System.Windows.Forms.TextBox totalTicketCostBox;
        private System.Windows.Forms.Label totalFoodsetCostLabel;
        private System.Windows.Forms.TextBox totalFoodsetCostBox;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitSaleButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn setType;
        private System.Windows.Forms.DataGridViewTextBoxColumn setQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn setCost;

        #endregion

        private System.Windows.Forms.Label totalServiceCostLabel;
        private System.Windows.Forms.TextBox totalServiceCostBox;
        private System.Windows.Forms.GroupBox serviceGroup;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicePrice;
        private System.Windows.Forms.Label serviceLabel;
    }
}
