using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jseppa1f1
{
    public partial class frmCurrency : Form
    {
        public frmCurrency()
        {
            InitializeComponent();
        }


        private void frmCurrency_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            lblCurrency.Text = "Australian Dollar" + ": ";
            txtRate.Text = "0.711178";
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnIsrael.BackgroundImage = picIsraelDim.Image;
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtUSDollars.Text = "0.00";
            txtTotalUSDollars.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            lblCurrency.Text = "Australian Dollar" + ": ";
            txtRate.Text = "0.711178";
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnIsrael.BackgroundImage = picIsraelDim.Image;
            txtCurrency.Focus();
        }

        private void btnBhutan_Click(object sender, EventArgs e)
        {
            lblCurrency.Text = "Bhutanese Ngultrum" + ": ";
            txtRate.Text = "0.0137809";
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnIsrael.BackgroundImage = picIsraelDim.Image;
            txtCurrency.Focus();

        }

        private void btnBrazil_Click(object sender, EventArgs e)
        {
            lblCurrency.Text = "Brazilian Real" + ": ";
            txtRate.Text = "0.244712";
            btnBrazil.BackgroundImage = picBrazil.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnIsrael.BackgroundImage = picIsraelDim.Image;
            txtCurrency.Focus();
        }

        private void btnIsrael_Click(object sender, EventArgs e)
        {
            lblCurrency.Text = "Israeli Shekel" + ": ";
            txtRate.Text = "0.279117";
            btnIsrael.BackgroundImage = picIsrael.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            txtCurrency.Focus();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text =
                (Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text))
                .ToString("0.00");
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTotalUSDollars.Text = (
                Convert.ToDecimal(txtTotalUSDollars.Text) + Convert.ToDecimal(txtUSDollars.Text)
                ).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnIsrael.BackgroundImage = picIsraelDim.Image;
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.717976";
            txtUSDollars.Text = "0.00";
            txtTotalUSDollars.Text = "0.00";
            lblEquation.Text = "";
            txtCurrency.Focus();
        }
    }
}
