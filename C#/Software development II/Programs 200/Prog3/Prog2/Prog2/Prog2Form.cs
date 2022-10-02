// Program 3
// CIS 200-50
// Fall 2021
// Due: 11/15/2021
// By: 5461407

// File: Prog2Form.cs
// This class creates the main GUI for Program 2. It provides a
// File menu with About and Exit items, an Insert menu with Address and
// Letter items, and a Report menu with List Addresses and List Parcels
// items.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using UPVApp;
using Prog2;


namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        //object for serializaing 
        private BinaryFormatter formatter = new BinaryFormatter();

        //stream for writing to a file
        private FileStream output;

        private UserParcelView upv; // The UserParcelView

        //stream for reading a file
        private FileStream input;

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test addresses are
        //                added to the list of addresses
        public Prog2Form()
        {
            InitializeComponent();

            upv = new UserParcelView();

            //test data is already saved into Pro3Data.dat

        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // Newline shorthand

            MessageBox.Show($"Program 2{NL}By: Andrew L. Wright{NL}CIS 200{NL}Fall 2020",
                "About Program 2");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Insert, Address menu item activated
        // Postcondition: The Address dialog box is displayed. If data entered
        //                are OK, an Address is created and added to the list
        //                of addresses
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();    // The address dialog box form
            DialogResult result = addressForm.ShowDialog(); // Show form as dialog and store result
            int zip; // Address zip code

            if (result == DialogResult.OK) // Only add if OK
            {
                if (int.TryParse(addressForm.ZipText, out zip))
                {
                    upv.AddAddress(addressForm.AddressName, addressForm.Address1,
                        addressForm.Address2, addressForm.City, addressForm.State,
                        zip); // Use form's properties to create address
                }
                else // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Address Validation!", "Validation Error");
                }
            }

            addressForm.Dispose(); // Best practice for dialog boxes
                                   // Alternatively, use with using clause as in Ch. 17
        }

        // Precondition:  Report, List Addresses menu item activated
        // Postcondition: The list of addresses is displayed in the addressResultsTxt
        //                text box
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            string NL = Environment.NewLine;            // Newline shorthand

            result.Append("Addresses:");
            result.Append(NL); // Remember, \n doesn't always work in GUIs
            result.Append(NL);

            foreach (Address a in upv.AddressList)
            {
                result.Append(a.ToString());
                result.Append(NL);
                result.Append("------------------------------");
                result.Append(NL);
            }

            reportTxt.Text = result.ToString();

            // -- OR --
            // Not using StringBuilder, just use TextBox directly

            //reportTxt.Clear();
            //reportTxt.AppendText("Addresses:");
            //reportTxt.AppendText(NL); // Remember, \n doesn't always work in GUIs
            //reportTxt.AppendText(NL);

            //foreach (Address a in upv.AddressList)
            //{
            //    reportTxt.AppendText(a.ToString());
            //    reportTxt.AppendText(NL);
            //    reportTxt.AppendText("------------------------------");
            //    reportTxt.AppendText(NL);
            //}

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

        // Precondition:  Insert, Letter menu item activated
        // Postcondition: The Letter dialog box is displayed. If data entered
        //                are OK, a Letter is created and added to the list
        //                of parcels
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm; // The letter dialog box form
            DialogResult result;   // The result of showing form as dialog
            decimal fixedCost;     // The letter's cost

            if (upv.AddressCount < LetterForm.MIN_ADDRESSES) // Make sure we have enough addresses
            {
                MessageBox.Show("Need " + LetterForm.MIN_ADDRESSES + " addresses to create letter!",
                    "Addresses Error");
                return; // Exit now since can't create valid letter
            }

            letterForm = new LetterForm(upv.AddressList); // Send list of addresses
            result = letterForm.ShowDialog();

            if (result == DialogResult.OK) // Only add if OK
            {
                if (decimal.TryParse(letterForm.FixedCostText, out fixedCost))
                {
                    // For this to work, LetterForm's combo boxes need to be in same
                    // order as upv's AddressList
                    upv.AddLetter(upv.AddressAt(letterForm.OriginAddressIndex),
                        upv.AddressAt(letterForm.DestinationAddressIndex),
                        fixedCost); // Letter to be inserted
                }
                else // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Letter Validation!", "Validation Error");
                }
            }

            letterForm.Dispose(); // Best practice for dialog boxes
                                  // Alternatively, use with using clause as in Ch. 17
        }

        // Precondition:  Report, List Parcels menu item activated
        // Postcondition: The list of parcels is displayed in the parcelResultsTxt
        //                text box
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This report is generated without using a StringBuilder, just to show an
            // alternative approach more like what most students will have done
            // Method AppendText is equivalent to using .Text +=

            decimal totalCost = 0;                      // Running total of parcel shipping costs
            string NL = Environment.NewLine;            // Newline shorthand

            reportTxt.Clear(); // Clear the textbox
            reportTxt.AppendText("Parcels:");
            reportTxt.AppendText(NL); // Remember, \n doesn't always work in GUIs
            reportTxt.AppendText(NL);

            foreach (Parcel p in upv.ParcelList)
            {
                reportTxt.AppendText(p.ToString());
                reportTxt.AppendText(NL);
                reportTxt.AppendText("------------------------------");
                reportTxt.AppendText(NL);
                totalCost += p.CalcCost();
            }

            reportTxt.AppendText(NL);
            reportTxt.AppendText($"Total Cost: {totalCost:C}");

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

        // Precondition:  Report, List Parcels menu item activated
        // Postcondition: The text data is saved in a file
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                DialogResult result; 
                string name; //file name

                using (SaveFileDialog fileChooser = new SaveFileDialog())
                {
                     
                    result = fileChooser.ShowDialog();
                    name = fileChooser.FileName;//name of the save data
                }

                //when user clicks OK
                if (result == DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(name))
                    { 
                        MessageBox.Show("Invalid File Name!");
                        return;
                    }
                    else 
                    {   //save file through FileStream if the name is valid
                         try
                         {    
                              output = new FileStream(name, FileMode.OpenOrCreate, FileAccess.Write);

                              UserParcelView output_upv = upv;
                              formatter.Serialize(output, output_upv); //serialize the output_upv data

                          }

                    catch (IOException) 
                    {
                        MessageBox.Show("Error saving file!");//notify user that file error
                    }

                    catch (SerializationException)//catch the exception in case serialization errors occur
                    {
                        MessageBox.Show("Error saving file!");
                    }

                    finally //release the open file
                    { 
                        output.Close(); 
                    }
                }
            }
        }
        // Precondition:  Report, List Parcels menu item activated
        // Postcondition: Data from the file loaded and deserialized
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create and show dialop box to open file
            DialogResult result;
            string name;//file name

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                name = fileChooser.FileName; //file name
            }
            
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(name))
                    MessageBox.Show("Ivalid File Name");

                else
                {
                    try 
                    {
                        input = new FileStream(name, FileMode.Open, FileAccess.Read);
                        upv = (UserParcelView) formatter.Deserialize(input); //deserialize the data from the file
                    }

                    catch (IOException)
                    {
                        MessageBox.Show("Error opening file!"); //notify user with the opening error
                    }

                    catch (SerializationException)
                    {
                        MessageBox.Show("Error opening file!");
                    }
                    finally//release the open file
                    { 
                        input.Close();
                    }
                }
            }
        }

        // Precondition:  Report, List Parcels menu item activated
        // Postcondition: edit adress form is open
        private void addressToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditAddress editaddress = new EditAddress(upv.AddressList);//send the address list to the listbox 
            DialogResult editAddressResult;

            editAddressResult = editaddress.ShowDialog();
        }
    }
    }
