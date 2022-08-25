// Lab 2
// CIS 199-01
// Due: 2/7/2021
// By: R2696

//This program calculates and displays the results of three different tipping rate of meal
//which are 15%, 18% and 20%
//also has the results shown in form correctly 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2Form : Form
    {
        public Lab2Form()
        {
            InitializeComponent();
        }

        //This block of code calculates and displays 15%, 18% and 20% of meal price.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double price; // this declares the variable of price to calculate.
            double calPercent1; // the variable of result of 15% of price.
            double calPercent2; // the variable of result of 18% of price.
            double calPercent3; // the variable of result of 20% of price.
            const double tipRate1 = 0.15;// first tipping rate is 15% as a constant 
            const double tipRate2 = 0.18;// second tipping rate is 18% as a constant 
            const double tipRate3 = 0.20;// third tipping rate is 20% as a constant 

            price = double.Parse(inputPrice.Text); //this converts the input price from text to double.
            inputPrice.Text = $"{price:f2}"; // this formats the price output showing 2 decimal places

            calPercent1 = price * tipRate1; // this calculates 15% of meal price.
            calPercent2 = price * tipRate2; // this calculates 18% of meal price.
            calPercent3 = price * tipRate3; // this calculates 20% of meal price.

            outPut1.Text = $"{calPercent1:C2}"; // this displays 15% of meal price.
            outPut2.Text = $"{calPercent2:C2}"; //this calculates 18% of meal price.
            outPut3.Text = $"{calPercent3:C2}"; // this calculates 20% of meal price.


        }
    }
}
