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
    public partial class Voucher : Form
    {
        public Voucher()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //close the form
        private void btnVouClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
