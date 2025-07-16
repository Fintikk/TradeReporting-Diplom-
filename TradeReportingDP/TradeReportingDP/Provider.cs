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
    public partial class Provider : Form
    {
        private string ConnectionString = "Data Source=FILEV\\DP_SERVER;Initial Catalog=TradeReportDP;Integrated Security=True";
        public Provider()
        {
            InitializeComponent();
        }

        private void Provider_Load(object sender, EventArgs e)
        {
            CenterToScreen(); TableLoad();
        }
        private void TableLoad()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "SELECT * FROM Providers";
                SqlCommand cmd = new SqlCommand(query, con);

                var dataAdapter = new SqlDataAdapter(query, con);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                ProviderTable.DataSource = ds.Tables[0];
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
