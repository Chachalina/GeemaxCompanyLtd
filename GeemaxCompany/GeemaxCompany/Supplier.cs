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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'geemaxInventoryCityDataSet1.Cities' table. You can move, or remove it, as needed.
            this.citiesTableAdapter.Fill(this.geemaxInventoryCityDataSet1.Cities);
            // TODO: This line of code loads data into the 'geemaxInventoryDataSet.states' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.geemaxInventoryDataSet.states);

        }

        private void btnSupSave_Click(object sender, EventArgs e)
        {
            SupplierSave();
        }
        //save suppliers
        public void SupplierSave()
        {
            //connection string
             SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=geemaxInventory;Integrated Security=True";
            conn.Open();

            using (conn)
            {

                string strQuery = "INSERT INTO[dbo].[suppliers] ([supplier_name],[sup_address],[state_id],[city_id],[contact_num],[email_address],[website],[remarks])" +
                "VALUES (@SupplierName, @SupAddress, @SupState, @SupCity, @SupContact, @SupEmail, @SupWebsite, @SupRemarks)";

                SqlCommand cmd = new SqlCommand(strQuery, conn);
                
                cmd.Parameters.AddWithValue("@SupplierName", txtSupName.Text);
                cmd.Parameters.AddWithValue("@SupAddress", txtSupAddress.Text);
                cmd.Parameters.AddWithValue("@SupState", cmbSupState.SelectedIndex);
                cmd.Parameters.AddWithValue("@SupCity", cmbCity.SelectedIndex);
                cmd.Parameters.AddWithValue("@SupContact", txtSupContact.Text);
                cmd.Parameters.AddWithValue("@SupEmail", txtSupEmail.Text);
                cmd.Parameters.AddWithValue("@SupWebsite", txtSupWebsite.Text);
                cmd.Parameters.AddWithValue("@SupRemarks", txtSupRemarks.Text);
                try
                {
                    //Execute command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Products saved successfully..!", "Success", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Data was not saved successfully!");
                }
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.statesTableAdapter.Fill(this.geemaxInventoryDataSet.states);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.citiesTableAdapter.FillBy(this.geemaxInventoryCityDataSet1.Cities);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
