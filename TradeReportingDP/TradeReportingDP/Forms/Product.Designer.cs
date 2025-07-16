namespace TradeReportingDP
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.ProductTable = new System.Windows.Forms.DataGridView();
            this.BackBtn = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PricePurchaseBox = new System.Windows.Forms.TextBox();
            this.PriceSaleBox = new System.Windows.Forms.TextBox();
            this.IdLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.IdBox = new System.Windows.Forms.Label();
            this.RowCountLb = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.NameError = new System.Windows.Forms.Label();
            this.PricePurchaseError = new System.Windows.Forms.Label();
            this.PriceSaleError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProviderBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.MassangeBox = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.UNameBox = new System.Windows.Forms.ToolStripStatusLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.LBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DLBtn = new System.Windows.Forms.Button();
            this.CountLb = new System.Windows.Forms.TextBox();
            this.RBtn = new System.Windows.Forms.Button();
            this.DRBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpdateTableBtn = new System.Windows.Forms.PictureBox();
            this.FindBox = new System.Windows.Forms.TextBox();
            this.FindBtn = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TypeProductLink = new System.Windows.Forms.LinkLabel();
            this.ProvidersLink = new System.Windows.Forms.LinkLabel();
            this.ProviderError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductTable)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateTableBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductTable
            // 
            this.ProductTable.AllowUserToDeleteRows = false;
            this.ProductTable.AllowUserToResizeRows = false;
            this.ProductTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ProductTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductTable.Location = new System.Drawing.Point(12, 30);
            this.ProductTable.Name = "ProductTable";
            this.ProductTable.ReadOnly = true;
            this.ProductTable.RowHeadersWidth = 51;
            this.ProductTable.Size = new System.Drawing.Size(653, 200);
            this.ProductTable.TabIndex = 0;
            this.ProductTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductTable_CellDoubleClick);
            this.ProductTable.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.ProductTable_RowPrePaint);
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(16, 419);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(71, 23);
            this.BackBtn.TabIndex = 16;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(210, 287);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(182, 20);
            this.NameBox.TabIndex = 7;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // PricePurchaseBox
            // 
            this.PricePurchaseBox.Location = new System.Drawing.Point(210, 313);
            this.PricePurchaseBox.Name = "PricePurchaseBox";
            this.PricePurchaseBox.Size = new System.Drawing.Size(182, 20);
            this.PricePurchaseBox.TabIndex = 8;
            this.PricePurchaseBox.Text = "0";
            this.PricePurchaseBox.TextChanged += new System.EventHandler(this.PricePurchaseBox_TextChanged);
            // 
            // PriceSaleBox
            // 
            this.PriceSaleBox.Location = new System.Drawing.Point(210, 339);
            this.PriceSaleBox.Name = "PriceSaleBox";
            this.PriceSaleBox.Size = new System.Drawing.Size(182, 20);
            this.PriceSaleBox.TabIndex = 9;
            this.PriceSaleBox.Text = "0";
            this.PriceSaleBox.TextChanged += new System.EventHandler(this.PriceSaleBox_TextChanged);
            // 
            // IdLb
            // 
            this.IdLb.AutoSize = true;
            this.IdLb.Location = new System.Drawing.Point(188, 264);
            this.IdLb.Name = "IdLb";
            this.IdLb.Size = new System.Drawing.Size(16, 13);
            this.IdLb.TabIndex = 89;
            this.IdLb.Text = "Id";
            this.IdLb.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 92;
            this.label4.Text = "Цена продажи";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 93;
            this.label5.Text = "Тип товара";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Honeydew;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(321, 419);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(71, 23);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.Text = "Добавить";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.MistyRose;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(210, 419);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(71, 23);
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Visible = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // IdBox
            // 
            this.IdBox.AutoSize = true;
            this.IdBox.Location = new System.Drawing.Point(210, 264);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(16, 13);
            this.IdBox.TabIndex = 98;
            this.IdBox.Text = "Id";
            this.IdBox.Visible = false;
            // 
            // RowCountLb
            // 
            this.RowCountLb.AutoSize = true;
            this.RowCountLb.Location = new System.Drawing.Point(591, 10);
            this.RowCountLb.Name = "RowCountLb";
            this.RowCountLb.Size = new System.Drawing.Size(70, 13);
            this.RowCountLb.TabIndex = 100;
            this.RowCountLb.Text = "Записей 0/0";
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Location = new System.Drawing.Point(210, 365);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(182, 21);
            this.TypeBox.TabIndex = 10;
            // 
            // NameError
            // 
            this.NameError.AutoSize = true;
            this.NameError.BackColor = System.Drawing.SystemColors.Control;
            this.NameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameError.ForeColor = System.Drawing.Color.Brown;
            this.NameError.Location = new System.Drawing.Point(391, 292);
            this.NameError.Name = "NameError";
            this.NameError.Size = new System.Drawing.Size(13, 16);
            this.NameError.TabIndex = 102;
            this.NameError.Text = "*";
            this.NameError.Visible = false;
            // 
            // PricePurchaseError
            // 
            this.PricePurchaseError.AutoSize = true;
            this.PricePurchaseError.BackColor = System.Drawing.SystemColors.Control;
            this.PricePurchaseError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PricePurchaseError.ForeColor = System.Drawing.Color.Brown;
            this.PricePurchaseError.Location = new System.Drawing.Point(391, 317);
            this.PricePurchaseError.Name = "PricePurchaseError";
            this.PricePurchaseError.Size = new System.Drawing.Size(13, 16);
            this.PricePurchaseError.TabIndex = 103;
            this.PricePurchaseError.Text = "*";
            this.PricePurchaseError.Visible = false;
            // 
            // PriceSaleError
            // 
            this.PriceSaleError.AutoSize = true;
            this.PriceSaleError.BackColor = System.Drawing.SystemColors.Control;
            this.PriceSaleError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceSaleError.ForeColor = System.Drawing.Color.Brown;
            this.PriceSaleError.Location = new System.Drawing.Point(391, 344);
            this.PriceSaleError.Name = "PriceSaleError";
            this.PriceSaleError.Size = new System.Drawing.Size(13, 16);
            this.PriceSaleError.TabIndex = 104;
            this.PriceSaleError.Text = "*";
            this.PriceSaleError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 105;
            this.label1.Text = "Список продукции";
            // 
            // ProviderBox
            // 
            this.ProviderBox.FormattingEnabled = true;
            this.ProviderBox.Location = new System.Drawing.Point(210, 392);
            this.ProviderBox.Name = "ProviderBox";
            this.ProviderBox.Size = new System.Drawing.Size(182, 21);
            this.ProviderBox.TabIndex = 11;
            this.ProviderBox.TextChanged += new System.EventHandler(this.ProviderBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 108;
            this.label6.Text = "Поставщик";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MassangeBox,
            this.toolStripStatusLabel1,
            this.UNameBox});
            this.statusStrip.Location = new System.Drawing.Point(0, 447);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(681, 22);
            this.statusStrip.TabIndex = 140;
            this.statusStrip.Text = "statusStrip1";
            // 
            // MassangeBox
            // 
            this.MassangeBox.Name = "MassangeBox";
            this.MassangeBox.Size = new System.Drawing.Size(76, 17);
            this.MassangeBox.Text = "Сообщение:";
            this.MassangeBox.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(553, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "                                                ";
            // 
            // UNameBox
            // 
            this.UNameBox.Name = "UNameBox";
            this.UNameBox.Size = new System.Drawing.Size(113, 17);
            this.UNameBox.Text = "Пользователь: User";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Honeydew;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(790, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 77;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // LBtn
            // 
            this.LBtn.Location = new System.Drawing.Point(226, 3);
            this.LBtn.Name = "LBtn";
            this.LBtn.Size = new System.Drawing.Size(36, 22);
            this.LBtn.TabIndex = 2;
            this.LBtn.Text = "<";
            this.toolTip.SetToolTip(this.LBtn, "Предыдущая страница");
            this.LBtn.UseVisualStyleBackColor = true;
            this.LBtn.Click += new System.EventHandler(this.LBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.White;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(459, 2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(102, 23);
            this.EditBtn.TabIndex = 95;
            this.EditBtn.Text = "Редактирование";
            this.toolTip.SetToolTip(this.EditBtn, "Режим редактирования");
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(563, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(85, 23);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Добавление";
            this.toolTip.SetToolTip(this.AddBtn, "Режим добавления");
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DLBtn
            // 
            this.DLBtn.Location = new System.Drawing.Point(184, 4);
            this.DLBtn.Name = "DLBtn";
            this.DLBtn.Size = new System.Drawing.Size(36, 22);
            this.DLBtn.TabIndex = 1;
            this.DLBtn.Text = "<<";
            this.toolTip.SetToolTip(this.DLBtn, "Первая страница");
            this.DLBtn.UseVisualStyleBackColor = true;
            this.DLBtn.Click += new System.EventHandler(this.DLBtn_Click);
            // 
            // CountLb
            // 
            this.CountLb.Location = new System.Drawing.Point(268, 3);
            this.CountLb.Name = "CountLb";
            this.CountLb.ReadOnly = true;
            this.CountLb.Size = new System.Drawing.Size(60, 20);
            this.CountLb.TabIndex = 6;
            this.CountLb.TabStop = false;
            this.CountLb.Text = "1";
            this.CountLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RBtn
            // 
            this.RBtn.Location = new System.Drawing.Point(334, 3);
            this.RBtn.Name = "RBtn";
            this.RBtn.Size = new System.Drawing.Size(36, 22);
            this.RBtn.TabIndex = 3;
            this.RBtn.Text = ">";
            this.toolTip.SetToolTip(this.RBtn, "Следующая страница");
            this.RBtn.UseVisualStyleBackColor = true;
            this.RBtn.Click += new System.EventHandler(this.RBtn_Click);
            // 
            // DRBtn
            // 
            this.DRBtn.Location = new System.Drawing.Point(376, 3);
            this.DRBtn.Name = "DRBtn";
            this.DRBtn.Size = new System.Drawing.Size(36, 22);
            this.DRBtn.TabIndex = 4;
            this.DRBtn.Text = ">>";
            this.toolTip.SetToolTip(this.DRBtn, "Последняя страница");
            this.DRBtn.UseVisualStyleBackColor = true;
            this.DRBtn.Click += new System.EventHandler(this.DRBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.UpdateTableBtn);
            this.panel2.Controls.Add(this.DRBtn);
            this.panel2.Controls.Add(this.RBtn);
            this.panel2.Controls.Add(this.CountLb);
            this.panel2.Controls.Add(this.DLBtn);
            this.panel2.Controls.Add(this.AddBtn);
            this.panel2.Controls.Add(this.EditBtn);
            this.panel2.Controls.Add(this.LBtn);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(12, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 30);
            this.panel2.TabIndex = 141;
            // 
            // UpdateTableBtn
            // 
            this.UpdateTableBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpdateTableBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateTableBtn.Image = global::TradeReportingDP.Properties.Resources.Reload;
            this.UpdateTableBtn.Location = new System.Drawing.Point(3, 4);
            this.UpdateTableBtn.Name = "UpdateTableBtn";
            this.UpdateTableBtn.Size = new System.Drawing.Size(20, 20);
            this.UpdateTableBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UpdateTableBtn.TabIndex = 13;
            this.UpdateTableBtn.TabStop = false;
            this.toolTip.SetToolTip(this.UpdateTableBtn, "Обновить таблицу");
            this.UpdateTableBtn.Click += new System.EventHandler(this.UpdateTableBtn_Click);
            // 
            // FindBox
            // 
            this.FindBox.Location = new System.Drawing.Point(147, 8);
            this.FindBox.Name = "FindBox";
            this.FindBox.Size = new System.Drawing.Size(100, 20);
            this.FindBox.TabIndex = 14;
            this.toolTip.SetToolTip(this.FindBox, "Поиск по названию");
            // 
            // FindBtn
            // 
            this.FindBtn.Location = new System.Drawing.Point(253, 6);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(71, 23);
            this.FindBtn.TabIndex = 15;
            this.FindBtn.Text = "Найти";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // TypeProductLink
            // 
            this.TypeProductLink.AutoSize = true;
            this.TypeProductLink.LinkColor = System.Drawing.SystemColors.ControlText;
            this.TypeProductLink.Location = new System.Drawing.Point(402, 368);
            this.TypeProductLink.Name = "TypeProductLink";
            this.TypeProductLink.Size = new System.Drawing.Size(86, 13);
            this.TypeProductLink.TabIndex = 142;
            this.TypeProductLink.TabStop = true;
            this.TypeProductLink.Text = "Показать всё...";
            this.TypeProductLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TypeProductLink_LinkClicked);
            // 
            // ProvidersLink
            // 
            this.ProvidersLink.AutoSize = true;
            this.ProvidersLink.LinkColor = System.Drawing.SystemColors.ControlText;
            this.ProvidersLink.Location = new System.Drawing.Point(402, 393);
            this.ProvidersLink.Name = "ProvidersLink";
            this.ProvidersLink.Size = new System.Drawing.Size(86, 13);
            this.ProvidersLink.TabIndex = 143;
            this.ProvidersLink.TabStop = true;
            this.ProvidersLink.Text = "Показать всё...";
            this.ProvidersLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ProvidersLink_LinkClicked);
            // 
            // ProviderError
            // 
            this.ProviderError.AutoSize = true;
            this.ProviderError.BackColor = System.Drawing.SystemColors.Control;
            this.ProviderError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProviderError.ForeColor = System.Drawing.Color.Brown;
            this.ProviderError.Location = new System.Drawing.Point(392, 395);
            this.ProviderError.Name = "ProviderError";
            this.ProviderError.Size = new System.Drawing.Size(13, 16);
            this.ProviderError.TabIndex = 144;
            this.ProviderError.Text = "*";
            this.ProviderError.Visible = false;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(681, 469);
            this.Controls.Add(this.ProviderError);
            this.Controls.Add(this.ProvidersLink);
            this.Controls.Add(this.TypeProductLink);
            this.Controls.Add(this.FindBox);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProviderBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceSaleError);
            this.Controls.Add(this.PricePurchaseError);
            this.Controls.Add(this.NameError);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.RowCountLb);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdLb);
            this.Controls.Add(this.PriceSaleBox);
            this.Controls.Add(this.PricePurchaseBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ProductTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(697, 508);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(697, 508);
            this.Name = "Product";
            this.Text = "\"ИП Филёв И.В.\" - Продукция";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Product_FormClosing);
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductTable)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateTableBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductTable;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PricePurchaseBox;
        private System.Windows.Forms.TextBox PriceSaleBox;
        private System.Windows.Forms.Label IdLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label IdBox;
        private System.Windows.Forms.Label RowCountLb;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.Label NameError;
        private System.Windows.Forms.Label PricePurchaseError;
        private System.Windows.Forms.Label PriceSaleError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProviderBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MassangeBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel UNameBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button LBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DLBtn;
        private System.Windows.Forms.TextBox CountLb;
        private System.Windows.Forms.Button RBtn;
        private System.Windows.Forms.Button DRBtn;
        private System.Windows.Forms.PictureBox UpdateTableBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox FindBox;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.LinkLabel TypeProductLink;
        private System.Windows.Forms.LinkLabel ProvidersLink;
        private System.Windows.Forms.Label ProviderError;
    }
}