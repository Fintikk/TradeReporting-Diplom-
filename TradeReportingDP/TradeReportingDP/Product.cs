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
    public partial class Product : Form
    {
        string IdEdit = "";
        private string ConnectionString = "Data Source=FILEV\\DP_SERVER;Initial Catalog=TradeReportDP;Integrated Security=True";
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            TableLoad(); CenterToScreen();
        }
        private void TableLoad() 
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "SELECT * FROM Product";
                SqlCommand cmd = new SqlCommand(query, con);

                var dataAdapter = new SqlDataAdapter(query, con);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                ProductTable.DataSource = ds.Tables[0];
            }
        }
        private void IdReader()
        {
            //SELECT IDENT_CURRENT('Моя таблица')
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "SELECT IDENT_CURRENT Product";
                SqlCommand cmd = new SqlCommand(query, con);

                var dataAdapter = new SqlDataAdapter(query, con);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))//Сохранение 
            {
                con.Open();
                string query = $"INSERT INTO Product (Name, PricePurchase, PriceSale, Type) VALUES (@Name,@PricePurchase,@PriceSale,@Type)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = NameBox.Text;
                    cmd.Parameters.Add("@PricePurchase", SqlDbType.Int, 50).Value = PricePurchaseBox.Text;
                    cmd.Parameters.Add("@PriceSale", SqlDbType.Int, 50).Value = PriceSaleBox.Text;
                    cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = TypeBox.Text;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
