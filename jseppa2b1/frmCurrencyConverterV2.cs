using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jseppa2b1
{
    public partial class frmCurrencyConverterV2 : Form
    {
        public frmCurrencyConverterV2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = Convert.ToDecimal(txtAmountAustralia.Text);
            decimal rateAustralia = Convert.ToDecimal(txtRateAustralia.Text);
            decimal usdAustralia = amountAustralia * rateAustralia;
            txtUSDAustralia.Text = usdAustralia.ToString("0.00");

            decimal amountBhutan = Convert.ToDecimal(txtAmountBhutan.Text);
            decimal rateBhutan = Convert.ToDecimal(txtRateBhutan.Text);
            decimal usdBhutan = amountBhutan * rateBhutan;
            txtUSDBhutan.Text = usdBhutan.ToString("0.00");

            decimal amountIsrael = Convert.ToDecimal(txtAmountIsrael.Text);
            decimal rateIsrael = Convert.ToDecimal(txtRateIsrael.Text);
            decimal usdIsrael = amountIsrael * rateIsrael;
            txtUSDIsrael.Text = usdIsrael.ToString("0.00");

            decimal amountBrazil = Convert.ToDecimal(txtAmountBrazil.Text);
            decimal rateBrazil = Convert.ToDecimal(txtRateBrazil.Text);
            decimal usdBrazil = amountBrazil * rateBrazil;
            txtUSDBrazil.Text = usdBrazil.ToString("0.00");

            decimal totalUSD = usdAustralia + usdBhutan + usdIsrael + usdBrazil;
            txtTotalUSD.Text = totalUSD.ToString("0.00");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.722895";
            txtAmountBhutan.Text = "0.00";
            txtRateBhutan.Text = "0.0136816";
            txtAmountIsrael.Text = "0.00";
            txtRateIsrael.Text = "0.274885";
            txtAmountBrazil.Text = "0.00";
            txtRateBrazil.Text = "0.248975";
        }
    }
}
