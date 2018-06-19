using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeemaxCompany
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            product.MdiParent = this;
            product.Show();

        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier suppliers = new Supplier();
            suppliers.MdiParent = this;
            suppliers.Show();
        }

        private void stockInToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Stocks stockEntry = new Stocks();
            stockEntry.MdiParent = this;
            stockEntry.Show();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories category = new Categories();
            category.MdiParent = this;
            category.Show();
        }

        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            StockIn stockIn = new StockIn();
            stockIn.MdiParent = this;
            stockIn.Show();
        }

        private void voucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Voucher voucher = new Voucher();
            voucher.MdiParent = this;
            voucher.Show();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Billing purchases = new Billing();
            purchases.MdiParent = this;
            purchases.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.MdiParent = this;
            user.Show();
        }
    }
}
