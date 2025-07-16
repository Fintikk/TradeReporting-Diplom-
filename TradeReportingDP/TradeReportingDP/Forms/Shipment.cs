using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TradeReportingDP.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TradeReportingDP
{
    public partial class Shipment : Form
    {

        private int Records = 0;
        private int MaxRows = 11;
        private int ScrollVal = 0;
        private int Pages = 1;
        private int RowShow = 0;

        DataSet PageDS = new DataSet();
        SqlDataAdapter PageAdapter = new SqlDataAdapter();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString());
        public Shipment()
        {
            InitializeComponent();
            con.Open();
        }

        private void Shipment_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            SaleDateDP.Checked = false;
            TradeDateDP.Checked = false;
            TableLoad();
            MassangeManager.Massange(MassangeBox, "Загружена таблица", MassangeBox.ForeColor);
            UNameBox.Text = $"Пользователь: {Global.UName}";
            if (Global.AccessLevel == 1)
            {
                ProvidersBtn.Enabled = false;
                ProductBtn.Enabled = false;
            }

        }
        private void TableLoad()
        {
            ShipmentTable.Columns.Clear();

            string query = "SELECT Shipment.Num as \"Номер\", Product.Name as \"Продукт\", Providers.Name as \"Поставщик\", Product.Type as \"Тип\", Shipment.Ammount as \"Кол-во\"," +
                "Shipment.TradeDate as \"Дата поставки\", Shipment.SaleDate as \"Дата реализации\", Shipment.Note as \"Примечание\" FROM SHIPMENT," +
                " Product, Providers where Shipment.Product = Product.Id and Product.Provider = Providers.Id";
            if (Find.Text.Trim() != "")
            {
                switch (FindBox.SelectedIndex)
                {
                    case 1: { query += $" and Shipment.Num LIKE \'%{Find.Text}%\'"; break; }
                    case 2: { query += $" and Product.Name LIKE \'%{Find.Text}%\'"; break; }
                    case 3: { query += $" and Providers.Name LIKE \'%{Find.Text}%\'"; break; }
                    case 4: { query += $" and Product.Type LIKE \'%{Find.Text}%\'"; break; }
                }
            }
            {
                if (TradeDateDP.Checked == true)
                    query += $" and Shipment.TradeDate >= \'{TradeDateDP.Value.Year}-{TradeDateDP.Value.Day}-{TradeDateDP.Value.Month}\'";
                else
                    query += " and Shipment.TradeDate > \'1980-01-01\' or Shipment.TradeDate = NULL";
                if (SaleDateDP.Checked == true)
                    query += $" and Shipment.SaleDate <= \'{SaleDateDP.Value.Year}-{SaleDateDP.Value.Day}-{SaleDateDP.Value.Month}\'";
                else
                    query += " and Shipment.SaleDate < \'3000-01-01\' or Shipment.SaleDate = NULL";
            }

            SqlCommand cmd = new SqlCommand(query, con);
            PageAdapter = new SqlDataAdapter(cmd); 
            PageDS = new DataSet();
            PageAdapter.Fill(PageDS, ScrollVal, MaxRows, "page");
            ShipmentTable.DataSource = PageDS.Tables[0];

            DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Изменить",
                Text = "Изменить",
                HeaderText = "Изменить"
            };
            int columnIndex = 8;
            ShipmentTable.Columns.Insert(columnIndex, uninstallButtonColumn);
            ShipmentTable.Columns[8].Width = 66;
            ShipmentTable.Columns[4].Width = 50;
            ShipmentTable.Columns[5].Width = 110;
            ShipmentTable.Columns[6].Width = 124;

            
            query = "SELECT Count(Shipment.Num) as \"Номер\" " +
                "FROM SHIPMENT, Product, Providers " +
                "where Shipment.Product = Product.Id and Product.Provider = Providers.Id";
            if (Find.Text.Trim() != "")
            {
                switch (FindBox.SelectedIndex)
                {
                    case 1: { query += $" and Shipment.Num LIKE \'%{Find.Text}%\'"; break; }
                    case 2: { query += $" and Product.Name LIKE \'%{Find.Text}%\'"; break; }
                    case 3: { query += $" and Providers.Name LIKE \'%{Find.Text}%\'"; break; }
                    case 4: { query += $" and Product.Type LIKE \'%{Find.Text}%\'"; break; }
                }
            }
            {
                if (TradeDateDP.Checked == true)
                    query += $" and Shipment.TradeDate >= \'{TradeDateDP.Value.Year}-{TradeDateDP.Value.Day}-{TradeDateDP.Value.Month}\'";
                else
                    query += " and Shipment.TradeDate > \'1980-01-01\' or Shipment.TradeDate = NULL";
                if (SaleDateDP.Checked == true)
                    query += $" and Shipment.SaleDate <= \'{SaleDateDP.Value.Year}-{SaleDateDP.Value.Day}-{SaleDateDP.Value.Month}\'";
                else
                    query += " and Shipment.SaleDate < \'3000-01-01\' or Shipment.SaleDate = NULL";
            }
            var dataAdapter = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            Records = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            if(Find.Text.Trim() != "")
                MassangeManager.Massange(MassangeBox, $"Нашлось совпадений: {Records}", Color.Black);

            CountLb.Text = $"{Pages} / {Math.Ceiling(Convert.ToDouble(Records) / MaxRows)}";

            RowShow = ShipmentTable.RowCount - 1;
            RowCountLb.Text = $"Записей {RowShow}/{Records}";
        }
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
                RowCountLb.Text = $"Записей {RowShow}/{Records}";
                TableLoad();
            }
            else
            {
                CountLb.Text = $"{Pages}/{Pages}";
                RowShow = MaxRows - ((Pages * MaxRows) - Records);
                RowCountLb.Text = $"Записей {RowShow}/{Records}";
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
            }
        }
        #region Действия над Shipment 
        private void AddShipment()
        {
            using (TradeReportingDP.EditShipmentF AddForm = new TradeReportingDP.EditShipmentF())
            {
                AddForm.Owner = this;
                AddForm.EditMode = false; //передача значения EditMode дочерней форме EditShipment
                Hide();
                AddForm.ShowDialog();
            }
            Show();
            TableLoad();

        }
        /// <summary>
        /// Метод перехода на форму ShipmentEdit с модом "Редактирование"
        /// для редактирования строки таблицы Shipment из базы данных
        /// используя параметр ShipmentNum для индефикации данной строки.
        /// </summary>
        /// <param name="ShipmentNum">Параметр для индификации номера в БД</param>
        private void EditShipment(int ShipmentNum)
        {
            using (TradeReportingDP.EditShipmentF editForm = new TradeReportingDP.EditShipmentF())
            {
                editForm.Owner = this;
                editForm.EditMode = true; //передача значения EditMode дочерней форме EditShipment
                editForm.ShipmentNum = ShipmentNum; //передача значения ShipmentNum дочерней форме EditShipment
                Hide();
                editForm.ShowDialog();
            }
            Show();
            TableLoad();
            
        }
        private void ViewingShipment(int ShipmentNum) 
        {
            using (TradeReportingDP.ShipmentViewing viewing = new TradeReportingDP.ShipmentViewing())
            {
                viewing.Owner = this;
                viewing.ShipmentNum = ShipmentNum; //передача значения ShipmentNum дочерней форме EditShipment
                viewing.ShowDialog();
                if (viewing.edit)
                    EditShipment(ShipmentNum);
            }
            Show();
        }
        /// <summary>
        /// Удаление одной строки таблицы Shipment из базы данных, используя id для индефикации этой строки.
        /// </summary>
        /// <param name="id">Параметр для индификации Id в БД</param>
        private void DeleteShipment(int id) 
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))//Удаление 
                {
                    con.Open();
                    string query = $"DELETE FROM Shipment Where Num = @Num";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@Num", SqlDbType.Int).Value = id;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                    TableLoad();
                    MassangeManager.Massange(MassangeBox, $"Поставка удалена", Color.Green);
                    
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MassangeManager.Massange(MassangeBox, $"Поставка не может быть\nудалена", Color.Red);
            }
        }
        #endregion

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddShipment();
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
        private void ShipmentTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == ShipmentTable.RowCount - 1)
                AddShipment();
            else if (e.RowIndex != -1)
            {
                ViewingShipment((int)ShipmentTable.Rows[ShipmentTable.SelectedCells[0].RowIndex].Cells[0].Value); // просмотр выбранной записи
            }    
                //EditShipment((int)ShipmentTable.Rows[ShipmentTable.SelectedCells[0].RowIndex].Cells[0].Value); //редактирование выбранной записи
        }
        private void ShipmentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == ShipmentTable.RowCount - 1 && e.ColumnIndex == 8)
                AddShipment();
            else if(e.ColumnIndex == 8)
                EditShipment((int)ShipmentTable.Rows[ShipmentTable.SelectedCells[0].RowIndex].Cells[0].Value);
        }
        private void Find_TextChanged(object sender, EventArgs e)
        {
            TableLoad();
        }
        private void ProdidersBtn_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            Hide();
            provider.ShowDialog();
            Show();
        }
        private void UpdateTableBtn_Click(object sender, EventArgs e)
        {
            TableLoad();
            MassangeManager.Massange(MassangeBox, "Таблица обновлена", Color.Black);
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
        private void ShipmentTable_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
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
        private void TradeDateDP_ValueChanged(object sender, EventArgs e)
        {
            TableLoad();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            if (Global.AccessLevel == 2)
            {
                RegisterUsers register = new RegisterUsers();
                register.ShowDialog();
            }
        }
        private void ShipmentTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && Global.AccessLevel == 2)
            {
                ShipmentTable.ClearSelection();
                ShipmentTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                Menu.Show(Cursor.Position);
            }
        }
        private void MenuDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить поставку #{ShipmentTable.Rows[ShipmentTable.SelectedCells[0].RowIndex].Cells[0].Value}?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteShipment(Convert.ToInt32(ShipmentTable.Rows[ShipmentTable.SelectedCells[0].RowIndex].Cells[0].Value));
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Shipment_SizeChanged(object sender, EventArgs e)
        {
            if (Size.Width == 928 && Size.Height == 484)
            {
                MaxRows = 11;
                TableLoad();
            }
            else
            {
                MaxRows = 37;
                TableLoad();

            }
        }
    }
}
