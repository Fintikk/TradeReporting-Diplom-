using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TradeReportingDP
{
    public partial class Provider : Form
    {
        private bool AddMode = true;

        private int Records = 0;
        private int MaxRows = 7;
        private int ScrollVal = 0;
        private int Pages = 1;
        private int RowShow = 0;

        DataSet PageDS = new DataSet();
        SqlDataAdapter PageAdapter = new SqlDataAdapter();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString());
        public Provider()
        {
            InitializeComponent();
            con.Open();
        }

        private void Provider_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            TableLoad();
            MassangeManager.Massange(MassangeBox, "Загружена таблица", MassangeBox.ForeColor);
            UNameBox.Text = $"Пользователь: {Global.UName}";
        }
        private void TableLoad()
        {
            string query = "SELECT Id, Name as \"Название\", Adress as \"Адрес\", Tel as \"Телефон\", Email FROM Providers";
            if (FindBox.Text.Trim() != "")
                query += $" where Name Like \'%{FindBox.Text}%\'";


            PageAdapter = new SqlDataAdapter(query, con);
            PageDS = new DataSet();
            PageAdapter.Fill(PageDS, ScrollVal, MaxRows, "page");
            ProviderTable.DataSource = PageDS.Tables[0];

            //кол-во число записей
            query = $"SELECT COUNT(*) FROM Providers";
            if (FindBox.Text.Trim() != "")
                query += $" where Name Like \'%{FindBox.Text}%\'";
            var dataAdapter = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            Records = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            if (FindBox.Text.Trim() != "")
                MassangeManager.Massange(MassangeBox, $"Нашлось совпадений: {Records}", Color.Black);

            ProviderTable.Columns[0].Width = 50;
            ProviderTable.Columns[1].Width = 130;

            CountLb.Text = $"{Pages} / {Math.Ceiling(Convert.ToDouble(Records) / MaxRows)}";
            RowShow = ProviderTable.RowCount - 1;
            RowCountLb.Text = $"Записей {RowShow}/{Records}";
        }
        private void AddProvider()
        {
            string query = $"INSERT INTO Providers (Name, Adress, Tel, Email) VALUES (@Name,@Adress,@Tel,@Email)";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 60).Value = NameBox.Text;
                cmd.Parameters.Add("@Adress", SqlDbType.NVarChar, 100).Value = AdressBox.Text;
                cmd.Parameters.Add("@Tel", SqlDbType.NVarChar, 15).Value = TelBox.Text;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = EmailBox.Text;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            MassangeManager.Massange(MassangeBox, $"Добавлен новый  поставщик \"{NameBox.Text}\"", MassangeBox.ForeColor);
            ClearBox();
            TableLoad();
            Add();

        }
        private void EditProvider()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))//Редактирование 
            {
                con.Open();
                string query = $"UPDATE Providers SET Name = @Name, Adress = @Adress, Tel  = @Tel, Email = @Email Where Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = IdBox.Text;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 60).Value = NameBox.Text;
                    cmd.Parameters.Add("@Adress", SqlDbType.NVarChar, 100).Value = AdressBox.Text;
                    cmd.Parameters.Add("@Tel", SqlDbType.NVarChar, 50).Value = TelBox.Text;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = EmailBox.Text;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
                MassangeManager.Massange(MassangeBox, $"Обновлен поставщик\n \"{NameBox.Text}\"", MassangeBox.ForeColor);
                TableLoad();
            }
        }
        private void DeleteProvider()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))//Удаление 
                {
                    con.Open();
                    string query = $"DELETE FROM Providers Where Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = IdBox.Text;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                    MassangeManager.Massange(MassangeBox, $"Удален поставщик \"{NameBox.Text}\"", MassangeBox.ForeColor);
                    ClearBox();
                    TableLoad();
                    Add();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MassangeManager.Massange(MassangeBox, $"Поставщик не может быть удален", MassangeBox.ForeColor);
                notifyIcon.ShowBalloonTip(2000, "Ошибка", "Поставщик не может быть удален", ToolTipIcon.Error);
            }
        }
        private void Add() // включение режима добавления
        {
            DataSet ds = new DataSet();
            ProductList.DataSource = ds;
            AddMode = true;
            DeleteBtn.Visible = false;
            SaveBtn.Text = "Добавить";
            AddBtn.BackColor = Color.FromArgb(192, 255, 192);
            EditBtn.BackColor = Color.White;
            IdLb.Visible = false;
            IdBox.Visible = false;
            ClearBox();

            MassangeManager.Massange(MassangeBox, "Режим добавления", MassangeBox.ForeColor);
        }
        private void Edit() // включение режима редактирования
        {
            //ProductList.Rows.Clear();
            if (ProviderTable.SelectedCells != null | ProviderTable.SelectedCells[0].RowIndex != ProviderTable.RowCount - 1)
            {
                AddMode = false;
                DeleteBtn.Visible = true;
                SaveBtn.Text = "Сохранить";
                AddBtn.BackColor = Color.White;
                EditBtn.BackColor = Color.FromArgb(192, 255, 192);
                IdLb.Visible = true;
                IdBox.Visible = true;

                IdBox.Text = $"{ProviderTable.Rows[ProviderTable.SelectedCells[0].RowIndex].Cells[0].Value}";
                NameBox.Text = $"{ProviderTable.Rows[ProviderTable.SelectedCells[0].RowIndex].Cells[1].Value}";
                AdressBox.Text = $"{ProviderTable.Rows[ProviderTable.SelectedCells[0].RowIndex].Cells[2].Value}";
                TelBox.Text = $"{ProviderTable.Rows[ProviderTable.SelectedCells[0].RowIndex].Cells[3].Value}";
                EmailBox.Text = $"{ProviderTable.Rows[ProviderTable.SelectedCells[0].RowIndex].Cells[4].Value}";

                //Загрузка листа продукции поставщика
                string query = $"SELECT Name FROM Product Where Product.Provider = {IdBox.Text}";

                PageAdapter = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                PageAdapter.Fill(ds);
                ProductList.DataSource = ds.Tables[0];

                ProductList.Columns[0].Width = 200;

                MassangeManager.Massange(MassangeBox, "Режим редактирования", MassangeBox.ForeColor);
            }
            else
            {
                notifyIcon.ShowBalloonTip(2000, "Запись не выбрана", "Пожалуйста, выберите запись и повторите попытку", ToolTipIcon.Warning);
            }
        }
        private void ClearBox()
        {
            NameBox.Text = null;
            AdressBox.Text = null;
            TelBox.Text = null;
            EmailBox.Text = null;
        }// очистка textbox
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
                TableLoad() ;
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
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            NameError.Visible = false;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            Edit();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить поставщика?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteProvider();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        private void ProviderTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == ProviderTable.RowCount - 1)
            {
                Add();
            }
            else
                Edit();
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == null || NameBox.Text.Trim() == "")
                NameError.Visible = true;
            else
            {
                if (AddMode)
                    AddProvider();
                else
                    EditProvider();
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
        private void FindBtn_Click(object sender, EventArgs e)
        {
            if (FindBox.Text.Trim() != "")
                TableLoad();
        }
        private void ProviderTable_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
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
        private void UpdateTableBtn_Click(object sender, EventArgs e)
        {
            TableLoad();
            MassangeManager.Massange(MassangeBox, "Таблица обновлена", Color.Black);
        }

        private void Provider_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon.Dispose();
        }
    }
}
