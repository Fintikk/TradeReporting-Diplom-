using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeReportingDP
{
    public partial class Shipment : Form
    {
        private string ConnectionString = "Data Source=FILEV\\DP_SERVER;Initial Catalog=TradeReportDP;Integrated Security=True";
        public Shipment()
        {
            InitializeComponent();
        }

        private void Shipment_Load(object sender, EventArgs e)
        {
            CenterToScreen(); TableLoad();
        }
        private void TableLoad()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "SELECT * FROM SHIPMENT";
                SqlCommand cmd = new SqlCommand(query, con);

                var dataAdapter = new SqlDataAdapter(query, con);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                ShipmentTable.DataSource = ds.Tables[0];
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Product_Click(object sender, EventArgs e)
        {
            Product ProductForm = new Product();
            this.Hide();
            ProductForm.ShowDialog();
            this.Show();
        }
    }
}
