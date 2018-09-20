using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sbraaten1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
               Convert.ToDecimal(txtAmountAustralia.Text) * Convert.ToDecimal(txtRateAustralia.Text)
               ).ToString("0.00");
        }

        private void guyaneseTextChanged(object sender, EventArgs e)
        {
            txtUSDGuyanese.Text = (
                Convert.ToDecimal(txtAmountGuyanese.Text) * Convert.ToDecimal(txtRateGuyanese.Text)
                ).ToString("0.00");
        }

        private void kuwaitTextChanged(object sender, EventArgs e)
        {
            txtUSDKuwait.Text = (
                Convert.ToDecimal(txtAmountKuwait.Text) * Convert.ToDecimal(txtRateKuwait.Text)
                ).ToString("0.00");
        }

        private void swedishTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
               Convert.ToDecimal(txtAmountSwedish.Text) * Convert.ToDecimal(txtRateSwedish.Text)
               ).ToString("0.00");
        }

        private void USDTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (Convert.ToDecimal(txtUSDAustralia.Text) + 
                Convert.ToDecimal(txtUSDGuyanese.Text) +
                Convert.ToDecimal(txtUSDKuwait.Text) +
                Convert.ToDecimal(txtUSDSwedish.Text)

                ).ToString("0.00");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.726810";

            txtAmountGuyanese.Text = "0.00";
            txtRateGuyanese.Text = "0.00478123";

            txtAmountKuwait.Text = "0.00";
            txtRateKuwait.Text = "3.29926";

            txtAmountSwedish.Text = "0.00";
            txtRateSwedish.Text = "0.11291";

        }
    }
}
