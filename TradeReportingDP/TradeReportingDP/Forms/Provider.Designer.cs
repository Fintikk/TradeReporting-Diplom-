namespace TradeReportingDP
{
    partial class Provider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Provider));
            this.ProviderTable = new System.Windows.Forms.DataGridView();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RowCountLb = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.Label();
            this.IdLb = new System.Windows.Forms.Label();
            this.NameError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.TelBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.MassangeBox = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.UNameBox = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpdateTableBtn = new System.Windows.Forms.PictureBox();
            this.DRBtn = new System.Windows.Forms.Button();
            this.RBtn = new System.Windows.Forms.Button();
            this.CountLb = new System.Windows.Forms.TextBox();
            this.DLBtn = new System.Windows.Forms.Button();
            this.LBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FindBtn = new System.Windows.Forms.Button();
            this.FindBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ProductList = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProviderTable)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateTableBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // ProviderTable
            // 
            this.ProviderTable.AllowUserToDeleteRows = false;
            this.ProviderTable.AllowUserToResizeRows = false;
            this.ProviderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProviderTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ProviderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProviderTable.Location = new System.Drawing.Point(12, 30);
            this.ProviderTable.Name = "ProviderTable";
            this.ProviderTable.ReadOnly = true;
            this.ProviderTable.RowHeadersWidth = 51;
            this.ProviderTable.Size = new System.Drawing.Size(523, 200);
            this.ProviderTable.TabIndex = 1;
            this.ProviderTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProviderTable_CellDoubleClick);
            this.ProviderTable.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.ProviderTable_RowPrePaint);
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(12, 406);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(71, 23);
            this.BackBtn.TabIndex = 15;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 106;
            this.label1.Text = "Список поставщиков";
            // 
            // RowCountLb
            // 
            this.RowCountLb.AutoSize = true;
            this.RowCountLb.Location = new System.Drawing.Point(465, 14);
            this.RowCountLb.Name = "RowCountLb";
            this.RowCountLb.Size = new System.Drawing.Size(70, 13);
            this.RowCountLb.TabIndex = 107;
            this.RowCountLb.Text = "Записей 0/0";
            // 
            // IdBox
            // 
            this.IdBox.AutoSize = true;
            this.IdBox.Location = new System.Drawing.Point(115, 266);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(16, 13);
            this.IdBox.TabIndex = 109;
            this.IdBox.Text = "Id";
            this.IdBox.Visible = false;
            // 
            // IdLb
            // 
            this.IdLb.AutoSize = true;
            this.IdLb.Location = new System.Drawing.Point(93, 266);
            this.IdLb.Name = "IdLb";
            this.IdLb.Size = new System.Drawing.Size(16, 13);
            this.IdLb.TabIndex = 108;
            this.IdLb.Text = "Id";
            this.IdLb.Visible = false;
            // 
            // NameError
            // 
            this.NameError.AutoSize = true;
            this.NameError.BackColor = System.Drawing.SystemColors.Control;
            this.NameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameError.ForeColor = System.Drawing.Color.Brown;
            this.NameError.Location = new System.Drawing.Point(296, 290);
            this.NameError.Name = "NameError";
            this.NameError.Size = new System.Drawing.Size(13, 16);
            this.NameError.TabIndex = 112;
            this.NameError.Text = "*";
            this.NameError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 111;
            this.label2.Text = "Название";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(115, 285);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(182, 20);
            this.NameBox.TabIndex = 7;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // AdressBox
            // 
            this.AdressBox.Location = new System.Drawing.Point(115, 311);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(182, 20);
            this.AdressBox.TabIndex = 8;
            // 
            // TelBox
            // 
            this.TelBox.Location = new System.Drawing.Point(115, 337);
            this.TelBox.Name = "TelBox";
            this.TelBox.Size = new System.Drawing.Size(182, 20);
            this.TelBox.TabIndex = 9;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(115, 363);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(182, 20);
            this.EmailBox.TabIndex = 10;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.MistyRose;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(115, 389);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(71, 23);
            this.DeleteBtn.TabIndex = 12;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Visible = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Honeydew;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(226, 389);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(71, 23);
            this.SaveBtn.TabIndex = 11;
            this.SaveBtn.Text = "Добавить";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.White;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(330, 3);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(100, 23);
            this.EditBtn.TabIndex = 5;
            this.EditBtn.Text = "Редактирование";
            this.toolTip.SetToolTip(this.EditBtn, "Режим редактирования");
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(431, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(86, 23);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Добавление";
            this.toolTip.SetToolTip(this.AddBtn, "Режим добавления");
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 121;
            this.label3.Text = "Адресс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 122;
            this.label4.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 123;
            this.label5.Text = "Email";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MassangeBox,
            this.toolStripStatusLabel1,
            this.UNameBox});
            this.statusStrip.Location = new System.Drawing.Point(0, 432);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(551, 22);
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
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(423, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "                                                ";
            // 
            // UNameBox
            // 
            this.UNameBox.Name = "UNameBox";
            this.UNameBox.Size = new System.Drawing.Size(113, 17);
            this.UNameBox.Text = "Пользователь: User";
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
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(12, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 30);
            this.panel2.TabIndex = 142;
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
            // DRBtn
            // 
            this.DRBtn.Location = new System.Drawing.Point(285, 3);
            this.DRBtn.Name = "DRBtn";
            this.DRBtn.Size = new System.Drawing.Size(36, 22);
            this.DRBtn.TabIndex = 4;
            this.DRBtn.Text = ">>";
            this.toolTip.SetToolTip(this.DRBtn, "Последняя страница");
            this.DRBtn.UseVisualStyleBackColor = true;
            this.DRBtn.Click += new System.EventHandler(this.DRBtn_Click);
            // 
            // RBtn
            // 
            this.RBtn.Location = new System.Drawing.Point(243, 3);
            this.RBtn.Name = "RBtn";
            this.RBtn.Size = new System.Drawing.Size(36, 22);
            this.RBtn.TabIndex = 3;
            this.RBtn.Text = ">";
            this.toolTip.SetToolTip(this.RBtn, "Следующая страница");
            this.RBtn.UseVisualStyleBackColor = true;
            this.RBtn.Click += new System.EventHandler(this.RBtn_Click);
            // 
            // CountLb
            // 
            this.CountLb.Location = new System.Drawing.Point(177, 3);
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
            this.DLBtn.Location = new System.Drawing.Point(93, 3);
            this.DLBtn.Name = "DLBtn";
            this.DLBtn.Size = new System.Drawing.Size(36, 22);
            this.DLBtn.TabIndex = 1;
            this.DLBtn.Text = "<<";
            this.toolTip.SetToolTip(this.DLBtn, "Первая страница");
            this.DLBtn.UseVisualStyleBackColor = true;
            this.DLBtn.Click += new System.EventHandler(this.DLBtn_Click);
            // 
            // LBtn
            // 
            this.LBtn.Location = new System.Drawing.Point(135, 3);
            this.LBtn.Name = "LBtn";
            this.LBtn.Size = new System.Drawing.Size(36, 22);
            this.LBtn.TabIndex = 2;
            this.LBtn.Text = "<";
            this.toolTip.SetToolTip(this.LBtn, "Предыдущая страница");
            this.LBtn.UseVisualStyleBackColor = true;
            this.LBtn.Click += new System.EventHandler(this.LBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Honeydew;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(790, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 77;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FindBtn
            // 
            this.FindBtn.Location = new System.Drawing.Point(267, 6);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(71, 23);
            this.FindBtn.TabIndex = 14;
            this.FindBtn.Text = "Найти";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // FindBox
            // 
            this.FindBox.Location = new System.Drawing.Point(161, 8);
            this.FindBox.Name = "FindBox";
            this.FindBox.Size = new System.Drawing.Size(100, 20);
            this.FindBox.TabIndex = 13;
            this.toolTip.SetToolTip(this.FindBox, "Поиск по названию");
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // ProductList
            // 
            this.ProductList.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ProductList.AllowUserToAddRows = false;
            this.ProductList.AllowUserToDeleteRows = false;
            this.ProductList.AllowUserToResizeColumns = false;
            this.ProductList.AllowUserToResizeRows = false;
            this.ProductList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductList.ColumnHeadersVisible = false;
            this.ProductList.Location = new System.Drawing.Point(313, 282);
            this.ProductList.MultiSelect = false;
            this.ProductList.Name = "ProductList";
            this.ProductList.ReadOnly = true;
            this.ProductList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductList.RowHeadersWidth = 51;
            this.ProductList.Size = new System.Drawing.Size(227, 130);
            this.ProductList.TabIndex = 145;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 144;
            this.label7.Text = "Продукция поставщика";
            // 
            // Provider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(551, 454);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FindBox);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.TelBox);
            this.Controls.Add(this.AdressBox);
            this.Controls.Add(this.NameError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.IdLb);
            this.Controls.Add(this.RowCountLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ProviderTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Provider";
            this.Text = "\"ИП Филёв И.В.\" - Поставщики";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Provider_FormClosing);
            this.Load += new System.EventHandler(this.Provider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProviderTable)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateTableBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProviderTable;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RowCountLb;
        private System.Windows.Forms.Label IdBox;
        private System.Windows.Forms.Label IdLb;
        private System.Windows.Forms.Label NameError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox AdressBox;
        private System.Windows.Forms.TextBox TelBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MassangeBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel UNameBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox UpdateTableBtn;
        private System.Windows.Forms.Button DRBtn;
        private System.Windows.Forms.Button RBtn;
        private System.Windows.Forms.TextBox CountLb;
        private System.Windows.Forms.Button DLBtn;
        private System.Windows.Forms.Button LBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.TextBox FindBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.DataGridView ProductList;
        private System.Windows.Forms.Label label7;
    }
}