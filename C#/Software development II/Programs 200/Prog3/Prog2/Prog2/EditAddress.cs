// Program 3
// CIS 200-50
// Fall 2021
// Due: 11/15/2021
// By: 5461407
// This class creates the Address editing dialog box form GUI


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVApp;


namespace Prog2
{
    public partial class EditAddress : Form
    {
        private List<Address> my_address;  // List of addresses used to fill list box
       
        public EditAddress()
        {
            InitializeComponent();
         
        }

        //constructor for address list
        public EditAddress(List<Address> add_in) 
     
        {
            my_address = add_in;
            InitializeComponent();

        }

        internal int selectedAddress
        {   // Precondition:  None
            // Postcondition: The text of form's name field is returned
            get
            {
                return addressListBox.SelectedIndex;
            }
            // Precondition:  value must be in list box
            // Postcondition: The selected index is set to specified value
            set
            {
                addressListBox.SelectedIndex = value;
            }
        }


        private void addressList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //double clicked by accident
        }

        //Load the data into the form
        private void EditAddress_Load(object sender, EventArgs e)
        {
            foreach (Address a in my_address)
            {
                // add the name of each address in the list into the list box
                addressListBox.Items.Add(a.Name); 
            }
        }

        // Precondition:  the address list is added into the list box
        // Postcondition: the editing of address is saved
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedIndex = addressListBox.SelectedIndex; // the selected index of the list
            Address selectedAddress = my_address[selectedIndex]; //the selected address

            AddressForm addressForm = new AddressForm();//instantiates the address form, ready to take the address in

            //passes the info of the selected address into the address form
            addressForm.AddressName = selectedAddress.Name; 
            addressForm.Address1 = selectedAddress.Address1;
            addressForm.Address2 = selectedAddress.Address2;
            addressForm.City = selectedAddress.City;
            addressForm.State = selectedAddress.State;
            addressForm.ZipText = selectedAddress.Zip.ToString();
            DialogResult result = addressForm.ShowDialog();


            if ( result == DialogResult.OK) //clicks ok in the address form after editing
            {
                //passes the info in the textboxes and combobox back to the address
                selectedAddress.Name = addressForm.AddressName;
                selectedAddress.Address1 = addressForm.Address1;
                selectedAddress.Address2 = addressForm.Address2;
                selectedAddress.City = addressForm.City;
                selectedAddress.State = addressForm.State;
                selectedAddress.Zip = int.Parse(addressForm.ZipText);//parse the string in the textbox into an int
            }

        }
        // Precondition: none
        // Postcondition: the EditAddress form is closed
        private void btnCancel_Click(object sender, EventArgs e)
        {
                this.DialogResult = DialogResult.Cancel;//close the edit address form
        }
    }
}
