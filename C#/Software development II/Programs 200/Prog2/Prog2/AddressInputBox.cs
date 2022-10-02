//Student ID:5461407
//CIS200-50
//Program2
//Due: 10/25/2021
//This form manages and validates the input for addresses 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class AddressInputBox : Form
    {
        public AddressInputBox()
        {
            InitializeComponent();
        }

        internal string InputValueName // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Name is returned
            get
            {
                return textBoxName.Text;
            }

            // Precondition:  None
            // Postcondition: Text in textboxName is set to specified value
            set { textBoxName.Text = value; }
        }

        internal string InputValueLine1 // Can be accessed by other classes in same namespace
        {  // Precondition:  None
           // Postcondition: Address line1 is returned
            get { return textBoxLine1.Text; }

            // Precondition:  None
            // Postcondition: Text in textBoxLine1 is set to specified value
            set { textBoxLine1.Text = value; }
        }

        internal string InputValueLine2 // Can be accessed by other classes in same namespace
        {  // Precondition:  None
           // Postcondition: Address line2 is returned
            get { return textBoxLine2.Text; }

            // Precondition:  None
            // Postcondition: Text in textBoxLine2 is set to specified value
            set { textBoxLine2.Text = value; }
        }


        internal string InputValueCity // Can be accessed by other classes in same namespace
        {  // Precondition:  None
           // Postcondition: Address city is returned
            get { return textBoxCity.Text; }

            // Precondition:  None
            // Postcondition: Text in textBoxCity is set to specified value
            set { textBoxCity.Text = value; }
        }

        internal string InputValueState // Can be accessed by other classes in same namespace
        {  // Precondition:  None
           // Postcondition: Address state is returned
            get { return comboBoxState.Text; }

            // Precondition:  None
            // Postcondition: Text in comboboxState is set to specified value
            set { comboBoxState.Text = value; }
        }

        internal string InputValueZip // Can be accessed by other classes in same namespace
        {  // Precondition:  None
           // Postcondition: Address zip is returned
            get { return textBoxZip.Text; }

            // Precondition:  None
            // Postcondition: Text in textBoxZip is set to specified value
            set { textBoxZip.Text = value; }
        }

        private void comboBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
           //double clicked by accident
        }

        //A click event to insert the entered address
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        //validtes if the textbox is empty or white space
        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                e.Cancel = true;
                errorProviderAddress.SetError(textBoxName, "Please enter a name!"); // Set error message
            }
           
        }


        // Clears error message
        private void textBoxName_Validated(object sender, EventArgs e)
        {
            errorProviderAddress.SetError(textBoxName, ""); // Clears error message
        }

        //validtes if the textbox is empty or white space
        private void textBoxLine1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLine1.Text))
            {
                e.Cancel = true;
                errorProviderAddress.SetError(textBoxLine1, "Please enter line1 of the address!"); // Set error message
            }
        }


        private void textBoxLine2_TextChanged(object sender, EventArgs e)
        {//double clicked by accident, please ignore it!      
        }

        //validtes if the textbox is empty or white space
        private void textBoxCity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCity.Text))
            {
                e.Cancel = true;
                errorProviderAddress.SetError(textBoxCity, "Please enter city of the address!"); // Set error message
            }
        }

        private void textBoxCity_Validated(object sender, EventArgs e)
        {
            errorProviderAddress.SetError(textBoxCity, ""); // Clears error message
        }

        private void textBoxLine1_Validated(object sender, EventArgs e)
        {
            errorProviderAddress.SetError(textBoxLine1, ""); // Clears error message
        }

        //validates if the user selects a state
        private void comboBoxState_Validating(object sender, CancelEventArgs e)
        {

            if (comboBoxState.SelectedIndex ==-1) 
            {
                e.Cancel = true;
                errorProviderAddress.SetError(textBoxCity, "Please select a state of the address!"); // Set error message
            }
        }

        private void comboBoxState_Validated(object sender, EventArgs e)
        {
            errorProviderAddress.SetError(comboBoxState, ""); // Clears error message
        }

        //validtes if the textbox is empty or white space
        private void textBoxZip_Validating(object sender, CancelEventArgs e)
        {
            int zip;
            if (!int.TryParse(textBoxZip.Text, out zip) )
            {
                e.Cancel = true;
                errorProviderAddress.SetError(textBoxZip, "Please enter zip code of the address!"); // Set error message
            }
            else
                if(zip < 0 || zip > 99999) //zipcode needs to be between 00000 to 99999
            {
                e.Cancel = true;
                errorProviderAddress.SetError(textBoxZip, "Zip code should be between 00000 to 99999!"); // Set error message
            }
        }

        private void textBoxZip_Validated(object sender, EventArgs e)
        {
            errorProviderAddress.SetError(textBoxZip, ""); // Clears error message
        }

        //cancel the address insertion 
        private void btnCancel_Click(object sender, EventArgs e)
        {
             this.DialogResult = DialogResult.Cancel; 
        }
    }
}
