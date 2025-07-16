using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeReportingDP
{
    public partial class EditShipmentF : Form
    {
        public bool EditMode; // true = редактирование, false = добавление
        public int ShipmentNum; // Номер изменяемой поставки
        private bool Change = false;
        DataSet ProductData = null;
        DataSet ShipmentData = null;

        public EditShipmentF()
        {
            InitializeComponent();
        }

        private void LoadProduct()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))
            {
                //загрузка названия продукта
                con.Open();
                {
                    string query = $"SELECT Id, Name FROM Product";
                    SqlCommand cmd = new SqlCommand(query, con);

                    var dataAdapter = new SqlDataAdapter(query, con);
                    ProductData = new DataSet();
                    dataAdapter.Fill(ProductData);
                    var values = new object[5];
                    
                    int i = 0;
                    foreach (DataRow row in ProductData.Tables[0].Rows)
                    {
                        values[i++] = row[1].ToString().Trim();
                        if (i == 5)
                            break;
                    }
                    ProductBox.Items.AddRange(values);
                }
            }
        }
        private void EditShipment_Load(object sender, EventArgs e) //Загрузка формы
        {
            CenterToScreen();
            LoadProduct();

            UNameBox.Text = $"Пользователь: {Global.UName}";

            TradeDateDP.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);


            if (EditMode)
            {
                NumBox.Text = ShipmentNum.ToString();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))
                {
                    //загрузка редактируемой поставки
                    con.Open();
                    {
                        string query = $"SELECT * FROM Shipment WHERE Num = @Num";
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
                    }
                }

                //Заполнение boxes:
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))
                {
                    con.Open();
                    {
                        string query = $"select name from product where id = {ShipmentData.Tables[0].Rows[0][1]}";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                        var ds = new DataSet();
                        dataAdapter.Fill(ds);
                        ProductBox.Text = ds.Tables[0].Rows[0][0].ToString().TrimEnd();
                    }
                }
                AmmountBox.Value = Convert.ToDecimal(ShipmentData.Tables[0].Rows[0][2].ToString());
                TradeDateDP.Value = Convert.ToDateTime(ShipmentData.Tables[0].Rows[0][3].ToString());
                
                if (ShipmentData.Tables[0].Rows[0][4].ToString() != "")
                {
                    DateSaleCheck.Checked = true;
                    SaleDateDP.Value = Convert.ToDateTime(ShipmentData.Tables[0].Rows[0][4].ToString());
                }
                else
                    DateSaleCheck.Checked = false;
                NoteBox.Text = ShipmentData.Tables[0].Rows[0][5].ToString();

                SetEdit();
            }
            else
            {
                SetAdd();
            }
            Change = false;

        }
        private void SetEdit() // Включить режим редактирования
        {
            this.Text = "\"ИП Филёв И.В.\" - Поставки(Редактирование)";
            EditMode = true;
            NumBox.Visible = true;
            IdLb.Visible = true;
            if(Global.AccessLevel == 2)
                DeleteBtn.Visible = true;
            SaveBtn.Text = "Сохранить";
            NewShipmentBtn.Enabled = true;
            NumBox.Enabled = false;   

            NumBox.Text = ShipmentNum.ToString();
            MassangeManager.Massange(MassangeBox, "Режим Редактирования", Color.RoyalBlue);
        }
        private void SetAdd() // Включить режим добавления
        {
            this.Text = "\"ИП Филёв И.В.\" - Поставки(Добавление)";
            EditMode = false;
            ClearBoxes();
            DeleteBtn.Visible = false;
            SaveBtn.Text = "Добавить";
            NewShipmentBtn.Enabled = false;
            NumBox.Text = "";
            NumBox.Enabled = true;  

            MassangeManager.Massange(MassangeBox, "Режим Добавления", Color.RoyalBlue);
            Change = false;
        }
        private void AddShipment()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))//Сохранение 
            {
                con.Open();
                string query = $"INSERT INTO Shipment (Num, Product, Ammount, TradeDate, SaleDate, Note) " +
                    $"VALUES (@Num, @Product, @Ammount, @TradeDate, @SaleDate, @Note)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@Num", SqlDbType.Int).Value = NumBox.Text;
                    cmd.Parameters.Add("@Ammount", SqlDbType.Int).Value = AmmountBox.Text;
                    cmd.Parameters.Add("@TradeDate", SqlDbType.DateTime).Value = Convert.ToDateTime(TradeDateDP.Value.ToShortDateString());
                    if (DateSaleCheck.Checked)
                        cmd.Parameters.Add("@SaleDate", SqlDbType.DateTime).Value = Convert.ToDateTime(SaleDateDP.Value.ToShortDateString());
                    else
                        cmd.Parameters.Add("@SaleDate", DBNull.Value);
                    cmd.Parameters.Add("@Note", SqlDbType.NVarChar, 100).Value = NoteBox.Text;
                    try
                    {
                        string Secondquery = $"select id from product where name = \'{ProductBox.Text.TrimEnd()}\'";
                        SqlDataAdapter adapter = new SqlDataAdapter(Secondquery, con);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        cmd.Parameters.Add("@Product", SqlDbType.Int).Value = ds.Tables[0].Rows[0][0].ToString();
                        try
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                            cmd.BeginExecuteNonQuery();
                            ShipmentNum = Convert.ToInt32(NumBox.Text.Trim());
                            SetEdit();
                            MassangeManager.Massange(MassangeBox, $"Поставка добавлена", Color.Green);
                            Change = false;
                        }
                        catch (System.Data.SqlClient.SqlException)
                        {
                            MassangeManager.Massange(MassangeBox, $"Номер поставки занят", Color.Red);
                        }
                    }
                    catch (System.InvalidOperationException)
                    {
                        ProductBox.Text = "";
                        MassangeManager.Massange(MassangeBox, "Выберите продукт", Color.Red);
                        ProductError.Visible = true;
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        ProductBox.Text = "";
                        MassangeManager.Massange(MassangeBox, "Выберите продукт", Color.Red);
                        ProductError.Visible = true;
                    }
                }
            }
        }
        private void DeleteShipment()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))//Удаление 
                {
                    con.Open();
                    string query = $"DELETE FROM Shipment Where Num = @Num";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@Num", SqlDbType.Int).Value = ShipmentNum;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                    Change = false;
                    SetAdd();
                    MassangeManager.Massange(MassangeBox, $"Поставка удалена", Color.Green);
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MassangeManager.Massange(MassangeBox, $"Поставка не может быть\nудалена", Color.Red);
            }
        }
        private void EditShipment()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))
            {
                con.Open();
                string query = $"UPDATE Shipment SET Product = @Product, Ammount = @Ammount, TradeDate = @TradeDate, " +
                    $"SaleDate = @SaleDate, Note = @Note " +
                    $"Where Num = @Num";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@Num", SqlDbType.Int).Value = ShipmentNum;
                    cmd.Parameters.Add("@Ammount", SqlDbType.Int).Value = AmmountBox.Text;
                    cmd.Parameters.Add("@TradeDate", SqlDbType.DateTime).Value = TradeDateDP.Value.ToShortDateString();
                    if (DateSaleCheck.Checked)
                        cmd.Parameters.Add("@SaleDate", SqlDbType.DateTime).Value = SaleDateDP.Value.ToShortDateString();
                    else
                        cmd.Parameters.Add("@SaleDate", DBNull.Value);
                    cmd.Parameters.Add("@Note", SqlDbType.NVarChar, 100).Value = NoteBox.Text;
                    try
                    {
                        foreach (DataRow row in ProductData.Tables[0].Rows)
                        {
                            if (row[1].ToString() == ProductBox.Text)
                            {
                                cmd.Parameters.Add("@Product", SqlDbType.Int).Value = row[0];
                                break;
                            }
                        }
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        ProductBox.Text = "";
                        MassangeManager.Massange(MassangeBox, "Выберите продукт", Color.Red);
                        ProductError.Visible = true;
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        ProductBox.Text = "";
                        MassangeManager.Massange(MassangeBox, "Выберите продукт", Color.Red);
                        ProductError.Visible = true;
                    }
                }
                SetEdit();
                MassangeManager.Massange(MassangeBox, $"Поставка обновлена", Color.Green);
                Change = false;
            }
        }

        private void ClearBoxes()
        {
            ProductBox.Text = null;
            AmmountBox.Value = 0;
            NoteBox.Text = null;
        }
        private void InfoVisible(bool visible)
        {
            ProductNameLb.Visible = visible;
            ProductPriceLb.Visible = visible;
            ProductPricePurchaseLb.Visible = visible;
            ProductTypeLb.Visible = visible;
            ProviderNameLb.Visible = visible;
            ProviderTelLb.Visible = visible;
        }
        private void Save()
        {
            int i;
            if (ProductBox.Text.Trim() == "" || ProductBox.Text == null || NumBox.Text.Trim() == "" || NumBox.Text == null
                || !int.TryParse(NumBox.Text, out i))
            {
                if (ProductBox.Text.Trim() == "" || ProductBox.Text == null)
                {
                    ProductError.Visible = true;
                    MassangeManager.Massange(MassangeBox, "Выберите продукт", Color.Red);
                }
                if (NumBox.Text.Trim() == "" || NumBox.Text == null)
                {
                    NumError.Visible = true;
                    MassangeManager.Massange(MassangeBox, "Введите номер поставки", Color.Red);
                }
            }
            else
            {
                if (EditMode)
                    EditShipment();

                else
                    AddShipment();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (Change)
            {
                DialogResult dialogResult = MessageBox.Show("Сохранить поставку?", "Сохранение", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    Save();
                    if (!Change)
                        this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
                else if (dialogResult == DialogResult.Cancel)
                {

                }
            }
            else
                this.Close();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить поставку?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteShipment();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        private void ProductBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductError.Visible = false;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))
            {
                Change = true;
                con.Open();
                {
                    int ProviderId = -1;
                    //Info product
                    string query = $"SELECT Name, PricePurchase, PriceSale, Type, Provider FROM Product " +
                            $"WHERE Name = @Name";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = ProductBox.Text;
                        cmd.CommandType = CommandType.Text;

                        var dataAdapter = new SqlDataAdapter(cmd);
                        var commandBuilder = new SqlCommandBuilder(dataAdapter);
                        var ds = new DataSet();
                        dataAdapter.Fill(ds);

                        if (ds.Tables[0].Rows.Count == 0)
                            MassangeManager.Massange(MassangeBox, "Не удалось загрузить данные о продукте", Color.Red);
                        else
                        {
                            ProductNameLb.Text = ds.Tables[0].Rows[0][0].ToString().Trim();
                            ProductPriceLb.Text = ds.Tables[0].Rows[0][1].ToString().Trim();
                            ProductPricePurchaseLb.Text = ds.Tables[0].Rows[0][2].ToString().Trim();
                            ProductTypeLb.Text = ds.Tables[0].Rows[0][3].ToString().Trim();
                            ProviderId = Convert.ToInt32(ds.Tables[0].Rows[0][4].ToString().Trim());
                            InfoVisible(true);
                        }
                    }

                    //Info provider
                    if (ProviderId != -1)
                    {
                        query = $"SELECT Name, Tel FROM Providers " +
                                $"WHERE Id = @Id";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {

                            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = ProviderId;
                            cmd.CommandType = CommandType.Text;

                            var dataAdapter = new SqlDataAdapter(cmd);
                            var commandBuilder = new SqlCommandBuilder(dataAdapter);
                            var ds = new DataSet();
                            dataAdapter.Fill(ds);

                            if (ds.Tables[0].Rows.Count == 0)
                            {
                                MassangeManager.Massange(MassangeBox, "Не удалось загрузить данные о поставщике", Color.Red);
                                ProviderNameLb.Text = "Нет данных";
                                ProviderTelLb.Text = "Нет данных";
                            }
                            else
                            {
                                ProviderNameLb.Text = ds.Tables[0].Rows[0][0].ToString().Trim();
                                ProviderTelLb.Text = ds.Tables[0].Rows[0][1].ToString().Trim();
                                InfoVisible(true);
                            }
                        }
                    }
                }
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Save(); 
        }
        private void NewShipmentBtn_Click(object sender, EventArgs e)
        {
            SetAdd();
        }
        private void TradeDateDP_ValueChanged(object sender, EventArgs e)
        {
            Change = true;
        }
        private void DateSaleCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(DateSaleCheck.Checked)
                SaleDateDP.Enabled = true;
            else 
                SaleDateDP.Enabled = false;
            Change = true;

        }
        private void NumBox_TextChanged(object sender, EventArgs e)
        {
            NumError.Visible = false;
            Change = true;
        }
        private void SaleDateDP_ValueChanged(object sender, EventArgs e)
        {
            Change = true;
        }
        private void AmmountBox_ValueChanged(object sender, EventArgs e)
        {
            Change = true;
        }
        private void NoteBox_TextChanged(object sender, EventArgs e)
        {
            Change = true;
        }

        private void ProductsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))
            {
                con.Open();
                ProductBox.Text = "";
                Global.SelectMode = 0;
                SelectionWindow selectionWindow = new SelectionWindow();
                selectionWindow.ShowDialog();

                if (Global.SelectObject != -1)
                {
                    string query = $"select Name from product where id = {Global.SelectObject}";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    ProductBox.Text = ds.Tables[0].Rows[0][0].ToString().TrimEnd();
                    Global.SelectObject = -1;
                    Global.SelectMode = -1;
                }
            }
        }

        private void EditShipmentF_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon.Dispose();
        }

        private void ProductBox_TextChanged(object sender, EventArgs e)
        {
            Change = true;
        }
    }
}
