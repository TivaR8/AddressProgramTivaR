using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 27-04-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Optional Parameters
 * This program lets a user enter their adress and then displays a message box with the address entered
*/

namespace AddressProgramTivaR
{
    public partial class frmAddressProgram : Form
    {
        public frmAddressProgram()
        {
            InitializeComponent();
        }

        // Procedure: PrintAddress
        // Input: String address, city, postalCode, unit, province
        // Output: void
        // Description: this procedure displays a message box with the user's address
        public void PrintAddress(String address, String city, String postalCode, String unit, String province)
        {
            MessageBox.Show(" Your Address is: " + address + ", Unit: " + unit + " " + city + ", " + province + " " + postalCode, "Address Program");
           
        }

        // Procedure: PrintAddress
        // Input: String address, city, postalCode, province
        // Output: void
        // Description: this procedure displays a message box with the user's address
        public void PrintAddress(String address, String city, String postalCode, String province)
        {
            MessageBox.Show(" Your Address is: " + address + " " + city + ", " + province + " " + postalCode, "Address Program");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //  Declare local variables
            String userAddress, userCity, userPostalCode, userUnit, userProvince;

            // Get the info from text boxes
            userAddress = this.txtAddress.Text;
            userCity = this.txtCity.Text;
            userPostalCode = this.txtPostalCode.Text;
            userUnit = this.txtUnit.Text;
            userProvince = this.txtProvince.Text;

            // Make sure user entered valid address
            if (userAddress == "")
            {
                MessageBox.Show("Please enter a valid address", "Address Program");
            }
            // Make sure user entered valid city
            else if (userCity == "")
            {
                MessageBox.Show("Please enter a valid city", "Address Program");
            }
            // Make sure user entered valid Postal Code
            else if (userPostalCode == "")
            {
                MessageBox.Show("Please enter a valid postal code", "Address Program");
            }
            // Make sure user entered valid 
            else if (userProvince == "")
            {
                MessageBox.Show("Please enter a valid province", "Address Program");
            }
            // If user didn't input a unit call the procedure that didn't require a unit
            else if (userUnit == "")
            {
                PrintAddress(userAddress, userCity, userPostalCode, userProvince);
            }
            else
            {
                PrintAddress(userAddress, userCity, userPostalCode, userUnit, userProvince);
            }
            

        }
    }
}
