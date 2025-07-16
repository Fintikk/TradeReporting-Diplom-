namespace TradeReportingDP
{
    partial class SelectionWindow
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
            this.SelectionTable = new System.Windows.Forms.DataGridView();
            this.BackBtn = new System.Windows.Forms.Button();
            this.FindBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProviderLb = new System.Windows.Forms.Label();
            this.ProviderBox = new System.Windows.Forms.TextBox();
            this.TypeProductLb = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.TypeProductLink = new System.Windows.Forms.LinkLabel();
            this.ProviderLinkLb = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectionTable
            // 
            this.SelectionTable.AllowUserToAddRows = false;
            this.SelectionTable.AllowUserToDeleteRows = false;
            this.SelectionTable.AllowUserToResizeRows = false;
            this.SelectionTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectionTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.SelectionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectionTable.Location = new System.Drawing.Point(22, 68);
            this.SelectionTable.Name = "SelectionTable";
            this.SelectionTable.Size = new System.Drawing.Size(286, 315);
            this.SelectionTable.TabIndex = 0;
            this.SelectionTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectionTable_CellContentClick);
            this.SelectionTable.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.SelectionTable_RowPrePaint);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(22, 389);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(62, 23);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // FindBox
            // 
            this.FindBox.Location = new System.Drawing.Point(22, 28);
            this.FindBox.Name = "FindBox";
            this.FindBox.Size = new System.Drawing.Size(123, 20);
            this.FindBox.TabIndex = 2;
            this.FindBox.TextChanged += new System.EventHandler(this.FindBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск:";
            // 
            // ProviderLb
            // 
            this.ProviderLb.AutoSize = true;
            this.ProviderLb.Location = new System.Drawing.Point(159, 7);
            this.ProviderLb.Name = "ProviderLb";
            this.ProviderLb.Size = new System.Drawing.Size(68, 13);
            this.ProviderLb.TabIndex = 10;
            this.ProviderLb.Text = "Поставщик:";
            this.ProviderLb.Visible = false;
            // 
            // ProviderBox
            // 
            this.ProviderBox.Location = new System.Drawing.Point(162, 28);
            this.ProviderBox.Name = "ProviderBox";
            this.ProviderBox.Size = new System.Drawing.Size(123, 20);
            this.ProviderBox.TabIndex = 11;
            this.ProviderBox.Visible = false;
            this.ProviderBox.TextChanged += new System.EventHandler(this.ProviderBox_TextChanged);
            // 
            // TypeProductLb
            // 
            this.TypeProductLb.AutoSize = true;
            this.TypeProductLb.Location = new System.Drawing.Point(288, 7);
            this.TypeProductLb.Name = "TypeProductLb";
            this.TypeProductLb.Size = new System.Drawing.Size(78, 13);
            this.TypeProductLb.TabIndex = 12;
            this.TypeProductLb.Text = "Тип продукта:";
            this.TypeProductLb.Visible = false;
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Location = new System.Drawing.Point(291, 28);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(131, 21);
            this.TypeBox.TabIndex = 13;
            this.TypeBox.Visible = false;
            this.TypeBox.TextChanged += new System.EventHandler(this.TypeBox_TextChanged);
            // 
            // TypeProductLink
            // 
            this.TypeProductLink.AutoSize = true;
            this.TypeProductLink.LinkColor = System.Drawing.SystemColors.ControlText;
            this.TypeProductLink.Location = new System.Drawing.Point(288, 52);
            this.TypeProductLink.Name = "TypeProductLink";
            this.TypeProductLink.Size = new System.Drawing.Size(86, 13);
            this.TypeProductLink.TabIndex = 143;
            this.TypeProductLink.TabStop = true;
            this.TypeProductLink.Text = "Показать всё...";
            this.TypeProductLink.Visible = false;
            this.TypeProductLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TypeProductLink_LinkClicked);
            // 
            // ProviderLinkLb
            // 
            this.ProviderLinkLb.AutoSize = true;
            this.ProviderLinkLb.LinkColor = System.Drawing.SystemColors.ControlText;
            this.ProviderLinkLb.Location = new System.Drawing.Point(159, 51);
            this.ProviderLinkLb.Name = "ProviderLinkLb";
            this.ProviderLinkLb.Size = new System.Drawing.Size(86, 13);
            this.ProviderLinkLb.TabIndex = 144;
            this.ProviderLinkLb.TabStop = true;
            this.ProviderLinkLb.Text = "Показать всё...";
            this.ProviderLinkLb.Visible = false;
            this.ProviderLinkLb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ProviderLinkLb_LinkClicked);
            // 
            // SelectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 424);
            this.Controls.Add(this.ProviderLinkLb);
            this.Controls.Add(this.TypeProductLink);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.TypeProductLb);
            this.Controls.Add(this.ProviderBox);
            this.Controls.Add(this.ProviderLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SelectionTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectionWindow";
            this.Text = "Выбор";
            this.Load += new System.EventHandler(this.SelectionWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectionTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SelectionTable;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox FindBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProviderLb;
        private System.Windows.Forms.TextBox ProviderBox;
        private System.Windows.Forms.Label TypeProductLb;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.LinkLabel TypeProductLink;
        private System.Windows.Forms.LinkLabel ProviderLinkLb;
    }
}