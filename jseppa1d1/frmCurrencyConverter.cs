using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jseppa1d1
{
    public partial class frmCurrencyConverter : Form
    {
        public frmCurrencyConverter()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.711178";
            txtAmountBhutan.Text = "0.00";
            txtRateBhutan.Text = "0.0137809";
            txtAmountIsrael.Text = "0.00";
            txtRateIsrael.Text = "0.279117";
            txtAmountBrazil.Text = "0.00";
            txtRateBrazil.Text = "0.244712";

        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                             (Convert.ToDecimal(txtAmountAustralia.Text)) * (Convert.ToDecimal(txtRateAustralia.Text))
                            ).ToString("0.00");
        }

        private void bhutanTextChanged(object sender, EventArgs e)
        {
            txtUSDBhutan.Text = (
                            (Convert.ToDecimal(txtAmountBhutan.Text)) * (Convert.ToDecimal(txtRateBhutan.Text))
                            ).ToString("0.00");
        }

        private void israelTextChanged(object sender, EventArgs e)
        {
            txtUSDIsrael.Text = (
                            (Convert.ToDecimal(txtAmountIsrael.Text)) * (Convert.ToDecimal(txtRateIsrael.Text))
                            ).ToString("0.00");
        }

        private void brazilTextChanged(object sender, EventArgs e)
        {
            txtUSDBrazil.Text = (
                            (Convert.ToDecimal(txtAmountBrazil.Text)) * (Convert.ToDecimal(txtRateBrazil.Text))
                            ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                (Convert.ToDecimal(txtUSDAustralia.Text)) + (Convert.ToDecimal(txtUSDBhutan.Text)) + 
                (Convert.ToDecimal(txtUSDIsrael.Text)) + (Convert.ToDecimal(txtUSDBrazil.Text))
                ).ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
