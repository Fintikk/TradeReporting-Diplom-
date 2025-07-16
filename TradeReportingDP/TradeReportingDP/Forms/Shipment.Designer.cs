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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shipment));
            this.label1 = new System.Windows.Forms.Label();
            this.FindBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductBtn = new System.Windows.Forms.Button();
            this.ProvidersBtn = new System.Windows.Forms.Button();
            this.ShipmentTable = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.TextBox();
            this.RowCountLb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpdateTableBtn = new System.Windows.Forms.PictureBox();
            this.DRBtn = new System.Windows.Forms.Button();
            this.RBtn = new System.Windows.Forms.Button();
            this.CountLb = new System.Windows.Forms.TextBox();
            this.DLBtn = new System.Windows.Forms.Button();
            this.LBtn = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.MassangeBox = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.UNameBox = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TradeDateDP = new System.Windows.Forms.DateTimePicker();
            this.SaleDateDP = new System.Windows.Forms.DateTimePicker();
            this.AddUser = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuDeleteBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentTable)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateTableBtn)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 9);
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
            "Номеру",
            "Продукту",
            "Поставщику",
            "Типу"});
            this.FindBox.Location = new System.Drawing.Point(210, 25);
            this.FindBox.Name = "FindBox";
            this.FindBox.Size = new System.Drawing.Size(82, 21);
            this.FindBox.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ProductBtn);
            this.panel1.Controls.Add(this.ProvidersBtn);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 68);
            this.panel1.TabIndex = 66;
            // 
            // ProductBtn
            // 
            this.ProductBtn.BackColor = System.Drawing.Color.White;
            this.ProductBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBtn.Location = new System.Drawing.Point(4, 33);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.Size = new System.Drawing.Size(171, 23);
            this.ProductBtn.TabIndex = 2;
            this.ProductBtn.Text = "Список продукции";
            this.ProductBtn.UseVisualStyleBackColor = false;
            this.ProductBtn.Click += new System.EventHandler(this.Product_Click);
            // 
            // ProvidersBtn
            // 
            this.ProvidersBtn.BackColor = System.Drawing.Color.White;
            this.ProvidersBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvidersBtn.Location = new System.Drawing.Point(4, 5);
            this.ProvidersBtn.Name = "ProvidersBtn";
            this.ProvidersBtn.Size = new System.Drawing.Size(171, 25);
            this.ProvidersBtn.TabIndex = 1;
            this.ProvidersBtn.Text = "Поставщики";
            this.ProvidersBtn.UseVisualStyleBackColor = false;
            this.ProvidersBtn.Click += new System.EventHandler(this.ProdidersBtn_Click);
            // 
            // ShipmentTable
            // 
            this.ShipmentTable.AllowUserToDeleteRows = false;
            this.ShipmentTable.AllowUserToResizeRows = false;
            this.ShipmentTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShipmentTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShipmentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShipmentTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.ShipmentTable.GridColor = System.Drawing.Color.Black;
            this.ShipmentTable.Location = new System.Drawing.Point(7, 78);
            this.ShipmentTable.Name = "ShipmentTable";
            this.ShipmentTable.ReadOnly = true;
            this.ShipmentTable.Size = new System.Drawing.Size(895, 304);
            this.ShipmentTable.TabIndex = 76;
            this.ShipmentTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShipmentTable_CellContentClick);
            this.ShipmentTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShipmentTable_CellDoubleClick);
            this.ShipmentTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ShipmentTable_CellMouseClick);
            this.ShipmentTable.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.ShipmentTable_RowPrePaint);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.BackColor = System.Drawing.Color.Honeydew;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(790, 4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(100, 23);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Добавить";
            this.toolTip.SetToolTip(this.AddBtn, "Добавить запись поставки");
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(3, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(71, 23);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "Выход";
            this.toolTip.SetToolTip(this.BackBtn, "Выход из приложения");
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(210, 54);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(100, 20);
            this.Find.TabIndex = 9;
            this.Find.TextChanged += new System.EventHandler(this.Find_TextChanged);
            // 
            // RowCountLb
            // 
            this.RowCountLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RowCountLb.AutoSize = true;
            this.RowCountLb.Location = new System.Drawing.Point(818, 60);
            this.RowCountLb.Name = "RowCountLb";
            this.RowCountLb.Size = new System.Drawing.Size(70, 13);
            this.RowCountLb.TabIndex = 85;
            this.RowCountLb.Text = "Записей 0/0";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.UpdateTableBtn);
            this.panel2.Controls.Add(this.DRBtn);
            this.panel2.Controls.Add(this.RBtn);
            this.panel2.Controls.Add(this.CountLb);
            this.panel2.Controls.Add(this.DLBtn);
            this.panel2.Controls.Add(this.BackBtn);
            this.panel2.Controls.Add(this.LBtn);
            this.panel2.Controls.Add(this.AddBtn);
            this.panel2.Location = new System.Drawing.Point(7, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 30);
            this.panel2.TabIndex = 86;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // UpdateTableBtn
            // 
            this.UpdateTableBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpdateTableBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateTableBtn.Image = global::TradeReportingDP.Properties.Resources.Reload;
            this.UpdateTableBtn.Location = new System.Drawing.Point(80, 5);
            this.UpdateTableBtn.Name = "UpdateTableBtn";
            this.UpdateTableBtn.Size = new System.Drawing.Size(20, 20);
            this.UpdateTableBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UpdateTableBtn.TabIndex = 13;
            this.UpdateTableBtn.TabStop = false;
            this.toolTip.SetToolTip(this.UpdateTableBtn, "Обновить таблицу");
            this.UpdateTableBtn.Click += new System.EventHandler(this.UpdateTableBtn_Click);
            // 
            // DRBtn
            // 
            this.DRBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DRBtn.Location = new System.Drawing.Point(559, 4);
            this.DRBtn.Name = "DRBtn";
            this.DRBtn.Size = new System.Drawing.Size(36, 22);
            this.DRBtn.TabIndex = 6;
            this.DRBtn.Text = ">>";
            this.toolTip.SetToolTip(this.DRBtn, "Последняя страница");
            this.DRBtn.UseVisualStyleBackColor = true;
            this.DRBtn.Click += new System.EventHandler(this.DRBtn_Click);
            // 
            // RBtn
            // 
            this.RBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RBtn.Location = new System.Drawing.Point(517, 4);
            this.RBtn.Name = "RBtn";
            this.RBtn.Size = new System.Drawing.Size(36, 22);
            this.RBtn.TabIndex = 5;
            this.RBtn.Text = ">";
            this.toolTip.SetToolTip(this.RBtn, "Следующая стараница");
            this.RBtn.UseVisualStyleBackColor = true;
            this.RBtn.Click += new System.EventHandler(this.RBtn_Click);
            // 
            // CountLb
            // 
            this.CountLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CountLb.Location = new System.Drawing.Point(451, 4);
            this.CountLb.Name = "CountLb";
            this.CountLb.ReadOnly = true;
            this.CountLb.Size = new System.Drawing.Size(60, 20);
            this.CountLb.TabIndex = 6;
            this.CountLb.TabStop = false;
            this.CountLb.Text = "1";
            this.CountLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DLBtn
            // 
            this.DLBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DLBtn.Location = new System.Drawing.Point(367, 5);
            this.DLBtn.Name = "DLBtn";
            this.DLBtn.Size = new System.Drawing.Size(36, 22);
            this.DLBtn.TabIndex = 3;
            this.DLBtn.Text = "<<";
            this.toolTip.SetToolTip(this.DLBtn, "Первая страница");
            this.DLBtn.UseVisualStyleBackColor = true;
            this.DLBtn.Click += new System.EventHandler(this.DLBtn_Click);
            // 
            // LBtn
            // 
            this.LBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBtn.Location = new System.Drawing.Point(409, 4);
            this.LBtn.Name = "LBtn";
            this.LBtn.Size = new System.Drawing.Size(36, 22);
            this.LBtn.TabIndex = 4;
            this.LBtn.Text = "<";
            this.toolTip.SetToolTip(this.LBtn, "Предыдущая страница");
            this.LBtn.UseVisualStyleBackColor = true;
            this.LBtn.Click += new System.EventHandler(this.LBtn_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MassangeBox,
            this.toolStripStatusLabel1,
            this.UNameBox});
            this.statusStrip.Location = new System.Drawing.Point(0, 423);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(912, 22);
            this.statusStrip.TabIndex = 87;
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
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(784, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "                                                ";
            // 
            // UNameBox
            // 
            this.UNameBox.Name = "UNameBox";
            this.UNameBox.Size = new System.Drawing.Size(113, 17);
            this.UNameBox.Text = "Пользователь: User";
            // 
            // TradeDateDP
            // 
            this.TradeDateDP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TradeDateDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TradeDateDP.Location = new System.Drawing.Point(488, 51);
            this.TradeDateDP.Name = "TradeDateDP";
            this.TradeDateDP.ShowCheckBox = true;
            this.TradeDateDP.Size = new System.Drawing.Size(110, 20);
            this.TradeDateDP.TabIndex = 88;
            this.TradeDateDP.ValueChanged += new System.EventHandler(this.TradeDateDP_ValueChanged);
            this.TradeDateDP.EnabledChanged += new System.EventHandler(this.TradeDateDP_ValueChanged);
            // 
            // SaleDateDP
            // 
            this.SaleDateDP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaleDateDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SaleDateDP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SaleDateDP.Location = new System.Drawing.Point(609, 51);
            this.SaleDateDP.Name = "SaleDateDP";
            this.SaleDateDP.ShowCheckBox = true;
            this.SaleDateDP.Size = new System.Drawing.Size(110, 20);
            this.SaleDateDP.TabIndex = 89;
            this.SaleDateDP.ValueChanged += new System.EventHandler(this.TradeDateDP_ValueChanged);
            this.SaleDateDP.EnabledChanged += new System.EventHandler(this.TradeDateDP_ValueChanged);
            // 
            // AddUser
            // 
            this.AddUser.BackColor = System.Drawing.Color.White;
            this.AddUser.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser.Location = new System.Drawing.Point(740, 4);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(162, 25);
            this.AddUser.TabIndex = 90;
            this.AddUser.Text = "Добавить пользователя";
            this.AddUser.UseVisualStyleBackColor = false;
            this.AddUser.Visible = false;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDeleteBtn});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(119, 26);
            // 
            // MenuDeleteBtn
            // 
            this.MenuDeleteBtn.Name = "MenuDeleteBtn";
            this.MenuDeleteBtn.Size = new System.Drawing.Size(118, 22);
            this.MenuDeleteBtn.Text = "Удалить";
            this.MenuDeleteBtn.Click += new System.EventHandler(this.MenuDeleteBtn_Click);
            // 
            // Shipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(912, 445);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.SaleDateDP);
            this.Controls.Add(this.TradeDateDP);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RowCountLb);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.ShipmentTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(928, 484);
            this.Name = "Shipment";
            this.Text = "\"ИП Филёв И.В.\" - Поставки";
            this.Load += new System.EventHandler(this.Shipment_Load);
            this.SizeChanged += new System.EventHandler(this.Shipment_SizeChanged);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateTableBtn)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FindBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ProvidersBtn;
        private System.Windows.Forms.DataGridView ShipmentTable;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ProductBtn;
        private System.Windows.Forms.TextBox Find;
        private System.Windows.Forms.Label RowCountLb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox UpdateTableBtn;
        private System.Windows.Forms.Button DRBtn;
        private System.Windows.Forms.Button RBtn;
        private System.Windows.Forms.TextBox CountLb;
        private System.Windows.Forms.Button DLBtn;
        private System.Windows.Forms.Button LBtn;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MassangeBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel UNameBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DateTimePicker TradeDateDP;
        private System.Windows.Forms.DateTimePicker SaleDateDP;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuDeleteBtn;
    }
}

