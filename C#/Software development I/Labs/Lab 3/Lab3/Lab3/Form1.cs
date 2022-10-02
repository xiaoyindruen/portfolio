// CIS 199-01
// Lab 3
// Due: 2/14/2021
// By: R2696

//This program calculates diameter, surface area and volum of sphere
// with radius input from users

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class sphereCalForm : Form
    {
        public sphereCalForm()
        {
            InitializeComponent();
        }

        // Calculates and displays results 
        private void btnCal_Click(object sender, EventArgs e)
        {
            // declares variables 
            double radiusOfSphere; // variable of radius
            double lblDiameter;  // variable of diamater
            double lblSurfaceArea;  // variable of surface area
            double lblVolumn;  // variable of volumn

            //gathers value of radius and calculate diameter, surface area and volumn
            radiusOfSphere = double.Parse(iptRadius.Text);// convert value from string to double
            lblDiameter = 2 * radiusOfSphere; // D = 2r
            lblSurfaceArea = 4 * Math.PI * Math.Pow(radiusOfSphere, 2); // A = 4πr^2
            lblVolumn = 4 * (Math.PI * Math.Pow(radiusOfSphere, 3)) /3; // V = (4πr^3)/3

            //Displays calculated diameter, surface and volumn on the labels
            lblOptDiameter.Text = $"{lblDiameter:f2}"; //Displays calculated diameter on the label
            lblOptSurfaceArea.Text = $"{lblSurfaceArea:f2}";//Displays calculated surface on the label
            lblOptVolumn.Text = $"{lblVolumn:f2}";//Displays calculated on the label
        }
    }
}
