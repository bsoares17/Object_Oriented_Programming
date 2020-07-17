namespace Soares_ConverterCapstone
{
    partial class frmConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtInches = new System.Windows.Forms.TextBox();
            this.txtFeet = new System.Windows.Forms.TextBox();
            this.txtYards = new System.Windows.Forms.TextBox();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.lblInches = new System.Windows.Forms.Label();
            this.lblFeet = new System.Windows.Forms.Label();
            this.lblYards = new System.Windows.Forms.Label();
            this.lblMiles = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpEnglish = new System.Windows.Forms.GroupBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.optMetricToEnglish = new System.Windows.Forms.RadioButton();
            this.optEnglishToMetric = new System.Windows.Forms.RadioButton();
            this.grpMetric = new System.Windows.Forms.GroupBox();
            this.lblCentimeters = new System.Windows.Forms.Label();
            this.lblMeters = new System.Windows.Forms.Label();
            this.lblKilometers = new System.Windows.Forms.Label();
            this.txtCentimeters = new System.Windows.Forms.TextBox();
            this.txtMeters = new System.Windows.Forms.TextBox();
            this.txtKilometers = new System.Windows.Forms.TextBox();
            this.grpEnglish.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.grpMetric.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 125);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(776, 54);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtInches
            // 
            this.txtInches.Location = new System.Drawing.Point(571, 29);
            this.txtInches.Name = "txtInches";
            this.txtInches.Size = new System.Drawing.Size(129, 20);
            this.txtInches.TabIndex = 7;
            this.txtInches.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInches_KeyPress);
            // 
            // txtFeet
            // 
            this.txtFeet.Location = new System.Drawing.Point(408, 29);
            this.txtFeet.Name = "txtFeet";
            this.txtFeet.Size = new System.Drawing.Size(129, 20);
            this.txtFeet.TabIndex = 8;
            this.txtFeet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFeet_KeyPress);
            // 
            // txtYards
            // 
            this.txtYards.Location = new System.Drawing.Point(239, 29);
            this.txtYards.Name = "txtYards";
            this.txtYards.Size = new System.Drawing.Size(129, 20);
            this.txtYards.TabIndex = 9;
            this.txtYards.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYards_KeyPress);
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(51, 29);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(129, 20);
            this.txtMiles.TabIndex = 10;
            this.txtMiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiles_KeyPress);
            // 
            // lblInches
            // 
            this.lblInches.AutoSize = true;
            this.lblInches.Location = new System.Drawing.Point(618, 52);
            this.lblInches.Name = "lblInches";
            this.lblInches.Size = new System.Drawing.Size(39, 13);
            this.lblInches.TabIndex = 11;
            this.lblInches.Text = "Inches";
            // 
            // lblFeet
            // 
            this.lblFeet.AutoSize = true;
            this.lblFeet.Location = new System.Drawing.Point(455, 52);
            this.lblFeet.Name = "lblFeet";
            this.lblFeet.Size = new System.Drawing.Size(28, 13);
            this.lblFeet.TabIndex = 12;
            this.lblFeet.Text = "Feet";
            // 
            // lblYards
            // 
            this.lblYards.AutoSize = true;
            this.lblYards.Location = new System.Drawing.Point(279, 52);
            this.lblYards.Name = "lblYards";
            this.lblYards.Size = new System.Drawing.Size(34, 13);
            this.lblYards.TabIndex = 13;
            this.lblYards.Text = "Yards";
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(88, 52);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(31, 13);
            this.lblMiles.TabIndex = 14;
            this.lblMiles.Text = "Miles";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(679, 397);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(25, 397);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpEnglish
            // 
            this.grpEnglish.Controls.Add(this.txtFeet);
            this.grpEnglish.Controls.Add(this.txtInches);
            this.grpEnglish.Controls.Add(this.txtYards);
            this.grpEnglish.Controls.Add(this.txtMiles);
            this.grpEnglish.Controls.Add(this.lblInches);
            this.grpEnglish.Controls.Add(this.lblFeet);
            this.grpEnglish.Controls.Add(this.lblMiles);
            this.grpEnglish.Controls.Add(this.lblYards);
            this.grpEnglish.Location = new System.Drawing.Point(12, 195);
            this.grpEnglish.Name = "grpEnglish";
            this.grpEnglish.Size = new System.Drawing.Size(776, 109);
            this.grpEnglish.TabIndex = 20;
            this.grpEnglish.TabStop = false;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.optMetricToEnglish);
            this.grpOptions.Controls.Add(this.optEnglishToMetric);
            this.grpOptions.Location = new System.Drawing.Point(294, 320);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(245, 100);
            this.grpOptions.TabIndex = 21;
            this.grpOptions.TabStop = false;
            // 
            // optMetricToEnglish
            // 
            this.optMetricToEnglish.AutoSize = true;
            this.optMetricToEnglish.Location = new System.Drawing.Point(18, 53);
            this.optMetricToEnglish.Name = "optMetricToEnglish";
            this.optMetricToEnglish.Size = new System.Drawing.Size(196, 17);
            this.optMetricToEnglish.TabIndex = 1;
            this.optMetricToEnglish.Text = "convert Metric Units to English Units";
            this.optMetricToEnglish.UseVisualStyleBackColor = true;
            this.optMetricToEnglish.CheckedChanged += new System.EventHandler(this.optMetricToEnglish_CheckedChanged);
            // 
            // optEnglishToMetric
            // 
            this.optEnglishToMetric.AutoSize = true;
            this.optEnglishToMetric.Location = new System.Drawing.Point(18, 19);
            this.optEnglishToMetric.Name = "optEnglishToMetric";
            this.optEnglishToMetric.Size = new System.Drawing.Size(196, 17);
            this.optEnglishToMetric.TabIndex = 0;
            this.optEnglishToMetric.Text = "convert English Units to Metric Units\r\n";
            this.optEnglishToMetric.UseVisualStyleBackColor = true;
            this.optEnglishToMetric.CheckedChanged += new System.EventHandler(this.optEnglishToMetric_CheckedChanged);
            // 
            // grpMetric
            // 
            this.grpMetric.Controls.Add(this.lblCentimeters);
            this.grpMetric.Controls.Add(this.lblMeters);
            this.grpMetric.Controls.Add(this.lblKilometers);
            this.grpMetric.Controls.Add(this.txtCentimeters);
            this.grpMetric.Controls.Add(this.txtMeters);
            this.grpMetric.Controls.Add(this.txtKilometers);
            this.grpMetric.Location = new System.Drawing.Point(12, 21);
            this.grpMetric.Name = "grpMetric";
            this.grpMetric.Size = new System.Drawing.Size(776, 85);
            this.grpMetric.TabIndex = 22;
            this.grpMetric.TabStop = false;
            // 
            // lblCentimeters
            // 
            this.lblCentimeters.AutoSize = true;
            this.lblCentimeters.Location = new System.Drawing.Point(582, 52);
            this.lblCentimeters.Name = "lblCentimeters";
            this.lblCentimeters.Size = new System.Drawing.Size(62, 13);
            this.lblCentimeters.TabIndex = 25;
            this.lblCentimeters.Text = "Centimeters";
            // 
            // lblMeters
            // 
            this.lblMeters.AutoSize = true;
            this.lblMeters.Location = new System.Drawing.Point(344, 52);
            this.lblMeters.Name = "lblMeters";
            this.lblMeters.Size = new System.Drawing.Size(39, 13);
            this.lblMeters.TabIndex = 24;
            this.lblMeters.Text = "Meters";
            // 
            // lblKilometers
            // 
            this.lblKilometers.AutoSize = true;
            this.lblKilometers.Location = new System.Drawing.Point(103, 52);
            this.lblKilometers.Name = "lblKilometers";
            this.lblKilometers.Size = new System.Drawing.Size(55, 13);
            this.lblKilometers.TabIndex = 23;
            this.lblKilometers.Text = "Kilometers";
            // 
            // txtCentimeters
            // 
            this.txtCentimeters.Location = new System.Drawing.Point(518, 19);
            this.txtCentimeters.Name = "txtCentimeters";
            this.txtCentimeters.Size = new System.Drawing.Size(182, 20);
            this.txtCentimeters.TabIndex = 22;
            this.txtCentimeters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCentimeters_KeyPress);
            // 
            // txtMeters
            // 
            this.txtMeters.Location = new System.Drawing.Point(277, 19);
            this.txtMeters.Name = "txtMeters";
            this.txtMeters.Size = new System.Drawing.Size(182, 20);
            this.txtMeters.TabIndex = 21;
            this.txtMeters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMeters_KeyPress);
            // 
            // txtKilometers
            // 
            this.txtKilometers.Location = new System.Drawing.Point(51, 19);
            this.txtKilometers.Name = "txtKilometers";
            this.txtKilometers.Size = new System.Drawing.Size(182, 20);
            this.txtKilometers.TabIndex = 20;
            this.txtKilometers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKilometers_KeyPress);
            // 
            // frmConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.grpMetric);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpEnglish);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Name = "frmConverter";
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.frmConverter_Load);
            this.grpEnglish.ResumeLayout(false);
            this.grpEnglish.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpMetric.ResumeLayout(false);
            this.grpMetric.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtInches;
        private System.Windows.Forms.TextBox txtFeet;
        private System.Windows.Forms.TextBox txtYards;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Label lblInches;
        private System.Windows.Forms.Label lblFeet;
        private System.Windows.Forms.Label lblYards;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpEnglish;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.RadioButton optMetricToEnglish;
        private System.Windows.Forms.RadioButton optEnglishToMetric;
        private System.Windows.Forms.GroupBox grpMetric;
        private System.Windows.Forms.Label lblCentimeters;
        private System.Windows.Forms.Label lblMeters;
        private System.Windows.Forms.Label lblKilometers;
        private System.Windows.Forms.TextBox txtCentimeters;
        private System.Windows.Forms.TextBox txtMeters;
        private System.Windows.Forms.TextBox txtKilometers;
    }
}

