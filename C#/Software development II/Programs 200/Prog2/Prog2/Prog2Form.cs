//Student ID:5461407
//CIS200-50
//Program2
//Due: 10/25/2021
//this is the main form that has "About" and "Exit" under "File"
// "Letter" and "Address" under "Insert"
// "List Addresses" and  "List Parcels" under "Report"

using Prog2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {

        private UserParcelView upv; // the instance of UserParcelView 

        //Precondition: None
        //Postcondition:lsit of addresses and parcels are added for testing
        public Prog2Form()
        {
            InitializeComponent();

            upv = new UserParcelView(); // to hold the added addresses/ parcel
            

            // add address test data -- using 8 addresses from Prog1B solution
            upv.AddAddress("John Smith", "123 Any St.", "Apt. 45 ", "Louisville", "KY", 40202);
            upv.AddAddress("Jane Doe", "987 Main St.", "Beverly Hills", "CA", 90210);
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321", "El Paso", "TX", 79901);
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7", "Portland", "ME", 04101);
            upv.AddAddress("John Doe", "111 Market St.", "Jeffersonville", "IN", 47130);
            upv.AddAddress("Jane Smith", "55 Hollywood Blvd.", "Apt. 9", "Los Angeles", "CA", 90212);
            upv.AddAddress("Captain Robert Crunch", "21 Cereal Rd.", "Room 987", "Bethesda", "MD", 20810);
            upv.AddAddress("Vlad Dracula", "6543 Vampire Way", "Apt. 1", "Bloodsucker City", "TN", 37210);

            //add parcel data -- using 10 parcels from Prog1B solution
            //index is small than the count of parcels in the parcel list
            upv.AddLetter(upv.AddressAt(1), upv.AddressAt(2), 3.95M);
            upv.AddLetter(upv.AddressAt(3), upv.AddressAt(4), 4.25M);
            upv.AddGroundPackage(upv.AddressAt(0), upv.AddressAt(1), 14, 10, 5, 12.5);
            upv.AddGroundPackage(upv.AddressAt(1), upv.AddressAt(2), 8.5, 9.5, 6.5, 2.5);
            upv.AddNextDayAirPackage(upv.AddressAt(5), upv.AddressAt(4), 25, 15, 15, 85, 7.50M);
            upv.AddNextDayAirPackage(upv.AddressAt(3), upv.AddressAt(4), 9.5, 6.0, 5.5, 5.25, 5.25M);
            upv.AddNextDayAirPackage(upv.AddressAt(2), upv.AddressAt(7), 10.5, 6.5, 9.5, 15.5, 5.00M);
            upv.AddTwoDayAirPackage(upv.AddressAt(5), upv.AddressAt(7), 46.5, 39.5, 28.0, 80.5, TwoDayAirPackage.Delivery.Saver);
            upv.AddTwoDayAirPackage(upv.AddressAt(2), upv.AddressAt(1), 15.0, 9.5, 6.5, 75.5, TwoDayAirPackage.Delivery.Early);
            upv.AddTwoDayAirPackage(upv.AddressAt(6), upv.AddressAt(4), 12.0, 12.0, 6.0, 5.5, TwoDayAirPackage.Delivery.Saver);
        }

        private void Prog2Form_Load(object sender, EventArgs e)
        {
          //double clicked by accident   
        }


        //precondition:none
        //postcondition:informantion is shown in the message box after clicking the button "About"
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student ID: 5461407 \nSection: CIS200-50 \nProgram2 \nDue: 10/25/2021");             
        }


        //precondition:none
        //postcondition:the application is terminated 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //precondition:the button "List Address" is clicked
        //postcondition:the list of addresses shown in the textbox
        private void listAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Address a in upv.AddressList)
            {
                textBoxReport.Text += $"{a}\r\n\r\n";//show the address list in the text box
            }

        }

        //precondition:the button "Parcel List" is clicked
        //postcondition:the list of parcel shown in the textbox
        private void listParcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal totalCost=0;

            foreach (Parcel p in upv.ParcelList)
            {
                
              textBoxReport.Text += $"{p}\r\n\r\n"; //show the parcel list into the textbox   
              totalCost += p.CalcCost();
             
           }
            textBoxReport.Text += $"Total Cost: {totalCost:c}"; //add total cost after the list
        }

        //precondition:the buttons "Insert" then "Address" is clicked
        //postcondition: the address input box is loaded, user is able to create a new address to add to the report
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressInputBox addressInputBox = new AddressInputBox();//the form to collect address data
            DialogResult addressData; // the result 

            addressData = addressInputBox.ShowDialog(); 

            if (addressData ==DialogResult.OK) // if the result is OK
            {
                string addName, addLine1, addLine2, addCity, addState; //variables to hold the entered data
                int addZip;                                  //variable to hold the entered zip code
                addName = addressInputBox.InputValueName; //add the entered name 
                addLine1 = addressInputBox.InputValueLine1; //add the entered line1
                addLine2 = addressInputBox.InputValueLine2;//add the entered line2 if any
                addCity = addressInputBox.InputValueCity;//add the entered city
                addState = addressInputBox.InputValueState;//add the entered state
                addZip = int.Parse(addressInputBox.InputValueZip);//convert the entered string into # and add to zip

                upv.AddAddress(addName, addLine1, addLine2, addCity, addState, addZip); // add the address 
            }
            else //in case validations don't work
            {
                MessageBox.Show("Address fails to be added!");
            }
        }

        //precondition:the buttons "Insert" then "Letter" is clicked
        //postcondition: the letter input box is loaded, user is able to create a new letter parcel to add to the report
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterInputBox letterInputBox = new LetterInputBox(upv.AddressList);//send the address list
            DialogResult letterData;
            decimal cost; //variable to hold the entered fixed cost

            letterData = letterInputBox.ShowDialog();

            if (letterData == DialogResult.OK) // if the result is OK
            {
                if (decimal.TryParse(letterInputBox.InputValueCost, out cost))
                {
                    upv.AddLetter(upv.AddressAt(letterInputBox.InputValueOrigin),
                        upv.AddressAt(letterInputBox.InputValueDestination),cost); // insert the letter
                }
            }

            else //in case validations don't work
            {
                MessageBox.Show("Letter fails to be added!");
            }
        }
    }
    }
    

