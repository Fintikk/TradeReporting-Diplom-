using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeReportingDP
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void ReadyBtn_Click(object sender, EventArgs e)
        {
            Auth();
        }
        private void Auth()
        {
            if (LoginBox.Text == "Admin" && PasswordBox.Text == "123")
            {
                MainMenu mainMenu = new MainMenu();
                this.Hide();
                mainMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MassangeManager.Massange(MassengeLb, "Неверные данные", Color.Red);
            }
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                ReadyBtn.Focus();
                Auth(); 
            }

        }

        private void LoginBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PasswordBox.Focus();
            }
        }

        private void Authentication_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
