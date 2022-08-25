//Student ID:5461407
//CIS200-50
//Program2
//Due: 10/25/2021
//This form manages and validates the input for letters

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
    public partial class LetterInputBox : Form
    {
        private List<Address> my_addresses; // a list of addresses

        public LetterInputBox()
        {
            InitializeComponent();
        }

      
        // Precondition:  None
        // Postcondition: a list of addresses can be passed to the comboxes
        public LetterInputBox(List<Address> add_in)
        {
            my_addresses = add_in; 
            InitializeComponent();
        }

        internal string InputValueCost // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Cost is returned
            get
            {
                return textBoxCost.Text;
            }

            // Precondition:  None
            // Postcondition: Cost in textboxCost is set to specified value
            set { textBoxCost.Text = value; }
        }

        internal int InputValueOrigin // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: An origin address is returned
            get
            {
                return comboBox1.SelectedIndex;
            }
        }

        internal int InputValueDestination // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: A destination address is returned
            get
            {
                return comboBox2.SelectedIndex;
            }

        }
        //A click event to cancel the letter insertion 
        private void btnCancel_Click(object sender, EventArgs e)
        {           
              this.DialogResult = DialogResult.Cancel;
        }

        //validtes if the zip is an int and not a negative int
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            decimal cost;
            if (!decimal.TryParse(textBoxCost.Text, out cost))
            {
                e.Cancel = true;
                errorProviderLetter.SetError(textBoxCost, "Please enter the fixed cost!"); // Set error message
            }
            else
                if (cost < 0 )//when the input is a negative number
            {
                e.Cancel = true;
                errorProviderLetter.SetError(textBoxCost, "Fixed cost must not be negative!"); // Set error message
            }
        }

        private void textBoxCost_Validated(object sender, EventArgs e)
        {
            errorProviderLetter.SetError(textBoxCost, ""); // Clears error message
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           //double clicked by accident
        }

        // valiedats if the users selects an address
        private void comboBox2_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProviderLetter.SetError(textBoxCost,
                    "Please select the destination address!"); // Set error message
            }
            else
            if (comboBox2.SelectedIndex == comboBox1.SelectedIndex)//origin and destination addresses can't be the same
            {
                e.Cancel = true;
                errorProviderLetter.SetError(textBoxCost,
                    "Differnt addresses must be selected!"); // Set error message
            }
        }

        private void comboBox2_Validated(object sender, EventArgs e)
        {
            errorProviderLetter.SetError(comboBox2, ""); // Clears error message
        }

        // valiedats if the users selects an address
        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProviderLetter.SetError(comboBox1, "Please select the origin address!"); // Set error message
            }
        }

        private void comboBox1_Validated(object sender, EventArgs e)
        {
            errorProviderLetter.SetError(comboBox2, ""); // Clears error message
        }

        //A click event to insert the entered letter parcel
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        //load the name in the address into the combobox
        private void LetterInputBox_Load(object sender, EventArgs e)
        {
            foreach (Address a in my_addresses)
            comboBox1.Items.Add(a.Name); //loads the name property of addresses into the combobox1
            foreach (Address a in my_addresses)
            comboBox2.Items.Add(a.Name); //loads the name property of addresses into the combobox2
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clicked by accident
        }
    }
    }

