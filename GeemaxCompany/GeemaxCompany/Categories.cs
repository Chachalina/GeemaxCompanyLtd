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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            categoryDataGrid.EnableHeadersVisualStyles = false;
        }

        public void SaveCategory()
        {
            //connection string
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=geemaxInventory;Integrated Security=True";
            conn.Open();

            using (conn)
            {

                string strQuery = " INSERT INTO [dbo].[categories] ([category_name]) VALUES (@CategoryName)";

                SqlCommand cmd = new SqlCommand(strQuery, conn);

                cmd.Parameters.AddWithValue("@CategoryName", txtCategory.Text);

                try
                {
                    //Execute command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category saved successfully..!", "Success", MessageBoxButtons.OK);
                    LoadCateGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Category could not save successfully!");
                }
            }


        }

        public void LoadCateGrid()
        {
            //Reading data
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=geemaxInventory;Integrated Security=True";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [dbo].[categories]", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

                            //clear the fields after adding them
            categoryDataGrid.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int data = categoryDataGrid.Rows.Add();
                categoryDataGrid.Rows[data].Cells[0].Value = item["category_name"].ToString();

            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCategory();
           
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            LoadCateGrid();
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
