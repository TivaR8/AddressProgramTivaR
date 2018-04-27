namespace AddressProgramTivaR
{
    partial class frmAddressProgram
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
            this.lblAddressText = new System.Windows.Forms.Label();
            this.lblCityText = new System.Windows.Forms.Label();
            this.lblPostalCodeText = new System.Windows.Forms.Label();
            this.lblUnitText = new System.Windows.Forms.Label();
            this.lblProvinceText = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddressText
            // 
            this.lblAddressText.AutoSize = true;
            this.lblAddressText.Location = new System.Drawing.Point(22, 32);
            this.lblAddressText.Name = "lblAddressText";
            this.lblAddressText.Size = new System.Drawing.Size(48, 13);
            this.lblAddressText.TabIndex = 0;
            this.lblAddressText.Text = "Address:";
            // 
            // lblCityText
            // 
            this.lblCityText.AutoSize = true;
            this.lblCityText.Location = new System.Drawing.Point(22, 83);
            this.lblCityText.Name = "lblCityText";
            this.lblCityText.Size = new System.Drawing.Size(27, 13);
            this.lblCityText.TabIndex = 1;
            this.lblCityText.Text = "City:";
            // 
            // lblPostalCodeText
            // 
            this.lblPostalCodeText.AutoSize = true;
            this.lblPostalCodeText.Location = new System.Drawing.Point(22, 129);
            this.lblPostalCodeText.Name = "lblPostalCodeText";
            this.lblPostalCodeText.Size = new System.Drawing.Size(67, 13);
            this.lblPostalCodeText.TabIndex = 2;
            this.lblPostalCodeText.Text = "Postal Code:";
            // 
            // lblUnitText
            // 
            this.lblUnitText.AutoSize = true;
            this.lblUnitText.Location = new System.Drawing.Point(330, 32);
            this.lblUnitText.Name = "lblUnitText";
            this.lblUnitText.Size = new System.Drawing.Size(29, 13);
            this.lblUnitText.TabIndex = 3;
            this.lblUnitText.Text = "Unit:";
            // 
            // lblProvinceText
            // 
            this.lblProvinceText.AutoSize = true;
            this.lblProvinceText.Location = new System.Drawing.Point(330, 83);
            this.lblProvinceText.Name = "lblProvinceText";
            this.lblProvinceText.Size = new System.Drawing.Size(52, 13);
            this.lblProvinceText.TabIndex = 4;
            this.lblProvinceText.Text = "Province:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(115, 25);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(184, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(115, 76);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(138, 20);
            this.txtCity.TabIndex = 6;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(115, 122);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(111, 20);
            this.txtPostalCode.TabIndex = 7;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(379, 28);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(74, 20);
            this.txtUnit.TabIndex = 8;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(389, 77);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(100, 20);
            this.txtProvince.TabIndex = 9;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(207, 171);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // frmAddressProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 215);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblProvinceText);
            this.Controls.Add(this.lblUnitText);
            this.Controls.Add(this.lblPostalCodeText);
            this.Controls.Add(this.lblCityText);
            this.Controls.Add(this.lblAddressText);
            this.Name = "frmAddressProgram";
            this.Text = "Address Program By Tiva Rait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddressText;
        private System.Windows.Forms.Label lblCityText;
        private System.Windows.Forms.Label lblPostalCodeText;
        private System.Windows.Forms.Label lblUnitText;
        private System.Windows.Forms.Label lblProvinceText;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Button btnEnter;
    }
}

