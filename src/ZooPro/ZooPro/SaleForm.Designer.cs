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
            this.promoLabelAlt = new System.Windows.Forms.Label();
            this.costValLabel = new System.Windows.Forms.Label();
            this.promoComboBoxAlt = new System.Windows.Forms.ComboBox();
            this.quantityLabelAlt = new System.Windows.Forms.Label();
            this.quantityUpDownAlt = new System.Windows.Forms.NumericUpDown();
            this.costValLabelAlt = new System.Windows.Forms.Label();
            this.costLabelAlt = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceLabelAlt = new System.Windows.Forms.Label();
            this.priceValLabel = new System.Windows.Forms.Label();
            this.priceValLabelAlt = new System.Windows.Forms.Label();
            this.summaryLayout = new System.Windows.Forms.TableLayoutPanel();
            this.totalTicketCostLabel = new System.Windows.Forms.Label();
            this.totalTicketCostBox = new System.Windows.Forms.TextBox();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCostValueLabel = new System.Windows.Forms.Label();
            this.submitSaleButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            this.ticketLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDownAlt)).BeginInit();
            this.summaryLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicketLabel
            // 
            this.TicketLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketLabel.Location = new System.Drawing.Point(8, 5);
            this.TicketLabel.Name = "TicketLabel";
            this.TicketLabel.Size = new System.Drawing.Size(684, 23);
            this.TicketLabel.TabIndex = 1;
            this.TicketLabel.Text = "Билеты";
            // 
            // adultLabel
            // 
            this.adultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adultLabel.AutoSize = true;
            this.adultLabel.Location = new System.Drawing.Point(8, 8);
            this.adultLabel.Margin = new System.Windows.Forms.Padding(5);
            this.adultLabel.Name = "adultLabel";
            this.adultLabel.Size = new System.Drawing.Size(58, 52);
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
            this.childLabel.Location = new System.Drawing.Point(8, 73);
            this.childLabel.Margin = new System.Windows.Forms.Padding(5);
            this.childLabel.Name = "childLabel";
            this.childLabel.Size = new System.Drawing.Size(58, 52);
            this.childLabel.TabIndex = 3;
            this.childLabel.Text = "Детский";
            this.childLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // promoComboBox
            // 
            this.promoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.promoComboBox.FormattingEnabled = true;
            this.promoComboBox.Location = new System.Drawing.Point(131, 23);
            this.promoComboBox.Name = "promoComboBox";
            this.promoComboBox.Size = new System.Drawing.Size(96, 21);
            this.promoComboBox.TabIndex = 4;
            this.promoComboBox.SelectedIndexChanged += new System.EventHandler(this.promoComboBox_SelectedIndexChanged);
            // 
            // promoLabel
            // 
            this.promoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promoLabel.AutoSize = true;
            this.promoLabel.Location = new System.Drawing.Point(79, 8);
            this.promoLabel.Margin = new System.Windows.Forms.Padding(5);
            this.promoLabel.Name = "promoLabel";
            this.promoLabel.Size = new System.Drawing.Size(41, 52);
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
            this.quantityLabel.Location = new System.Drawing.Point(238, 8);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(5);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(69, 52);
            this.quantityLabel.TabIndex = 6;
            this.quantityLabel.Text = "Количество:";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityUpDown.Location = new System.Drawing.Point(318, 24);
            this.quantityUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(57, 20);
            this.quantityUpDown.TabIndex = 7;
            this.quantityUpDown.ValueChanged += new System.EventHandler(this.quantityUpDown_ValueChanged);
            // 
            // costLabel
            // 
            this.costLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(501, 8);
            this.costLabel.Margin = new System.Windows.Forms.Padding(5);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(33, 52);
            this.costLabel.TabIndex = 8;
            this.costLabel.Text = "Цена";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ticketLayout
            // 
            this.ticketLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketLayout.AutoSize = true;
            this.ticketLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.ticketLayout.ColumnCount = 9;
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ticketLayout.Controls.Add(this.adultLabel, 0, 0);
            this.ticketLayout.Controls.Add(this.promoLabelAlt, 1, 1);
            this.ticketLayout.Controls.Add(this.promoLabel, 1, 0);
            this.ticketLayout.Controls.Add(this.promoComboBox, 2, 0);
            this.ticketLayout.Controls.Add(this.childLabel, 0, 1);
            this.ticketLayout.Controls.Add(this.quantityUpDown, 4, 0);
            this.ticketLayout.Controls.Add(this.quantityLabel, 3, 0);
            this.ticketLayout.Controls.Add(this.costValLabel, 8, 0);
            this.ticketLayout.Controls.Add(this.promoComboBoxAlt, 2, 1);
            this.ticketLayout.Controls.Add(this.quantityLabelAlt, 3, 1);
            this.ticketLayout.Controls.Add(this.quantityUpDownAlt, 4, 1);
            this.ticketLayout.Controls.Add(this.costValLabelAlt, 8, 1);
            this.ticketLayout.Controls.Add(this.costLabel, 7, 0);
            this.ticketLayout.Controls.Add(this.costLabelAlt, 7, 1);
            this.ticketLayout.Controls.Add(this.priceLabel, 5, 0);
            this.ticketLayout.Controls.Add(this.priceLabelAlt, 5, 1);
            this.ticketLayout.Controls.Add(this.priceValLabel, 6, 0);
            this.ticketLayout.Controls.Add(this.priceValLabelAlt, 6, 1);
            this.ticketLayout.Location = new System.Drawing.Point(11, 31);
            this.ticketLayout.Name = "ticketLayout";
            this.ticketLayout.RowCount = 2;
            this.ticketLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ticketLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ticketLayout.Size = new System.Drawing.Size(681, 133);
            this.ticketLayout.TabIndex = 10;
            // 
            // promoLabelAlt
            // 
            this.promoLabelAlt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promoLabelAlt.AutoSize = true;
            this.promoLabelAlt.Location = new System.Drawing.Point(79, 73);
            this.promoLabelAlt.Margin = new System.Windows.Forms.Padding(5);
            this.promoLabelAlt.Name = "promoLabelAlt";
            this.promoLabelAlt.Size = new System.Drawing.Size(41, 52);
            this.promoLabelAlt.TabIndex = 5;
            this.promoLabelAlt.Text = "Акция:";
            this.promoLabelAlt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costValLabel
            // 
            this.costValLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costValLabel.AutoSize = true;
            this.costValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costValLabel.Location = new System.Drawing.Point(547, 8);
            this.costValLabel.Margin = new System.Windows.Forms.Padding(5);
            this.costValLabel.Name = "costValLabel";
            this.costValLabel.Size = new System.Drawing.Size(126, 52);
            this.costValLabel.TabIndex = 10;
            this.costValLabel.Text = "0,00";
            this.costValLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // promoComboBoxAlt
            // 
            this.promoComboBoxAlt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.promoComboBoxAlt.FormattingEnabled = true;
            this.promoComboBoxAlt.Location = new System.Drawing.Point(131, 88);
            this.promoComboBoxAlt.Name = "promoComboBoxAlt";
            this.promoComboBoxAlt.Size = new System.Drawing.Size(96, 21);
            this.promoComboBoxAlt.TabIndex = 4;
            this.promoComboBoxAlt.SelectedIndexChanged += new System.EventHandler(this.promoComboBoxAlt_SelectedIndexChanged);
            // 
            // quantityLabelAlt
            // 
            this.quantityLabelAlt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityLabelAlt.AutoSize = true;
            this.quantityLabelAlt.Location = new System.Drawing.Point(238, 73);
            this.quantityLabelAlt.Margin = new System.Windows.Forms.Padding(5);
            this.quantityLabelAlt.Name = "quantityLabelAlt";
            this.quantityLabelAlt.Size = new System.Drawing.Size(69, 52);
            this.quantityLabelAlt.TabIndex = 6;
            this.quantityLabelAlt.Text = "Количество:";
            this.quantityLabelAlt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityUpDownAlt
            // 
            this.quantityUpDownAlt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityUpDownAlt.AutoSize = true;
            this.quantityUpDownAlt.Location = new System.Drawing.Point(318, 89);
            this.quantityUpDownAlt.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.quantityUpDownAlt.Name = "quantityUpDownAlt";
            this.quantityUpDownAlt.Size = new System.Drawing.Size(57, 20);
            this.quantityUpDownAlt.TabIndex = 7;
            this.quantityUpDownAlt.ValueChanged += new System.EventHandler(this.quantityUpDownAlt_ValueChanged);
            // 
            // costValLabelAlt
            // 
            this.costValLabelAlt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costValLabelAlt.AutoSize = true;
            this.costValLabelAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costValLabelAlt.Location = new System.Drawing.Point(547, 73);
            this.costValLabelAlt.Margin = new System.Windows.Forms.Padding(5);
            this.costValLabelAlt.Name = "costValLabelAlt";
            this.costValLabelAlt.Size = new System.Drawing.Size(126, 52);
            this.costValLabelAlt.TabIndex = 10;
            this.costValLabelAlt.Text = "0,00";
            this.costValLabelAlt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costLabelAlt
            // 
            this.costLabelAlt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costLabelAlt.AutoSize = true;
            this.costLabelAlt.Location = new System.Drawing.Point(501, 73);
            this.costLabelAlt.Margin = new System.Windows.Forms.Padding(5);
            this.costLabelAlt.Name = "costLabelAlt";
            this.costLabelAlt.Size = new System.Drawing.Size(33, 52);
            this.costLabelAlt.TabIndex = 8;
            this.costLabelAlt.Text = "Цена";
            this.costLabelAlt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(386, 8);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(5);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(57, 52);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Цена за 1";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLabelAlt
            // 
            this.priceLabelAlt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabelAlt.AutoSize = true;
            this.priceLabelAlt.Location = new System.Drawing.Point(386, 73);
            this.priceLabelAlt.Margin = new System.Windows.Forms.Padding(5);
            this.priceLabelAlt.Name = "priceLabelAlt";
            this.priceLabelAlt.Size = new System.Drawing.Size(57, 52);
            this.priceLabelAlt.TabIndex = 8;
            this.priceLabelAlt.Text = "Цена за 1";
            this.priceLabelAlt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceValLabel
            // 
            this.priceValLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceValLabel.AutoSize = true;
            this.priceValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceValLabel.Location = new System.Drawing.Point(456, 8);
            this.priceValLabel.Margin = new System.Windows.Forms.Padding(5);
            this.priceValLabel.Name = "priceValLabel";
            this.priceValLabel.Size = new System.Drawing.Size(32, 52);
            this.priceValLabel.TabIndex = 10;
            this.priceValLabel.Text = "0,00";
            this.priceValLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceValLabelAlt
            // 
            this.priceValLabelAlt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceValLabelAlt.AutoSize = true;
            this.priceValLabelAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceValLabelAlt.Location = new System.Drawing.Point(456, 73);
            this.priceValLabelAlt.Margin = new System.Windows.Forms.Padding(5);
            this.priceValLabelAlt.Name = "priceValLabelAlt";
            this.priceValLabelAlt.Size = new System.Drawing.Size(32, 52);
            this.priceValLabelAlt.TabIndex = 10;
            this.priceValLabelAlt.Text = "0,00";
            this.priceValLabelAlt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // summaryLayout
            // 
            this.summaryLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryLayout.AutoSize = true;
            this.summaryLayout.ColumnCount = 2;
            this.summaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.summaryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.summaryLayout.Controls.Add(this.totalTicketCostLabel, 0, 0);
            this.summaryLayout.Controls.Add(this.totalTicketCostBox, 1, 0);
            this.summaryLayout.Controls.Add(this.totalCostLabel, 0, 1);
            this.summaryLayout.Controls.Add(this.totalCostValueLabel, 1, 1);
            this.summaryLayout.Location = new System.Drawing.Point(11, 170);
            this.summaryLayout.Name = "summaryLayout";
            this.summaryLayout.RowCount = 2;
            this.summaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.summaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.summaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.summaryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.summaryLayout.Size = new System.Drawing.Size(681, 124);
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
            this.totalTicketCostLabel.Size = new System.Drawing.Size(158, 17);
            this.totalTicketCostLabel.TabIndex = 0;
            this.totalTicketCostLabel.Text = "Стоимость билетов:";
            // 
            // totalTicketCostBox
            // 
            this.totalTicketCostBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalTicketCostBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalTicketCostBox.Location = new System.Drawing.Point(171, 3);
            this.totalTicketCostBox.MinimumSize = new System.Drawing.Size(50, 0);
            this.totalTicketCostBox.Name = "totalTicketCostBox";
            this.totalTicketCostBox.ReadOnly = true;
            this.totalTicketCostBox.Size = new System.Drawing.Size(507, 20);
            this.totalTicketCostBox.TabIndex = 1;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalCostLabel.Location = new System.Drawing.Point(5, 32);
            this.totalCostLabel.Margin = new System.Windows.Forms.Padding(5);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(158, 87);
            this.totalCostLabel.TabIndex = 4;
            this.totalCostLabel.Text = "Итого:";
            // 
            // totalCostValueLabel
            // 
            this.totalCostValueLabel.AutoSize = true;
            this.totalCostValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalCostValueLabel.Location = new System.Drawing.Point(173, 32);
            this.totalCostValueLabel.Margin = new System.Windows.Forms.Padding(5);
            this.totalCostValueLabel.Name = "totalCostValueLabel";
            this.totalCostValueLabel.Size = new System.Drawing.Size(58, 26);
            this.totalCostValueLabel.TabIndex = 5;
            this.totalCostValueLabel.Text = "0,00";
            // 
            // submitSaleButton
            // 
            this.submitSaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitSaleButton.Location = new System.Drawing.Point(568, 309);
            this.submitSaleButton.Name = "submitSaleButton";
            this.submitSaleButton.Size = new System.Drawing.Size(124, 23);
            this.submitSaleButton.TabIndex = 14;
            this.submitSaleButton.Text = "Закончить продажу";
            this.submitSaleButton.UseVisualStyleBackColor = true;
            this.submitSaleButton.Click += new System.EventHandler(this.submitSaleButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(438, 309);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(124, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SaleForm
            // 
            this.AutoSize = true;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitSaleButton);
            this.Controls.Add(this.summaryLayout);
            this.Controls.Add(this.ticketLayout);
            this.Controls.Add(this.TicketLabel);
            this.MinimumSize = new System.Drawing.Size(700, 340);
            this.Name = "SaleForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(700, 340);
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            this.ticketLayout.ResumeLayout(false);
            this.ticketLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDownAlt)).EndInit();
            this.summaryLayout.ResumeLayout(false);
            this.summaryLayout.PerformLayout();
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
        private System.Windows.Forms.Label promoLabelAlt;
        private System.Windows.Forms.TableLayoutPanel summaryLayout;
        private System.Windows.Forms.Label totalTicketCostLabel;
        private System.Windows.Forms.TextBox totalTicketCostBox;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label totalCostValueLabel;
        private System.Windows.Forms.Button submitSaleButton;
        private System.Windows.Forms.Label costValLabel;
        private System.Windows.Forms.ComboBox promoComboBoxAlt;
        private System.Windows.Forms.Label quantityLabelAlt;
        private System.Windows.Forms.NumericUpDown quantityUpDownAlt;

        #endregion

        private System.Windows.Forms.Label costValLabelAlt;
        private System.Windows.Forms.Label costLabelAlt;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label priceLabelAlt;
        private System.Windows.Forms.Label priceValLabel;
        private System.Windows.Forms.Label priceValLabelAlt;
    }
}
