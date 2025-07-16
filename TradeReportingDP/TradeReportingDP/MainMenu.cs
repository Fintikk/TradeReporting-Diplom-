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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ShipmentBtn_Click(object sender, EventArgs e)
        {
            Shipment shipment = new Shipment();
            this.Hide();
            shipment.ShowDialog();
            this.Show();
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            this.Hide();
            product.ShowDialog();
            this.Show();
        }

        private void ProviderBtn_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            this.Hide();
            provider.ShowDialog(); 
            this.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
