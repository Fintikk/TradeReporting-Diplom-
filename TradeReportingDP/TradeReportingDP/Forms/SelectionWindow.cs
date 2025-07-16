using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeReportingDP
{
    public partial class SelectionWindow : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        public SelectionWindow()
        {
            InitializeComponent();

            CenterToParent();
            con.Open();
        }

        private void SelectionWindow_Load(object sender, EventArgs e)
        {
            TableLoad();
        }
        private void TableLoad()
        {
            if (Global.SelectMode == 0)
            {
                Text = "Выбор продукта";
                ProviderLb.Visible = true;
                ProviderBox.Visible = true;
                TypeProductLb.Visible = true;
                TypeProductLink.Visible = true;
                TypeBox.Visible = true;
                ProviderLinkLb.Visible = true;
                this.Width = 470;
                SelectionTable.Width = 400;
                TypeLoad();
                ProductLoad();
            }
            else if (Global.SelectMode == 1)
            {
                Text = "Выбор типа продукта";
                ProductTypeLoad();
            }
            else if (Global.SelectMode == 2)
            {
                Text = "Выбор поставщика";
                ProvidersLoad();
            }
            SelectionTable.Columns[0].Width = 160;
        }
        private void ProductLoad()
        {
            SelectionTable.Columns.Clear();
            string query = "SELECT Product.Name as \"Продукт\", Providers.Name as \'Поставщик\' FROM Product, Providers where Providers.id = Product.Provider";
            if (FindBox.Text.Trim() != "")
                query += $" and Product.Name Like \'%{FindBox.Text}%\'";
            if (ProviderBox.Text.TrimEnd() != "")
                query += $" and Providers.Name Like \'%{ProviderBox.Text}%\'";
            if(TypeBox.Text.TrimEnd() != "")
                query += $" and Product.Type Like \'%{TypeBox.Text}%\'";




            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            SelectionTable.DataSource = ds.Tables[0];
            SelectionTable.Columns[0].Width = 160;

            AddButton();
        }
        private void ProductTypeLoad()
        {
            SelectionTable.Columns.Clear();
            string query = "SELECT Distinct Type as \"Тип продукта\" FROM Product";
            if (FindBox.Text.Trim() != "")
                query += $" where Type Like \'%{FindBox.Text}%\'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            SelectionTable.DataSource = ds.Tables[0];

            AddButton();
        }
        private void ProvidersLoad()
        {
            SelectionTable.Columns.Clear();
            string query = "Select Providers.Name as \"Поставщик\" from providers";
            if (FindBox.Text.Trim() != "")
                query += $" where Providers.Name Like \'%{FindBox.Text}%\'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            SelectionTable.DataSource = ds.Tables[0];

            AddButton();
        }
        private void AddButton()
        {
            DataGridViewButtonColumn ButtonSelect = new DataGridViewButtonColumn
            {
                Name = "Выбрать",
                Text = "Выбрать",
                HeaderText = "Выбрать"

            };
            SelectionTable.Columns.AddRange(ButtonSelect);
        }
        private void SelectionTable_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
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
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void SelectionTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (Global.SelectMode == 0)
                {
                    string query = $"Select id from product where Name = \'{SelectionTable.Rows[e.RowIndex].Cells[0].Value}\'";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    sqlDataAdapter.Fill(ds);
                    Global.SelectObject = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                    this.Close();
                }
            }
            else if (e.ColumnIndex == 1)
            {
                if (Global.SelectMode == 1)
                {
                    string query = $"Select id from product where type = \'{SelectionTable.Rows[e.RowIndex].Cells[0].Value}\'";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    sqlDataAdapter.Fill(ds);
                    Global.SelectObject = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                    this.Close();
                }
                else if (Global.SelectMode == 2)
                {
                    string query = $"Select id from providers where name = \'{SelectionTable.Rows[e.RowIndex].Cells[0].Value}\'";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    sqlDataAdapter.Fill(ds);
                    Global.SelectObject = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                    this.Close();
                }
            }
        }
        private void FindBox_TextChanged(object sender, EventArgs e)
        {
            if (FindBox.Text.Trim() != "")
                TableLoad();
        }

        private void ProviderBox_TextChanged(object sender, EventArgs e)
        {
            ProductLoad();
        }
        private void TypeLoad()
        {
            object[] values = null;
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

        private void TypeProductLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TypeBox.Text = "";
            int lastMode = Global.SelectMode;
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
                Global.SelectMode = lastMode;
            }
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductLoad();
        }

        private void TypeBox_TextChanged(object sender, EventArgs e)
        {
            ProductLoad();
        }

        private void ProviderLinkLb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProviderBox.Text = "";
            int lastMode = Global.SelectMode;
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
                Global.SelectMode = lastMode;
            }
        }
    }
}
