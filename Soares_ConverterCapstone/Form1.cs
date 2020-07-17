using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soares_ConverterCapstone
{
    public partial class frmConverter : Form
    {
        EnglishToMetric con = new EnglishToMetric();
        MetricToEnglish conv = new MetricToEnglish();
        double kilometers, meters, centimeters, inches, feet, yards;
        public frmConverter()
        {
            InitializeComponent();
        }

        private void txtKilometers_TextChanged(object sender, EventArgs e)
        {
            //Convert.ToDouble(txtKilometers.Text);
        }

        private void txtMeters_TextChanged(object sender, EventArgs e)
        {
            //Convert.ToDouble(txtMeters.Text);
        }

        private void txtCentimeters_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            kilometers = Convert.ToDouble(txtKilometers.Text);
            txtMeters.Text = conv.convertKilometersToMeters(kilometers);

            meters = Convert.ToDouble(txtMeters.Text);
            txtCentimeters.Text = conv.convertMetersToCentimeters(meters);

            centimeters = Convert.ToDouble(txtCentimeters.Text);
            txtInches.Text = conv.convertCentimetersToTotalInches(centimeters);

            inches = Convert.ToDouble(txtInches.Text);
            txtFeet.Text = conv.convertTotalInchesToTotalFeet(inches);

            feet = Convert.ToDouble(txtFeet.Text);
            txtYards.Text = conv.convertTotalFeetToYards(feet);

            yards = Convert.ToDouble(txtYards.Text);
            txtMiles.Text = conv.convertYardsToMiles(yards);

        }

        private void lblInches_Click(object sender, EventArgs e)
        {

        }

        private void lblFeet_Click(object sender, EventArgs e)
        {

        }

        private void lblYards_Click(object sender, EventArgs e)
        {

        }

        private void lblMiles_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKilometers.Clear();
            txtMeters.Clear();
            txtCentimeters.Clear();
            txtInches.Clear();
            txtFeet.Clear();
            txtYards.Clear();
            txtMiles.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtInches_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtMiles_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lblKilometers_Click_1(object sender, EventArgs e)
        {
            kilometers = Convert.ToDouble(txtKilometers.Text);
        }

        private void lblMeters_Click_1(object sender, EventArgs e)
        {
            meters = Convert.ToDouble(txtMeters.Text);
        }

        private void lblCentimeters_Click_1(object sender, EventArgs e)
        {
            centimeters = Convert.ToDouble(txtCentimeters.Text);
        }
    }
}
