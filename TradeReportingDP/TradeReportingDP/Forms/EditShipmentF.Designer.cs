namespace TradeReportingDP
{
    partial class EditShipmentF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditShipmentF));
            this.SaleDateDP = new System.Windows.Forms.DateTimePicker();
            this.TradeDateDP = new System.Windows.Forms.DateTimePicker();
            this.AmmountBox = new System.Windows.Forms.NumericUpDown();
            this.ProductBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProviderNameLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductNameLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NoteBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ProductPriceLb = new System.Windows.Forms.Label();
            this.ProductPricePurchaseLb = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ProductTypeLb = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ProviderTelLb = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.IdLb = new System.Windows.Forms.Label();
            this.NewShipmentBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductError = new System.Windows.Forms.Label();
            this.NumBox = new System.Windows.Forms.TextBox();
            this.NumError = new System.Windows.Forms.Label();
            this.DateSaleCheck = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MassangeBox = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.UNameBox = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ProductsLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.AmmountBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaleDateDP
            // 
            this.SaleDateDP.Enabled = false;
            this.SaleDateDP.Location = new System.Drawing.Point(124, 80);
            this.SaleDateDP.Name = "SaleDateDP";
            this.SaleDateDP.Size = new System.Drawing.Size(200, 20);
            this.SaleDateDP.TabIndex = 4;
            this.SaleDateDP.ValueChanged += new System.EventHandler(this.SaleDateDP_ValueChanged);
            // 
            // TradeDateDP
            // 
            this.TradeDateDP.Location = new System.Drawing.Point(124, 56);
            this.TradeDateDP.Name = "TradeDateDP";
            this.TradeDateDP.Size = new System.Drawing.Size(200, 20);
            this.TradeDateDP.TabIndex = 3;
            this.TradeDateDP.ValueChanged += new System.EventHandler(this.TradeDateDP_ValueChanged);
            // 
            // AmmountBox
            // 
            this.AmmountBox.Location = new System.Drawing.Point(124, 105);
            this.AmmountBox.Name = "AmmountBox";
            this.AmmountBox.Size = new System.Drawing.Size(120, 20);
            this.AmmountBox.TabIndex = 6;
            this.AmmountBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmmountBox.ValueChanged += new System.EventHandler(this.AmmountBox_ValueChanged);
            // 
            // ProductBox
            // 
            this.ProductBox.FormattingEnabled = true;
            this.ProductBox.ItemHeight = 13;
            this.ProductBox.Location = new System.Drawing.Point(124, 26);
            this.ProductBox.Name = "ProductBox";
            this.ProductBox.Size = new System.Drawing.Size(141, 21);
            this.ProductBox.TabIndex = 2;
            this.ProductBox.SelectedIndexChanged += new System.EventHandler(this.ProductBox_SelectedIndexChanged);
            this.ProductBox.TextChanged += new System.EventHandler(this.ProductBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 109;
            this.label1.Text = "Информация о поставщике";
            // 
            // ProviderNameLb
            // 
            this.ProviderNameLb.AutoSize = true;
            this.ProviderNameLb.Location = new System.Drawing.Point(2, 164);
            this.ProviderNameLb.Name = "ProviderNameLb";
            this.ProviderNameLb.Size = new System.Drawing.Size(74, 13);
            this.ProviderNameLb.TabIndex = 110;
            this.ProviderNameLb.Text = "ProviderName";
            this.ProviderNameLb.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 111;
            this.label2.Text = "Информация о продукте";
            // 
            // ProductNameLb
            // 
            this.ProductNameLb.AutoSize = true;
            this.ProductNameLb.Location = new System.Drawing.Point(3, 20);
            this.ProductNameLb.Name = "ProductNameLb";
            this.ProductNameLb.Size = new System.Drawing.Size(72, 13);
            this.ProductNameLb.TabIndex = 112;
            this.ProductNameLb.Text = "ProductName";
            this.ProductNameLb.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Продукт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 114;
            this.label4.Text = "Дата поставки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "Дата реализации";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 116;
            this.label6.Text = "Колличество";
            // 
            // NoteBox
            // 
            this.NoteBox.Location = new System.Drawing.Point(124, 131);
            this.NoteBox.Multiline = true;
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Size = new System.Drawing.Size(200, 140);
            this.NoteBox.TabIndex = 7;
            this.NoteBox.TextChanged += new System.EventHandler(this.NoteBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Примечание";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.MistyRose;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(124, 277);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(71, 23);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Visible = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Honeydew;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(253, 277);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(71, 23);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Добавить";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 121;
            this.label8.Text = "Цена покупки";
            // 
            // ProductPriceLb
            // 
            this.ProductPriceLb.AutoSize = true;
            this.ProductPriceLb.Location = new System.Drawing.Point(3, 52);
            this.ProductPriceLb.Name = "ProductPriceLb";
            this.ProductPriceLb.Size = new System.Drawing.Size(113, 13);
            this.ProductPriceLb.TabIndex = 122;
            this.ProductPriceLb.Text = "ProductPricePurchase";
            this.ProductPriceLb.Visible = false;
            // 
            // ProductPricePurchaseLb
            // 
            this.ProductPricePurchaseLb.AutoSize = true;
            this.ProductPricePurchaseLb.Location = new System.Drawing.Point(3, 85);
            this.ProductPricePurchaseLb.Name = "ProductPricePurchaseLb";
            this.ProductPricePurchaseLb.Size = new System.Drawing.Size(89, 13);
            this.ProductPricePurchaseLb.TabIndex = 124;
            this.ProductPricePurchaseLb.Text = "ProductPriceSale";
            this.ProductPricePurchaseLb.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 123;
            this.label10.Text = "Цена продажи";
            // 
            // ProductTypeLb
            // 
            this.ProductTypeLb.AutoSize = true;
            this.ProductTypeLb.Location = new System.Drawing.Point(3, 113);
            this.ProductTypeLb.Name = "ProductTypeLb";
            this.ProductTypeLb.Size = new System.Drawing.Size(68, 13);
            this.ProductTypeLb.TabIndex = 126;
            this.ProductTypeLb.Text = "ProductType";
            this.ProductTypeLb.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 125;
            this.label11.Text = "Тип товара";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 127;
            this.label12.Text = "Телефон:";
            // 
            // ProviderTelLb
            // 
            this.ProviderTelLb.AutoSize = true;
            this.ProviderTelLb.Location = new System.Drawing.Point(2, 191);
            this.ProviderTelLb.Name = "ProviderTelLb";
            this.ProviderTelLb.Size = new System.Drawing.Size(61, 13);
            this.ProviderTelLb.TabIndex = 128;
            this.ProviderTelLb.Text = "ProviderTel";
            this.ProviderTelLb.Visible = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(12, 277);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(71, 23);
            this.BackBtn.TabIndex = 11;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // IdLb
            // 
            this.IdLb.AutoSize = true;
            this.IdLb.Location = new System.Drawing.Point(27, 4);
            this.IdLb.Name = "IdLb";
            this.IdLb.Size = new System.Drawing.Size(91, 13);
            this.IdLb.TabIndex = 130;
            this.IdLb.Text = "Номер поставки";
            // 
            // NewShipmentBtn
            // 
            this.NewShipmentBtn.BackColor = System.Drawing.Color.Beige;
            this.NewShipmentBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewShipmentBtn.Location = new System.Drawing.Point(12, 160);
            this.NewShipmentBtn.Name = "NewShipmentBtn";
            this.NewShipmentBtn.Size = new System.Drawing.Size(106, 46);
            this.NewShipmentBtn.TabIndex = 10;
            this.NewShipmentBtn.Text = "Добавить новую поставку";
            this.NewShipmentBtn.UseVisualStyleBackColor = false;
            this.NewShipmentBtn.Click += new System.EventHandler(this.NewShipmentBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ProviderTelLb);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.ProductTypeLb);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.ProductPricePurchaseLb);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.ProductPriceLb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ProductNameLb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ProviderNameLb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(371, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 214);
            this.panel1.TabIndex = 134;
            // 
            // ProductError
            // 
            this.ProductError.AutoSize = true;
            this.ProductError.BackColor = System.Drawing.SystemColors.Control;
            this.ProductError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductError.ForeColor = System.Drawing.Color.Brown;
            this.ProductError.Location = new System.Drawing.Point(59, 25);
            this.ProductError.Name = "ProductError";
            this.ProductError.Size = new System.Drawing.Size(13, 16);
            this.ProductError.TabIndex = 135;
            this.ProductError.Text = "*";
            this.ProductError.Visible = false;
            // 
            // NumBox
            // 
            this.NumBox.Location = new System.Drawing.Point(124, 3);
            this.NumBox.Name = "NumBox";
            this.NumBox.Size = new System.Drawing.Size(100, 20);
            this.NumBox.TabIndex = 1;
            this.NumBox.TextChanged += new System.EventHandler(this.NumBox_TextChanged);
            // 
            // NumError
            // 
            this.NumError.AutoSize = true;
            this.NumError.BackColor = System.Drawing.SystemColors.Control;
            this.NumError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumError.ForeColor = System.Drawing.Color.Brown;
            this.NumError.Location = new System.Drawing.Point(16, 1);
            this.NumError.Name = "NumError";
            this.NumError.Size = new System.Drawing.Size(13, 16);
            this.NumError.TabIndex = 137;
            this.NumError.Text = "*";
            this.NumError.Visible = false;
            // 
            // DateSaleCheck
            // 
            this.DateSaleCheck.AutoSize = true;
            this.DateSaleCheck.Location = new System.Drawing.Point(326, 83);
            this.DateSaleCheck.Name = "DateSaleCheck";
            this.DateSaleCheck.Size = new System.Drawing.Size(15, 14);
            this.DateSaleCheck.TabIndex = 5;
            this.DateSaleCheck.UseVisualStyleBackColor = true;
            this.DateSaleCheck.CheckedChanged += new System.EventHandler(this.DateSaleCheck_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MassangeBox,
            this.toolStripStatusLabel1,
            this.UNameBox});
            this.statusStrip1.Location = new System.Drawing.Point(0, 302);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(552, 22);
            this.statusStrip1.TabIndex = 139;
            this.statusStrip1.Text = "statusStrip1";
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
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(424, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "                                                ";
            // 
            // UNameBox
            // 
            this.UNameBox.Name = "UNameBox";
            this.UNameBox.Size = new System.Drawing.Size(113, 17);
            this.UNameBox.Text = "Пользователь: User";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // ProductsLink
            // 
            this.ProductsLink.AutoSize = true;
            this.ProductsLink.LinkColor = System.Drawing.SystemColors.ControlText;
            this.ProductsLink.Location = new System.Drawing.Point(267, 31);
            this.ProductsLink.Name = "ProductsLink";
            this.ProductsLink.Size = new System.Drawing.Size(86, 13);
            this.ProductsLink.TabIndex = 144;
            this.ProductsLink.TabStop = true;
            this.ProductsLink.Text = "Показать всё...";
            this.ProductsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ProductsLink_LinkClicked);
            // 
            // EditShipmentF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(552, 324);
            this.Controls.Add(this.ProductsLink);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DateSaleCheck);
            this.Controls.Add(this.NumError);
            this.Controls.Add(this.NumBox);
            this.Controls.Add(this.ProductError);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NewShipmentBtn);
            this.Controls.Add(this.IdLb);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductBox);
            this.Controls.Add(this.AmmountBox);
            this.Controls.Add(this.TradeDateDP);
            this.Controls.Add(this.SaleDateDP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(568, 363);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(568, 363);
            this.Name = "EditShipmentF";
            this.Text = "\"ИП Филёв И.В.\" - Поставки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditShipmentF_FormClosing);
            this.Load += new System.EventHandler(this.EditShipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AmmountBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker SaleDateDP;
        private System.Windows.Forms.DateTimePicker TradeDateDP;
        private System.Windows.Forms.NumericUpDown AmmountBox;
        private System.Windows.Forms.ComboBox ProductBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProviderNameLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProductNameLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NoteBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ProductPriceLb;
        private System.Windows.Forms.Label ProductPricePurchaseLb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ProductTypeLb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ProviderTelLb;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label IdLb;
        private System.Windows.Forms.Button NewShipmentBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ProductError;
        private System.Windows.Forms.TextBox NumBox;
        private System.Windows.Forms.Label NumError;
        private System.Windows.Forms.CheckBox DateSaleCheck;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MassangeBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel UNameBox;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.LinkLabel ProductsLink;
    }
}