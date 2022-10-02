//CIS 199-01
//Program 1
//Due: 2/16/2021
//Grading ID: R2696

//This program estimates and displays garden and landscaping price 
//also includes details of labor and material prices 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1
{
    public partial class costForm : Form
    {
        public costForm()
        {
            InitializeComponent();
        }

        //This block of code gather info from client,
        //estimat and display the garden and landscaping cost.
        private void btnCalc_Click(object sender, EventArgs e)
        {
            // constants for converting and price rates
            const double areaRate = 9; 
            const double firstFee = 50; // the extra labor cost the first garden(labor cost) 
            const double soilWasteRate = 0.1; // extra soil estimate waste(material cost) 
            const double fertilizerRate = 4.25; //fertilizer price per sq. yeard(material cost)
            const double soilLaborRate = 3.25; //soil labor price per sq. yard(labor cost)

            // variables to gather data from promt
            double maxWidth; // 
            double maxLength; // 
            double soilPrice; //soil price(material cost)
            int fertilizer; // 1=YES, 0=NO
            int firstGarden;// 1=YES, 0=NO

            // variables to contain the calculation results
            double gardenArea; 
            double materialCost; // total material cost
            double soilCost; 
            double fCost; // fertilizer cost
            double laborCost; // total labor cost
            double totalCost; // total of material and labor cost
                       

            // Calculate area 
            maxWidth = double.Parse(iptWidth.Text);
            maxLength = double.Parse(iptLength.Text);
            gardenArea = (maxWidth * maxLength) / areaRate; // calculates area in feet and convert into sq Yard.
            optArea.Text = $"{gardenArea:f1}";

            // Calculate material cost 
            soilCost = (1 + soilWasteRate) * double.Parse(iptSoilPrice.Text) * gardenArea;//soil cost and 10% extra for waste
            fCost = double.Parse(iptFertilizer.Text) * gardenArea * fertilizerRate;
            materialCost =soilCost + fCost; //calcutate the total material cost
            optSoilCost.Text = $"{soilCost:C}";
            optFCost.Text = $"{fCost:C}";
            

            // Calculate labor cost
            laborCost = double.Parse(iptFirstGarden.Text) * firstFee + soilLaborRate * gardenArea; // total labor cost
            optLaborCost.Text = $"{laborCost:C}";

            //Calculate and display total cost here
            totalCost = materialCost + laborCost;
            optTotalCost.Text = $"{totalCost:C}";

            
         
        }
    }
}
