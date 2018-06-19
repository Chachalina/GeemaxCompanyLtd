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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'geemaxInventoryDataSet1.roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.geemaxInventoryDataSet1.roles);

        }

        public void AddNewUser()
        {
            //connection string
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=geemaxInventory;Integrated Security=True";
            conn.Open();

            using (conn)
            {

                string addQuery = "INSERT INTO[dbo].[users] ([user_firstname],[user_lastname] ,[username]" +
                    ",[user_address] ,[user_contact],[email],[password],[role_id])" +
                "VALUES (@Firstname, @Lastname, @Username, @UserAddress, @Contact, @Email, @Password, @Role)";

                SqlCommand cmd = new SqlCommand(addQuery, conn);

                bool status = false;
                if (cmbUserRole.SelectedIndex == 0)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
                cmd.Parameters.AddWithValue("@Firstname", txtUfirstname.Text);
                cmd.Parameters.AddWithValue("@Lastname", txtUlastname.Text);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@UserAddress", txtUaddress.Text);
                cmd.Parameters.AddWithValue("@Contact", txtUcontact.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Role", status);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                try
                {
                    //Execute command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User saved successfully..!", "Success", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "User could not saved successfully!");
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }

        private void btnUserCancel_Click(object sender, EventArgs e)
        {
            txtUfirstname.Clear();
            txtUlastname.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtUaddress.Clear();
            txtUcontact.Clear();
            txtEmail.Clear();
        }
    }
}
