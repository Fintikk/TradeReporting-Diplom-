using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeReportingDP.Forms
{
    public partial class RegisterUsers : Form
    {
        public RegisterUsers()
        {
            InitializeComponent();

            CenterToScreen();
        }

        private void RegisterUsers_Load(object sender, EventArgs e)
        {

        }

        private void HashBtn_Click(object sender, EventArgs e)
        {
            OutBox.Text = PasswordHasher.HashPassword(InputBox.Text);
        }
    }
}
