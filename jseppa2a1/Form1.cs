using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jseppa2a1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToInt32(txtSubtotal.Text);
            txtSubtotal.Text = subtotal.ToString("0.00");

            decimal discountPercent = Convert.ToInt32(txtDiscountPercent.Text);
            txtDiscountPercent.Text = discountPercent.ToString("0.00");

            decimal discountAmount = (subtotal * discountPercent) / 100;
            txtDiscountAmount.Text = discountAmount.ToString("0.00");

            decimal total = subtotal - discountAmount;
            txtTotal.Text = total.ToString("0.00");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSubtotal.Text = "";
            txtDiscountPercent.Text = "";
            txtDiscountAmount.Text = "";
            txtTotal.Text = "";
        }
    }
}
