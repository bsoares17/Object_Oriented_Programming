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

        public frmConverter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (noChoiceMade())
                return;

            if (optEnglishToMetric.Checked || optMetricToEnglish.Checked)
            {
                dealWithBlankInputBoxes();
            }

            if (optMetricToEnglish.Checked)
            {
                MetricToEnglish mte = new MetricToEnglish(txtKilometers.Text, txtMeters.Text, txtCentimeters.Text);
                populateEnglishOutputBoxesWithConvertedValues(mte);
            }

            else
            {

                EnglishToMetric etm = new EnglishToMetric(txtInches.Text, txtFeet.Text, txtYards.Text, txtMiles.Text);
                populateMetricOutputBoxesWithConvertedValues(etm);
            }

        }

        private bool noChoiceMade()
        {
            if (!(optEnglishToMetric.Checked || optMetricToEnglish.Checked))
            {
                grpEnglish.Visible = false;
                grpMetric.Visible = false;
                btnConvert.Visible = false;

                return true;
            }

            return false;

        }

        private void frmConverter_Load(object sender, EventArgs e)
        {
            grpEnglish.Enabled = false;
            grpMetric.Enabled = false;
            btnConvert.Enabled = false;
        }

        private void optMetricToEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (optMetricToEnglish.Checked)
            {
                grpMetric.Enabled = true;
                grpEnglish.Visible = false;
                btnConvert.Enabled = true;
            }
        }

        private void optEnglishToMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (optEnglishToMetric.Checked)
            {
                btnConvert.Enabled = true;
                grpEnglish.Enabled = true;
                grpMetric.Visible = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (grpEnglish.Enabled)
            {
                grpOptions.Visible = false;
            }
        }

        private void populateEnglishOutputBoxesWithConvertedValues(MetricToEnglish mte)
        {
            grpEnglish.Visible = true;

            txtMiles.Text = mte.getMiles();
            txtYards.Text = mte.getYards();
            txtInches.Text = mte.getInches();
            txtFeet.Text = mte.getFeet();
        }

        private void populateMetricOutputBoxesWithConvertedValues(EnglishToMetric etm)
        {
            grpMetric.Visible = true;

            txtKilometers.Text = etm.getKilometers();
            txtMeters.Text = etm.getMeters();
            txtCentimeters.Text = etm.getCentimeters();
        }

        private void dealWithBlankInputBoxes()
        {
            if (txtKilometers.Text.Length == 0)
                txtKilometers.Text = "0";
            if (txtMeters.Text.Length == 0)
                txtMeters.Text = "0";
            if (txtCentimeters.Text.Length == 0)
                txtCentimeters.Text = "0.0";
            if (txtInches.Text.Length == 0)
                txtInches.Text = "0.0";
            if (txtFeet.Text.Length == 0)
                txtFeet.Text = "0";
            if (txtYards.Text.Length == 0)
                txtYards.Text = "0";
            if (txtMiles.Text.Length == 0)
                txtMiles.Text = "0";
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

        private void txtKilometers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtMeters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtCentimeters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtMiles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtYards_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtFeet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtInches_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}
