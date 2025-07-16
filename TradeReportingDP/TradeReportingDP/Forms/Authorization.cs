using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TradeReportingDP
{
    public partial class Authorization : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString());
        public Authorization()
        {
            InitializeComponent();
            con.Open();
        }
        private void Auth()
        {
            string query = "SELECT * FROM Employee Where Login = @Login and Password = @Password";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@Login", SqlDbType.NVarChar).Value = PasswordHasher.HashPassword(LoginBox.Text);
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = PasswordHasher.HashPassword(PasswordBox.Text);
                cmd.CommandType = CommandType.Text;

                var dataAdapter = new SqlDataAdapter(cmd);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count == 0)
                    MassangeManager.Massange(MassengeLb, "Неверные данные", Color.Red);
                else
                {
                    Global.UName = LoginBox.Text;
                    Global.AccessLevel = Convert.ToInt32(ds.Tables[0].Rows[0][8].ToString());
                    Shipment mainMenu = new Shipment();
                    this.Hide();
                    mainMenu.ShowDialog();
                    this.Close();
                }

            }

        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReadyBtn.Focus();
                Auth();
            }

        }
        private void LoginBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PasswordBox.Focus();
            }
        }
        private void Authentication_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
        private void ReadyBtn_Click(object sender, EventArgs e)
        {
            Auth();
        }
    }
}
