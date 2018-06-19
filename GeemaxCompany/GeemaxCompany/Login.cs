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

namespace GeemaxCompany
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //connection string
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=geemaxInventory;Integrated Security=True";
            conn.Open();

            using (conn)
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[users] where username = @Username and password = @Password", conn);
                cmd.Parameters.Add(new SqlParameter("@Username", txtUsername.Text));
                cmd.Parameters.Add(new SqlParameter("@Password", txtPassword.Text));

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
               
               
                    //Validate login credentials
                    if (dt.Rows.Count == 1)
                    {
                        this.Hide(); //close login page
                        AdminDashboard admin = new AdminDashboard();
                        admin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password Incorrect..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnCancel_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
