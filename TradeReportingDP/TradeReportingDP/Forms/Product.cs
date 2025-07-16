using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TradeReportingDP
{
    public partial class Product : Form
    {
        object[] values = null;
        private bool AddMode = true;

        private int Records = 0;
        private int MaxRows = 7;
        private int ScrollVal = 0;
        private int Pages = 1;
        private int RowShow = 0;

        DataSet PageDS = new DataSet();
        SqlDataAdapter PageAdapter = new SqlDataAdapter();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString());
        public Product()
        {
            InitializeComponent();
            con.Open();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            TableLoad();
            MassangeManager.Massange(MassangeBox, "Загружена таблица", MassangeBox.ForeColor);
            UNameBox.Text = $"Пользователь: {Global.UName}";
        }
        private void TypeLoad()
        {
            ProviderBox.Items.Clear();
            TypeBox.Items.Clear();
            //загрузка типа продукта

            {
                string query = $"SELECT Distinct Type FROM Product";
                SqlCommand cmd = new SqlCommand(query, con);

                var dataAdapter = new SqlDataAdapter(query, con);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count < 5)
                    values = new object[ds.Tables[0].Rows.Count];
                else 
                    values = new object[5];
                int i = 0;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    values[i++] = row[0].ToString().Trim();
                    if (i == 5)
                        break;
                }
                TypeBox.Items.AddRange(values);
            }

            //загрузка поставщиков
            {
                string query = $"SELECT id, Name FROM Providers";
                SqlCommand cmd = new SqlCommand(query, con);

                var dataAdapter = new SqlDataAdapter(query, con);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count < 5)
                    values = new object[ds.Tables[0].Rows.Count];
                else
                    values = new object[5];
                int i = 0;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    values[i++] = row[1].ToString().Trim();
                    if (i == 5)
                        break;
                }
                ProviderBox.Items.AddRange(values);           
            }

        }
        private void TableLoad()
        {
            string query = "SELECT Product.Id as \"id\", Product.Name as \"Название\", Product.PricePurchase as \"Цена покупки\"," +
                " Product.PriceSale as \"Цена продажи\", Product.Type as \"Тип\", Providers.Name as \"Поставщик\" FROM Product, Providers" +
                " where Product.Provider = Providers.id";
            if (FindBox.Text.Trim() != "")
                query += $" and Product.Name Like \'%{FindBox.Text}%\'";

            SqlCommand cmd = new SqlCommand(query, con);
            PageAdapter = new SqlDataAdapter(cmd);
            PageDS = new DataSet();
            PageAdapter.Fill(PageDS, ScrollVal, MaxRows, "page");
            ProductTable.DataSource = PageDS.Tables[0];

            //кол-во число записей
            query = $"SELECT COUNT(*) FROM Product";
            if (FindBox.Text.Trim() != "")
                query += $" where Product.Name Like \'%{FindBox.Text}%\'";
            var dataAdapter = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            Records = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            if (FindBox.Text.Trim() != "")
                MassangeManager.Massange(MassangeBox, $"Нашлось совпадений: {Records}", Color.Black);

            ProductTable.Columns[3].Width = 120;
            ProductTable.Columns[4].Width = 120;
            ProductTable.Columns[0].Width = 60;
            TypeLoad();

            CountLb.Text = $"{Pages} / {Math.Ceiling(Convert.ToDouble(Records) / MaxRows)}";
            RowShow = ProductTable.RowCount - 1;
            RowCountLb.Text = $"Записей {RowShow}/{Records}";
        }
        private void AddProduct()
        {
            try
            {
                string query = $"INSERT INTO Product (Name, PricePurchase, PriceSale, Type, Provider) VALUES (@Name,@PricePurchase,@PriceSale,@Type,@Provider)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = NameBox.Text;
                        cmd.Parameters.Add("@PricePurchase", SqlDbType.Int, 50).Value = PricePurchaseBox.Text;
                        cmd.Parameters.Add("@PriceSale", SqlDbType.Int, 50).Value = PriceSaleBox.Text;
                        cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = TypeBox.Text.TrimEnd();
                        {

                            string secondQuery = $"Select id from providers where name = \'{ProviderBox.Text.TrimEnd()}\'";
                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(secondQuery, con);
                            DataSet ds = new DataSet();

                            sqlDataAdapter.Fill(ds);
                            cmd.Parameters.Add("@Provider", SqlDbType.Int).Value = ds.Tables[0].Rows[0][0];


                        }
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MassangeManager.Massange(MassangeBox, $"Добавлен новый товар \"{NameBox.Text}\"", MassangeBox.ForeColor);
                        ClearBox();
                        TableLoad();
                        Add();
                    }
                    catch (System.InvalidOperationException)
                    {
                        ProviderBox.Text = "";
                        MassangeManager.Massange(MassangeBox, "Выберите поставщика", Color.Red);
                        ProviderBox.Visible = true;
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        ProviderBox.Text = "";
                        MassangeManager.Massange(MassangeBox, "Выберите поставщика", Color.Red);
                        ProviderBox.Visible = true;
                    }
                }
                
            }
            catch (System.InvalidOperationException)
            {
                ProviderBox.Text = "";
                ProviderError.Visible = true;
            }

}
        private void EditProduct()
        {
            string query = $"UPDATE Product SET Name = @Name, PricePurchase = @PricePurchase, PriceSale  = @PriceSale, Type = @Type, Provider = @Provider Where Id = @Id";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = IdBox.Text;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = NameBox.Text;
                cmd.Parameters.Add("@PricePurchase", SqlDbType.Int, 50).Value = PricePurchaseBox.Text;
                cmd.Parameters.Add("@PriceSale", SqlDbType.Int, 50).Value = PriceSaleBox.Text;
                cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = TypeBox.Text.TrimEnd();
                {
                    string secondQuery = $"Select id from providers where name = \'{ProviderBox.Text.TrimEnd()}\'";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(secondQuery, con);
                    DataSet ds = new DataSet();
                    sqlDataAdapter.Fill(ds);
                    cmd.Parameters.Add("@Provider", SqlDbType.Int).Value = ds.Tables[0].Rows[0][0];
                }
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            MassangeManager.Massange(MassangeBox, $"Обновлен товар \"{NameBox.Text}\"", MassangeBox.ForeColor);
            TableLoad();
        }
        private void DeleteProduct()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))//Удаление 
                {
                    con.Open();
                    string query = $"DELETE FROM Product Where Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = IdBox.Text;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                    MassangeManager.Massange(MassangeBox, $"Удален товар\n \"{NameBox.Text}\"", MassangeBox.ForeColor);
                    ClearBox();
                    TableLoad();
                    Add();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MassangeManager.Massange(MassangeBox, $"Товар не может быть удален, возможно\nон уже используется в поставке", MassangeBox.ForeColor);
                notifyIcon.ShowBalloonTip(2000, "Ошибка", "Товар не может быть удален, возможно он уже используется в поставке", ToolTipIcon.Error);
            }
        }
        private void Edit()
        {
            if (ProductTable.SelectedCells != null && ProductTable.SelectedCells[0].RowIndex != ProductTable.RowCount - 1)
            {
                AddMode = false;
                DeleteBtn.Visible = true;
                SaveBtn.Text = "Сохранить";
                AddBtn.BackColor = Color.White;
                EditBtn.BackColor = Color.FromArgb(192, 255, 192);
                IdLb.Visible = true;
                IdBox.Visible = true;

                IdBox.Text = $"{ProductTable.Rows[ProductTable.SelectedCells[0].RowIndex].Cells[0].Value}";
                NameBox.Text = $"{ProductTable.Rows[ProductTable.SelectedCells[0].RowIndex].Cells[1].Value}";
                PricePurchaseBox.Text = $"{ProductTable.Rows[ProductTable.SelectedCells[0].RowIndex].Cells[2].Value}";
                PriceSaleBox.Text = $"{ProductTable.Rows[ProductTable.SelectedCells[0].RowIndex].Cells[3].Value}";
                TypeBox.Text = $"{ProductTable.Rows[ProductTable.SelectedCells[0].RowIndex].Cells[4].Value}";
                ProviderBox.Text = $"{ProductTable.Rows[ProductTable.SelectedCells[0].RowIndex].Cells[5].Value}";

                MassangeManager.Massange(MassangeBox, "Режим редактирования", MassangeBox.ForeColor);
            }
            else 
            {
                notifyIcon.ShowBalloonTip(2000, "Запись не выбрана", "Пожалуйста, выберите запись и повторите попытку", ToolTipIcon.Warning);
            }
        }//включение режима редактирование
        private void Add()
        {
            AddMode = true;
            DeleteBtn.Visible = false;
            SaveBtn.Text = "Добавить";
            AddBtn.BackColor = Color.FromArgb(192, 255, 192);
            EditBtn.BackColor = Color.White;
            IdLb.Visible = false;
            IdBox.Visible = false;
            ClearBox();
            MassangeManager.Massange(MassangeBox, "Режим добавления", Color.RoyalBlue);
        }//включение режима добавления
        private void OpenFirstPage()
        {
            if (Pages != 1 && !(Pages <= 0))
            {
                Pages = 1;
                ScrollVal = 0;
                if (ScrollVal < 0)
                    ScrollVal = 0;
                CountLb.Text = $"{Pages} / {Math.Ceiling(Convert.ToDouble(Records) / MaxRows)}";

                if (Pages != Math.Ceiling(Convert.ToDouble(Records) / MaxRows))
                    RowShow = MaxRows;
                RowCountLb.Text = $"Записей {RowShow}/{Records}";

                PageDS.Clear();
                PageAdapter.Fill(PageDS, ScrollVal, MaxRows, "Page");
                TableLoad();
            }
        }
        private void OpenLastPage()
        {
            if (Pages != Math.Ceiling(Convert.ToDouble(Records) / MaxRows))
            {
                Pages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(Records) / MaxRows));

                if (Records != 0)
                    ScrollVal = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(Records) / MaxRows) * MaxRows - MaxRows);
                if (ScrollVal > Records)
                {
                    ScrollVal = 0;
                    Pages = 1;
                }

                CountLb.Text = $"{Pages} / {Math.Ceiling(Convert.ToDouble(Records) / MaxRows)}";

                RowShow = MaxRows - ((Pages * MaxRows) - Records);
                RowCountLb.Text = $"Записей {RowShow}/{Records}";

                PageDS.Clear();
                PageAdapter.Fill(PageDS, ScrollVal, MaxRows, "page");
                TableLoad();
            }
            else
            {
                CountLb.Text = $"{Pages}/{Pages}";
                RowShow = MaxRows - ((Pages * MaxRows) - Records);
                RowCountLb.Text = $"Записей {RowShow}/{Records}";
                TableLoad();
            }
        }
        private void PreviousPage()
        {
            if (Pages != 1 && !(Pages <= 0))
            {
                Pages--;
                ScrollVal -= MaxRows;
                if (ScrollVal < 0)
                    ScrollVal = 0;

                CountLb.Text = $"{Pages} / {Math.Ceiling(Convert.ToDouble(Records) / MaxRows)}";

                if (Pages != Math.Ceiling(Convert.ToDouble(Records) / MaxRows))
                    RowShow = MaxRows;
                RowCountLb.Text = $"Записей {RowShow}/{Records}";

                PageDS.Clear();
                PageAdapter.Fill(PageDS, ScrollVal, MaxRows, "Page");
                TableLoad();
            }
        }
        private void NextPage()
        {
            if (Pages != Math.Ceiling(Convert.ToDouble(Records) / MaxRows))
            {
                Pages++;
                CountLb.Text = $"{Pages} / {Math.Ceiling(Convert.ToDouble(Records) / MaxRows)}";

                if (Pages != Math.Ceiling(Convert.ToDouble(Records) / MaxRows))
                    RowShow = MaxRows;
                else
                    RowShow = MaxRows - ((Pages * MaxRows) - Records);
                RowCountLb.Text = $"Записей {RowShow}/{Records}";

                ScrollVal += MaxRows;
                if (ScrollVal > Records)
                    ScrollVal = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(Records) / MaxRows) * MaxRows - MaxRows);
                PageDS.Clear();
                PageAdapter.Fill(PageDS, ScrollVal, MaxRows, "page");
                TableLoad();
            }
        }
        private void ClearBox() //Очищает все textbox
        {
            NameBox.Text = null;
            PricePurchaseBox.Text = "0";
            PriceSaleBox.Text = "0";
            TypeBox.Text = null;
            ProviderBox.Text = null;
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить продукт?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {   
                DeleteProduct();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        private void ProductTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == ProductTable.RowCount - 1)
            {
                Add();
            }
            else
                Edit();
        }
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            NameError.Visible = false;
        }
        private void PricePurchaseBox_TextChanged(object sender, EventArgs e)
        {
            PricePurchaseError.Visible = false;
        }
        private void PriceSaleBox_TextChanged(object sender, EventArgs e)
        {
            PriceSaleError.Visible = false;
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            Edit();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            int i;
            if (NameBox.Text == null || NameBox.Text.Trim() == "" || !int.TryParse(PricePurchaseBox.Text, out i) 
                || !int.TryParse(PriceSaleBox.Text, out i) || ProviderBox.Text.Trim() == "")
            {
                if (!int.TryParse(PricePurchaseBox.Text, out i))
                    PricePurchaseError.Visible = true;
                if (!int.TryParse(PriceSaleBox.Text, out i))
                    PriceSaleError.Visible = true;
                if (NameBox.Text.Trim() == null || NameBox.Text.Trim() == "")
                    NameError.Visible = true;
                if(ProviderBox.Text.Trim() == "")
                    ProviderError.Visible = true;
            }
            else
            {
                if (AddMode)
                    AddProduct();
                else
                    EditProduct();
            }
        }
        private void DRBtn_Click(object sender, EventArgs e)
        {
            OpenLastPage();
        }
        private void RBtn_Click(object sender, EventArgs e)
        {
            NextPage();
        }
        private void LBtn_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }
        private void DLBtn_Click(object sender, EventArgs e)
        {
            OpenFirstPage();
        }
        private void UpdateTableBtn_Click(object sender, EventArgs e)
        {
            TableLoad();
            MassangeManager.Massange(MassangeBox, "Таблица обновлена", Color.Black);
        }
        private void ProductTable_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            var row = grid.Rows[e.RowIndex];

            if (e.RowIndex % 2 != 0)
            {
                row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 215, 215);
                row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(40, 40, 40);
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(230, 248, 248);
                row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(190, 208, 208);
                row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(40, 40, 40);
            }
        }
        private void FindBtn_Click(object sender, EventArgs e)
        {
            if (FindBox.Text != "")
                TableLoad();
        }
        private void TypeProductLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TypeBox.Text = "";
            Global.SelectMode = 1;
            SelectionWindow selectionWindow = new SelectionWindow();
            selectionWindow.ShowDialog();

            if (Global.SelectObject != -1)
            {
                string query = $"select Type from product where id = {Global.SelectObject}";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                TypeBox.Text = ds.Tables[0].Rows[0][0].ToString().TrimEnd();
                Global.SelectObject = -1;
                Global.SelectMode = -1;
            }
        }
        private void ProvidersLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProviderBox.Text = "";
            Global.SelectMode = 2;
            SelectionWindow selectionWindow = new SelectionWindow();
            selectionWindow.ShowDialog();

            if (Global.SelectObject != -1)
            {
                string query = $"select Name from providers where id = {Global.SelectObject}";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                ProviderBox.Text = ds.Tables[0].Rows[0][0].ToString().TrimEnd();
                Global.SelectObject = -1;
                Global.SelectMode = -1;
            }
        }
        private void ProviderBox_TextChanged(object sender, EventArgs e)
        {
            ProviderError.Visible = false;
        }

        private void Product_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon.Dispose();
        }
    }
}
