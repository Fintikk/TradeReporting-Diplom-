namespace TradeReportingDP
{
    partial class Shipment
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
            this.label1 = new System.Windows.Forms.Label();
            this.FindBox = new System.Windows.Forms.ComboBox();
            this.SortPanel = new System.Windows.Forms.TabControl();
            this.SortType = new System.Windows.Forms.TabPage();
            this.RadionCollected = new System.Windows.Forms.RadioButton();
            this.RadionNotSale = new System.Windows.Forms.RadioButton();
            this.RadionSale = new System.Windows.Forms.RadioButton();
            this.RadionNone = new System.Windows.Forms.RadioButton();
            this.SortOther = new System.Windows.Forms.TabPage();
            this.LimitCheckBox = new System.Windows.Forms.CheckBox();
            this.StackItemsBox = new System.Windows.Forms.CheckBox();
            this.LimitBox = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.StorageBtn = new System.Windows.Forms.Button();
            this.FolderOpenBtn = new System.Windows.Forms.Button();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ListItems = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ShipmentTable = new System.Windows.Forms.DataGridView();
            this.MassangeOnlinePanel = new System.Windows.Forms.Panel();
            this.NotificationLb = new System.Windows.Forms.Label();
            this.PanelCashProcessing = new System.Windows.Forms.Panel();
            this.CashProcessingLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelWaitEarned = new System.Windows.Forms.Panel();
            this.WaitEarnedLb = new System.Windows.Forms.Label();
            this.Lb1 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ProductBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.RowCountLb = new System.Windows.Forms.Label();
            this.SortPanel.SuspendLayout();
            this.SortType.SuspendLayout();
            this.SortOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LimitBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentTable)).BeginInit();
            this.MassangeOnlinePanel.SuspendLayout();
            this.PanelCashProcessing.SuspendLayout();
            this.PanelWaitEarned.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Поиск по:";
            // 
            // FindBox
            // 
            this.FindBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FindBox.FormattingEnabled = true;
            this.FindBox.Items.AddRange(new object[] {
            "None",
            "Названию",
            "Классу",
            "Дате"});
            this.FindBox.Location = new System.Drawing.Point(300, 25);
            this.FindBox.Name = "FindBox";
            this.FindBox.Size = new System.Drawing.Size(82, 21);
            this.FindBox.TabIndex = 68;
            // 
            // SortPanel
            // 
            this.SortPanel.Controls.Add(this.SortType);
            this.SortPanel.Controls.Add(this.SortOther);
            this.SortPanel.Location = new System.Drawing.Point(448, 14);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.SelectedIndex = 0;
            this.SortPanel.Size = new System.Drawing.Size(201, 91);
            this.SortPanel.TabIndex = 67;
            // 
            // SortType
            // 
            this.SortType.BackColor = System.Drawing.Color.AntiqueWhite;
            this.SortType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SortType.Controls.Add(this.RadionCollected);
            this.SortType.Controls.Add(this.RadionNotSale);
            this.SortType.Controls.Add(this.RadionSale);
            this.SortType.Controls.Add(this.RadionNone);
            this.SortType.Location = new System.Drawing.Point(4, 22);
            this.SortType.Name = "SortType";
            this.SortType.Padding = new System.Windows.Forms.Padding(3);
            this.SortType.Size = new System.Drawing.Size(193, 65);
            this.SortType.TabIndex = 0;
            this.SortType.Text = "По типу";
            // 
            // RadionCollected
            // 
            this.RadionCollected.AutoSize = true;
            this.RadionCollected.Location = new System.Drawing.Point(97, 11);
            this.RadionCollected.Name = "RadionCollected";
            this.RadionCollected.Size = new System.Drawing.Size(78, 17);
            this.RadionCollected.TabIndex = 7;
            this.RadionCollected.Text = "На складе";
            this.RadionCollected.UseVisualStyleBackColor = true;
            // 
            // RadionNotSale
            // 
            this.RadionNotSale.AutoSize = true;
            this.RadionNotSale.Checked = true;
            this.RadionNotSale.Location = new System.Drawing.Point(10, 45);
            this.RadionNotSale.Name = "RadionNotSale";
            this.RadionNotSale.Size = new System.Drawing.Size(98, 17);
            this.RadionNotSale.TabIndex = 6;
            this.RadionNotSale.TabStop = true;
            this.RadionNotSale.Text = "Не проданные";
            this.RadionNotSale.UseVisualStyleBackColor = true;
            // 
            // RadionSale
            // 
            this.RadionSale.AutoSize = true;
            this.RadionSale.Location = new System.Drawing.Point(10, 26);
            this.RadionSale.Name = "RadionSale";
            this.RadionSale.Size = new System.Drawing.Size(83, 17);
            this.RadionSale.TabIndex = 5;
            this.RadionSale.Text = "Проданные";
            this.RadionSale.UseVisualStyleBackColor = true;
            // 
            // RadionNone
            // 
            this.RadionNone.AutoSize = true;
            this.RadionNone.Location = new System.Drawing.Point(10, 8);
            this.RadionNone.Name = "RadionNone";
            this.RadionNone.Size = new System.Drawing.Size(44, 17);
            this.RadionNone.TabIndex = 4;
            this.RadionNone.Text = "Все";
            this.RadionNone.UseVisualStyleBackColor = true;
            // 
            // SortOther
            // 
            this.SortOther.BackColor = System.Drawing.Color.AntiqueWhite;
            this.SortOther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SortOther.Controls.Add(this.LimitCheckBox);
            this.SortOther.Controls.Add(this.StackItemsBox);
            this.SortOther.Controls.Add(this.LimitBox);
            this.SortOther.Location = new System.Drawing.Point(4, 22);
            this.SortOther.Name = "SortOther";
            this.SortOther.Padding = new System.Windows.Forms.Padding(3);
            this.SortOther.Size = new System.Drawing.Size(193, 65);
            this.SortOther.TabIndex = 1;
            this.SortOther.Text = "Прочее";
            // 
            // LimitCheckBox
            // 
            this.LimitCheckBox.AutoSize = true;
            this.LimitCheckBox.Location = new System.Drawing.Point(6, 33);
            this.LimitCheckBox.Name = "LimitCheckBox";
            this.LimitCheckBox.Size = new System.Drawing.Size(68, 30);
            this.LimitCheckBox.TabIndex = 2;
            this.LimitCheckBox.Text = "Лимит \r\nзаписей";
            this.LimitCheckBox.UseVisualStyleBackColor = true;
            // 
            // StackItemsBox
            // 
            this.StackItemsBox.AutoSize = true;
            this.StackItemsBox.Location = new System.Drawing.Point(6, 6);
            this.StackItemsBox.Name = "StackItemsBox";
            this.StackItemsBox.Size = new System.Drawing.Size(88, 30);
            this.StackItemsBox.TabIndex = 1;
            this.StackItemsBox.Text = "Сложить \r\nодинаковые";
            this.StackItemsBox.UseVisualStyleBackColor = true;
            // 
            // LimitBox
            // 
            this.LimitBox.Enabled = false;
            this.LimitBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LimitBox.Location = new System.Drawing.Point(105, 40);
            this.LimitBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LimitBox.Name = "LimitBox";
            this.LimitBox.Size = new System.Drawing.Size(53, 20);
            this.LimitBox.TabIndex = 1;
            this.LimitBox.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ProductBtn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.StorageBtn);
            this.panel1.Controls.Add(this.FolderOpenBtn);
            this.panel1.Controls.Add(this.ReportBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ListItems);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 97);
            this.panel1.TabIndex = 66;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 25);
            this.button2.TabIndex = 52;
            this.button2.Text = "T";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // StorageBtn
            // 
            this.StorageBtn.BackColor = System.Drawing.Color.White;
            this.StorageBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StorageBtn.Location = new System.Drawing.Point(3, 33);
            this.StorageBtn.Name = "StorageBtn";
            this.StorageBtn.Size = new System.Drawing.Size(87, 25);
            this.StorageBtn.TabIndex = 39;
            this.StorageBtn.Text = "Склады";
            this.StorageBtn.UseVisualStyleBackColor = false;
            this.StorageBtn.Visible = false;
            // 
            // FolderOpenBtn
            // 
            this.FolderOpenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FolderOpenBtn.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.FolderOpenBtn.ForeColor = System.Drawing.Color.Navy;
            this.FolderOpenBtn.Location = new System.Drawing.Point(63, 7);
            this.FolderOpenBtn.Name = "FolderOpenBtn";
            this.FolderOpenBtn.Size = new System.Drawing.Size(27, 25);
            this.FolderOpenBtn.TabIndex = 38;
            this.FolderOpenBtn.Text = "1";
            this.FolderOpenBtn.UseVisualStyleBackColor = true;
            this.FolderOpenBtn.Visible = false;
            // 
            // ReportBtn
            // 
            this.ReportBtn.BackColor = System.Drawing.Color.White;
            this.ReportBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBtn.Location = new System.Drawing.Point(33, 62);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(57, 23);
            this.ReportBtn.TabIndex = 78;
            this.ReportBtn.Text = "Отчёт";
            this.ReportBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(96, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 25);
            this.button1.TabIndex = 37;
            this.button1.Text = "Календарь продаж";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // ListItems
            // 
            this.ListItems.BackColor = System.Drawing.Color.White;
            this.ListItems.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListItems.Location = new System.Drawing.Point(96, 6);
            this.ListItems.Name = "ListItems";
            this.ListItems.Size = new System.Drawing.Size(171, 25);
            this.ListItems.TabIndex = 33;
            this.ListItems.Text = "Поставщики";
            this.ListItems.UseVisualStyleBackColor = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Wingdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.DeleteBtn.Location = new System.Drawing.Point(3, 6);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(27, 25);
            this.DeleteBtn.TabIndex = 0;
            this.DeleteBtn.Text = "3";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Wingdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.SaveBtn.ForeColor = System.Drawing.Color.Green;
            this.SaveBtn.Location = new System.Drawing.Point(33, 6);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(27, 25);
            this.SaveBtn.TabIndex = 34;
            this.SaveBtn.Text = "3";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // ShipmentTable
            // 
            this.ShipmentTable.AllowUserToAddRows = false;
            this.ShipmentTable.AllowUserToDeleteRows = false;
            this.ShipmentTable.AllowUserToResizeColumns = false;
            this.ShipmentTable.AllowUserToResizeRows = false;
            this.ShipmentTable.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.ShipmentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShipmentTable.GridColor = System.Drawing.Color.Bisque;
            this.ShipmentTable.Location = new System.Drawing.Point(7, 106);
            this.ShipmentTable.Name = "ShipmentTable";
            this.ShipmentTable.ReadOnly = true;
            this.ShipmentTable.Size = new System.Drawing.Size(895, 383);
            this.ShipmentTable.TabIndex = 76;
            // 
            // MassangeOnlinePanel
            // 
            this.MassangeOnlinePanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.MassangeOnlinePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MassangeOnlinePanel.Controls.Add(this.NotificationLb);
            this.MassangeOnlinePanel.Location = new System.Drawing.Point(80, 495);
            this.MassangeOnlinePanel.Name = "MassangeOnlinePanel";
            this.MassangeOnlinePanel.Size = new System.Drawing.Size(195, 37);
            this.MassangeOnlinePanel.TabIndex = 81;
            // 
            // NotificationLb
            // 
            this.NotificationLb.AutoSize = true;
            this.NotificationLb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotificationLb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.NotificationLb.Location = new System.Drawing.Point(5, 4);
            this.NotificationLb.Name = "NotificationLb";
            this.NotificationLb.Size = new System.Drawing.Size(75, 13);
            this.NotificationLb.TabIndex = 46;
            this.NotificationLb.Text = "Сообщение";
            this.NotificationLb.Visible = false;
            // 
            // PanelCashProcessing
            // 
            this.PanelCashProcessing.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PanelCashProcessing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCashProcessing.Controls.Add(this.CashProcessingLb);
            this.PanelCashProcessing.Controls.Add(this.label3);
            this.PanelCashProcessing.Location = new System.Drawing.Point(278, 495);
            this.PanelCashProcessing.Name = "PanelCashProcessing";
            this.PanelCashProcessing.Size = new System.Drawing.Size(229, 37);
            this.PanelCashProcessing.TabIndex = 80;
            // 
            // CashProcessingLb
            // 
            this.CashProcessingLb.AutoSize = true;
            this.CashProcessingLb.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashProcessingLb.Location = new System.Drawing.Point(128, 11);
            this.CashProcessingLb.Name = "CashProcessingLb";
            this.CashProcessingLb.Size = new System.Drawing.Size(15, 15);
            this.CashProcessingLb.TabIndex = 43;
            this.CashProcessingLb.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Средств в обработке:";
            // 
            // PanelWaitEarned
            // 
            this.PanelWaitEarned.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PanelWaitEarned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelWaitEarned.Controls.Add(this.WaitEarnedLb);
            this.PanelWaitEarned.Controls.Add(this.Lb1);
            this.PanelWaitEarned.Location = new System.Drawing.Point(513, 495);
            this.PanelWaitEarned.Name = "PanelWaitEarned";
            this.PanelWaitEarned.Size = new System.Drawing.Size(229, 37);
            this.PanelWaitEarned.TabIndex = 79;
            // 
            // WaitEarnedLb
            // 
            this.WaitEarnedLb.AutoSize = true;
            this.WaitEarnedLb.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WaitEarnedLb.Location = new System.Drawing.Point(120, 11);
            this.WaitEarnedLb.Name = "WaitEarnedLb";
            this.WaitEarnedLb.Size = new System.Drawing.Size(15, 15);
            this.WaitEarnedLb.TabIndex = 43;
            this.WaitEarnedLb.Text = "0";
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Location = new System.Drawing.Point(2, 10);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(117, 13);
            this.Lb1.TabIndex = 42;
            this.Lb1.Text = "Ожидаемая прибыль:";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.White;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(802, 495);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(100, 23);
            this.AddBtn.TabIndex = 77;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(7, 496);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(71, 23);
            this.BackBtn.TabIndex = 82;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ProductBtn
            // 
            this.ProductBtn.BackColor = System.Drawing.Color.White;
            this.ProductBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBtn.Location = new System.Drawing.Point(96, 34);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.Size = new System.Drawing.Size(171, 23);
            this.ProductBtn.TabIndex = 83;
            this.ProductBtn.Text = "Список продуктов";
            this.ProductBtn.UseVisualStyleBackColor = false;
            this.ProductBtn.Click += new System.EventHandler(this.Product_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 83;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 84;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // RowCountLb
            // 
            this.RowCountLb.AutoSize = true;
            this.RowCountLb.Location = new System.Drawing.Point(760, 88);
            this.RowCountLb.Name = "RowCountLb";
            this.RowCountLb.Size = new System.Drawing.Size(82, 13);
            this.RowCountLb.TabIndex = 85;
            this.RowCountLb.Text = "Записей 30/30";
            // 
            // Shipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(912, 545);
            this.Controls.Add(this.RowCountLb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.MassangeOnlinePanel);
            this.Controls.Add(this.PanelCashProcessing);
            this.Controls.Add(this.PanelWaitEarned);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ShipmentTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindBox);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Shipment";
            this.Text = "\"ИП Филёв И.В.\" - Поставки";
            this.Load += new System.EventHandler(this.Shipment_Load);
            this.SortPanel.ResumeLayout(false);
            this.SortType.ResumeLayout(false);
            this.SortType.PerformLayout();
            this.SortOther.ResumeLayout(false);
            this.SortOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LimitBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentTable)).EndInit();
            this.MassangeOnlinePanel.ResumeLayout(false);
            this.MassangeOnlinePanel.PerformLayout();
            this.PanelCashProcessing.ResumeLayout(false);
            this.PanelCashProcessing.PerformLayout();
            this.PanelWaitEarned.ResumeLayout(false);
            this.PanelWaitEarned.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FindBox;
        private System.Windows.Forms.TabControl SortPanel;
        private System.Windows.Forms.TabPage SortType;
        private System.Windows.Forms.RadioButton RadionCollected;
        private System.Windows.Forms.RadioButton RadionNotSale;
        private System.Windows.Forms.RadioButton RadionSale;
        private System.Windows.Forms.RadioButton RadionNone;
        private System.Windows.Forms.TabPage SortOther;
        private System.Windows.Forms.CheckBox LimitCheckBox;
        private System.Windows.Forms.CheckBox StackItemsBox;
        private System.Windows.Forms.NumericUpDown LimitBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button StorageBtn;
        private System.Windows.Forms.Button FolderOpenBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ListItems;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DataGridView ShipmentTable;
        private System.Windows.Forms.Panel MassangeOnlinePanel;
        private System.Windows.Forms.Label NotificationLb;
        private System.Windows.Forms.Panel PanelCashProcessing;
        private System.Windows.Forms.Label CashProcessingLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelWaitEarned;
        private System.Windows.Forms.Label WaitEarnedLb;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Button ReportBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ProductBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label RowCountLb;
    }
}

