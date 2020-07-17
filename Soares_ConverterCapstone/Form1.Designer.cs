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
            this.txtKilometers = new System.Windows.Forms.TextBox();
            this.txtMeters = new System.Windows.Forms.TextBox();
            this.txtCentimeters = new System.Windows.Forms.TextBox();
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
            this.lblKilometers = new System.Windows.Forms.Label();
            this.lblMeters = new System.Windows.Forms.Label();
            this.lblCentimeters = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKilometers
            // 
            this.txtKilometers.Location = new System.Drawing.Point(63, 42);
            this.txtKilometers.Name = "txtKilometers";
            this.txtKilometers.Size = new System.Drawing.Size(182, 20);
            this.txtKilometers.TabIndex = 0;
            this.txtKilometers.TextChanged += new System.EventHandler(this.txtKilometers_TextChanged);
            // 
            // txtMeters
            // 
            this.txtMeters.Location = new System.Drawing.Point(300, 42);
            this.txtMeters.Name = "txtMeters";
            this.txtMeters.Size = new System.Drawing.Size(182, 20);
            this.txtMeters.TabIndex = 4;
            this.txtMeters.TextChanged += new System.EventHandler(this.txtMeters_TextChanged);
            // 
            // txtCentimeters
            // 
            this.txtCentimeters.Location = new System.Drawing.Point(530, 42);
            this.txtCentimeters.Name = "txtCentimeters";
            this.txtCentimeters.Size = new System.Drawing.Size(182, 20);
            this.txtCentimeters.TabIndex = 5;
            this.txtCentimeters.TextChanged += new System.EventHandler(this.txtCentimeters_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(63, 125);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(649, 54);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtInches
            // 
            this.txtInches.Location = new System.Drawing.Point(63, 221);
            this.txtInches.Name = "txtInches";
            this.txtInches.Size = new System.Drawing.Size(129, 20);
            this.txtInches.TabIndex = 7;
            this.txtInches.TextChanged += new System.EventHandler(this.txtInches_TextChanged_1);
            // 
            // txtFeet
            // 
            this.txtFeet.Location = new System.Drawing.Point(235, 221);
            this.txtFeet.Name = "txtFeet";
            this.txtFeet.Size = new System.Drawing.Size(129, 20);
            this.txtFeet.TabIndex = 8;
            // 
            // txtYards
            // 
            this.txtYards.Location = new System.Drawing.Point(405, 221);
            this.txtYards.Name = "txtYards";
            this.txtYards.Size = new System.Drawing.Size(129, 20);
            this.txtYards.TabIndex = 9;
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(583, 221);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(129, 20);
            this.txtMiles.TabIndex = 10;
            this.txtMiles.TextChanged += new System.EventHandler(this.txtMiles_TextChanged);
            // 
            // lblInches
            // 
            this.lblInches.AutoSize = true;
            this.lblInches.Location = new System.Drawing.Point(93, 269);
            this.lblInches.Name = "lblInches";
            this.lblInches.Size = new System.Drawing.Size(39, 13);
            this.lblInches.TabIndex = 11;
            this.lblInches.Text = "Inches";
            this.lblInches.Click += new System.EventHandler(this.lblInches_Click);
            // 
            // lblFeet
            // 
            this.lblFeet.AutoSize = true;
            this.lblFeet.Location = new System.Drawing.Point(279, 269);
            this.lblFeet.Name = "lblFeet";
            this.lblFeet.Size = new System.Drawing.Size(28, 13);
            this.lblFeet.TabIndex = 12;
            this.lblFeet.Text = "Feet";
            this.lblFeet.Click += new System.EventHandler(this.lblFeet_Click);
            // 
            // lblYards
            // 
            this.lblYards.AutoSize = true;
            this.lblYards.Location = new System.Drawing.Point(448, 269);
            this.lblYards.Name = "lblYards";
            this.lblYards.Size = new System.Drawing.Size(34, 13);
            this.lblYards.TabIndex = 13;
            this.lblYards.Text = "Yards";
            this.lblYards.Click += new System.EventHandler(this.lblYards_Click);
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(636, 269);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(31, 13);
            this.lblMiles.TabIndex = 14;
            this.lblMiles.Text = "Miles";
            this.lblMiles.Click += new System.EventHandler(this.lblMiles_Click);
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
            // lblKilometers
            // 
            this.lblKilometers.AutoSize = true;
            this.lblKilometers.Location = new System.Drawing.Point(122, 75);
            this.lblKilometers.Name = "lblKilometers";
            this.lblKilometers.Size = new System.Drawing.Size(55, 13);
            this.lblKilometers.TabIndex = 17;
            this.lblKilometers.Text = "Kilometers";
            this.lblKilometers.Click += new System.EventHandler(this.lblKilometers_Click_1);
            // 
            // lblMeters
            // 
            this.lblMeters.AutoSize = true;
            this.lblMeters.Location = new System.Drawing.Point(368, 75);
            this.lblMeters.Name = "lblMeters";
            this.lblMeters.Size = new System.Drawing.Size(39, 13);
            this.lblMeters.TabIndex = 18;
            this.lblMeters.Text = "Meters";
            this.lblMeters.Click += new System.EventHandler(this.lblMeters_Click_1);
            // 
            // lblCentimeters
            // 
            this.lblCentimeters.AutoSize = true;
            this.lblCentimeters.Location = new System.Drawing.Point(601, 75);
            this.lblCentimeters.Name = "lblCentimeters";
            this.lblCentimeters.Size = new System.Drawing.Size(62, 13);
            this.lblCentimeters.TabIndex = 19;
            this.lblCentimeters.Text = "Centimeters";
            this.lblCentimeters.Click += new System.EventHandler(this.lblCentimeters_Click_1);
            // 
            // frmConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCentimeters);
            this.Controls.Add(this.lblMeters);
            this.Controls.Add(this.lblKilometers);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.lblYards);
            this.Controls.Add(this.lblFeet);
            this.Controls.Add(this.lblInches);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.txtYards);
            this.Controls.Add(this.txtFeet);
            this.Controls.Add(this.txtInches);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtCentimeters);
            this.Controls.Add(this.txtMeters);
            this.Controls.Add(this.txtKilometers);
            this.Name = "frmConverter";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKilometers;
        private System.Windows.Forms.TextBox txtMeters;
        private System.Windows.Forms.TextBox txtCentimeters;
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
        private System.Windows.Forms.Label lblKilometers;
        private System.Windows.Forms.Label lblMeters;
        private System.Windows.Forms.Label lblCentimeters;
    }
}

