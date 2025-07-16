namespace TradeReportingDP
{
    partial class MainMenu
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
            this.ShipmentBtn = new System.Windows.Forms.Button();
            this.ProductBtn = new System.Windows.Forms.Button();
            this.ProviderBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShipmentBtn
            // 
            this.ShipmentBtn.Location = new System.Drawing.Point(228, 89);
            this.ShipmentBtn.Name = "ShipmentBtn";
            this.ShipmentBtn.Size = new System.Drawing.Size(255, 48);
            this.ShipmentBtn.TabIndex = 0;
            this.ShipmentBtn.Text = "Поставки";
            this.ShipmentBtn.UseVisualStyleBackColor = true;
            this.ShipmentBtn.Click += new System.EventHandler(this.ShipmentBtn_Click);
            // 
            // ProductBtn
            // 
            this.ProductBtn.Location = new System.Drawing.Point(228, 143);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.Size = new System.Drawing.Size(255, 48);
            this.ProductBtn.TabIndex = 1;
            this.ProductBtn.Text = "Продукты";
            this.ProductBtn.UseVisualStyleBackColor = true;
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // ProviderBtn
            // 
            this.ProviderBtn.Location = new System.Drawing.Point(228, 197);
            this.ProviderBtn.Name = "ProviderBtn";
            this.ProviderBtn.Size = new System.Drawing.Size(255, 48);
            this.ProviderBtn.TabIndex = 2;
            this.ProviderBtn.Text = "Поставщики";
            this.ProviderBtn.UseVisualStyleBackColor = true;
            this.ProviderBtn.Click += new System.EventHandler(this.ProviderBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(12, 337);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 21);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(715, 370);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ProviderBtn);
            this.Controls.Add(this.ProductBtn);
            this.Controls.Add(this.ShipmentBtn);
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShipmentBtn;
        private System.Windows.Forms.Button ProductBtn;
        private System.Windows.Forms.Button ProviderBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}