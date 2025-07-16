namespace TradeReportingDP.Forms
{
    partial class RegisterUsers
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
            this.HashBtn = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.OutBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HashBtn
            // 
            this.HashBtn.Location = new System.Drawing.Point(401, 88);
            this.HashBtn.Name = "HashBtn";
            this.HashBtn.Size = new System.Drawing.Size(75, 23);
            this.HashBtn.TabIndex = 0;
            this.HashBtn.Text = "hash";
            this.HashBtn.UseVisualStyleBackColor = true;
            this.HashBtn.Click += new System.EventHandler(this.HashBtn_Click);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(61, 27);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(415, 20);
            this.InputBox.TabIndex = 1;
            // 
            // OutBox
            // 
            this.OutBox.Location = new System.Drawing.Point(61, 62);
            this.OutBox.Name = "OutBox";
            this.OutBox.ReadOnly = true;
            this.OutBox.Size = new System.Drawing.Size(415, 20);
            this.OutBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Out";
            // 
            // RegisterUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 126);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutBox);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.HashBtn);
            this.Name = "RegisterUsers";
            this.Text = "RegisterUsers";
            this.Load += new System.EventHandler(this.RegisterUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HashBtn;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox OutBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}