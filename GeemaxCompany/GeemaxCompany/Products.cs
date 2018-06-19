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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            //productDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            productDataGrid.EnableHeadersVisualStyles = false;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'geemaxInventoryCategoryDataSet.categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.geemaxInventoryCategoryDataSet.categories);
            cmbStatus.SelectedIndex = 0;
            LoadProData(); //Load products whenever page is loaded
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddProduct();
            
        }
        public void AddProduct()
        {
            //connection string
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=geemaxInventory;Integrated Security=True";
            conn.Open();

            using (conn)
            {

                string strQuery = "INSERT INTO [dbo].[products] ([product_code], [product_name], [product_costprice],[product_sellingP], [openingStock], [pro_discount], [productStatus], [vat], [pro_desc])" +
                "VALUES (@ProductCode, @ProductName, @ProductCostP, @ProductSellingP, @OpeningStock, @ProDiscount, @ProStatus, @Vat, @Description)";

                SqlCommand cmd = new SqlCommand(strQuery, conn);

                bool status = false;
                if (cmbStatus.SelectedIndex == 0)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
                cmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text);
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                cmd.Parameters.AddWithValue("@ProductCostP", txtCostPrice.Text);
                cmd.Parameters.AddWithValue("@ProductSellingP", txtSellingPrice.Text);
                cmd.Parameters.AddWithValue("@OpeningStock", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@ProDiscount", txtDiscount.Text);
                cmd.Parameters.AddWithValue("@ProStatus", status);
                cmd.Parameters.AddWithValue("@Vat", txtVat.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                try
                {
                    //Execute command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Products saved successfully..!", "Success", MessageBoxButtons.OK);
                    LoadProData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Data was not saved successfully!");
                }
            }

        }

        //Load products data in data grid
        public void LoadProData()
        {
            //Reading data
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=geemaxInventory;Integrated Security=True";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [dbo].[products]", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            ClearProData(); //Clear data for new entry
                            //clear the fields after adding them
            productDataGrid.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int data = productDataGrid.Rows.Add();
                productDataGrid.Rows[data].Cells[0].Value = item["product_code"].ToString();
                productDataGrid.Rows[data].Cells[1].Value = item["product_name"].ToString();
                productDataGrid.Rows[data].Cells[2].Value = item["openingStock"].ToString();

                if ((bool)item["productStatus"])
                {
                    productDataGrid.Rows[data].Cells[3].Value = "Available";
                }
                else
                {
                    productDataGrid.Rows[data].Cells[3].Value = "Not Available";
                }

            }

        }

        //Clear fields data and open new page for new entry
        public void ClearProData()
        {
            txtProductCode.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
            txtCostPrice.Clear();
            txtSellingPrice.Clear();
            txtVat.Clear();
            txtDiscount.Clear();
            txtDescription.Clear();    
        }

        private void productDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            txtProductCode.Text = productDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            txtProductName.Text = productDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            txtQuantity.Text = productDataGrid.SelectedRows[0].Cells[2].Value.ToString();

            if (productDataGrid.SelectedRows[0].Cells[3].Value.ToString() == "Active")
            {
                cmbStatus.SelectedIndex = 0;
            }
            else
            {
                cmbStatus.SelectedIndex = 1;
            }
            

        }
        //Close products page
        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        //Delete products
        private void btnDeletePro_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
