using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TradeReportingDP
{
    public partial class ShipmentViewing : Form
    {
        public int ShipmentNum; // Номер просматриваемой поставки
        public bool edit = false;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString());
        DataSet ShipmentData = null;
        public ShipmentViewing()
        {
            InitializeComponent();
            CenterToParent();
            con.Open();
        }
        private void ShipmentViewing_Load(object sender, EventArgs e)
        {
            LoadShipment();
            UNameBox.Text = $"Пользователь: {Global.UName}";
        }
        private void LoadShipment() 
        {

            string query = $"SELECT Shipment.Num, Product.Name, Shipment.TradeDate, Shipment.SaleDate, Shipment.Ammount, Shipment.Note, " +
                $"Product.PricePurchase, Product.PriceSale, Product.Type, " +
                $"Providers.Name, Providers.Tel, Providers.Email " +
                $"FROM Shipment, Product, Providers " +
                $"WHERE Shipment.Num = @Num and Shipment.Product = Product.Id and Product.Provider = Providers.Id";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@Num", SqlDbType.Int).Value = ShipmentNum;
                cmd.CommandType = CommandType.Text;

                var dataAdapter = new SqlDataAdapter(cmd);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                ShipmentData = new DataSet();
                dataAdapter.Fill(ShipmentData);

                if (ShipmentData.Tables[0].Rows.Count == 0) 
                {
                    MassangeManager.Massange(MassangeBox, "Не удалось загрузить поставку!", Color.Red);
                    notifyIcon.ShowBalloonTip(2000, "Ошибка", "Не удалось загрузить поставку!", ToolTipIcon.Error);
                }   
            }
            
            // Заполнение boxes

            NumBox.Text = ShipmentData.Tables[0].Rows[0][0].ToString();
            ProductBox.Text = ShipmentData.Tables[0].Rows[0][1].ToString();
            ProductNameLb.Text = ShipmentData.Tables[0].Rows[0][1].ToString();
            TradeDateDP.Text = Convert.ToDateTime(ShipmentData.Tables[0].Rows[0][2]).ToShortDateString().ToString();
            if (ShipmentData.Tables[0].Rows[0][3].ToString() != "")
            {
                SaleDateDP.Text = Convert.ToDateTime(ShipmentData.Tables[0].Rows[0][3]).ToShortDateString().ToString();
                DateSaleCheck.Checked = true;
            }
            else
                DateSaleCheck.Checked = false;
            AmmountBox.Text = ShipmentData.Tables[0].Rows[0][4].ToString();
            NoteBox.Text = ShipmentData.Tables[0].Rows[0][5].ToString();

            ProductPriceLb.Text = ShipmentData.Tables[0].Rows[0][6].ToString();
            ProductPricePurchaseLb.Text = ShipmentData.Tables[0].Rows[0][7].ToString();
            ProductTypeLb.Text = ShipmentData.Tables[0].Rows[0][8].ToString();

            ProviderNameLb.Text = ShipmentData.Tables[0].Rows[0][9].ToString();
            ProviderTelLb.Text = ShipmentData.Tables[0].Rows[0][10].ToString();
            ProviderEmailLb.Text = ShipmentData.Tables[0].Rows[0][11].ToString();
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            edit = true;
            Close();
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShipmentViewing_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon.Dispose();
        }
    }
}
