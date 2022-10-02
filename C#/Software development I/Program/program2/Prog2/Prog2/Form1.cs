// CIS 199
// Program 2
// Due: 03/11/2020
// By: R2696
// This program calculates the cost of catering orders of three companies 
// and decides which costs the least


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
    public partial class FoodDeliveryCostForm : Form
    {
        public FoodDeliveryCostForm()
        {
            InitializeComponent();
        }

        // perform the calculation of cost of each company and compare the results to get the lowest price
        private void btnCalCost_Click(object sender, EventArgs e)
        {
            // company A
            const int onePersonRateA = 1; //Price rate of one person
            const double distanceRateA = 0.02; // Price rate of each mile
            const int oneDayRateA = 20; // Price with only one preparation day
            const int twoDayRateA = 17; // Price with two preparation days
            const int threeDayRateA = 15; // Price with three preparation days
            const int fourToSevenDayRateA = 10; // Price with four to sevenpreparation days
            const int sevenDayAboveRateA = 7; // Price with above seven preparation days

            // company B
            const int underTenRateB = 20; // price rate of less than 10 people
            const int tenToFiftyRateB = 10; // price rate of 10 to 49 people
            const int fiftyTo100RateB = 5; // price rate of 50 to 99 people
            const int hundrenTo200RateB = 3; // price rate of 100 to 199 people
            const double above200RateB = 0.15; // price rate of 200 and above people
            const double distanceRateB = 0.1; // price rate of each mile
            const int under4DaysB = 10;// price of 1-4 preparation days
            const int above4DaysB = 7; // price of more than 4 preparation days

            //company C
            const double onePersonRateC = 0.25; // price rate of each person
            const int above1000MileC = 40; // distance price of 1000 and above miles
            const int above750MileC = 35; // distance price of 750 to 999 miles
            const int above500MileC = 25; // distance price of 500 to 749 miles
            const int above200MileC = 15;// distance price of 200 to 499 miles
            const int under200MileC = 10;// distance price of under 200 miles
            const int prepDaysFee = 20; // general price rate of preparation

            // variables for input and performance
            int people; // input of people
            double distance; // input of distance
            int days; // input of days

            double costA; // cost of company A
            double costB; // cost of company B
            double costC; // cost of company C
            double lowestCost; // The lowest cost of the three companies

            // convert input to calculate cost of three companies
            if (int.TryParse(iptPeople.Text, out people) && double.TryParse(iptDistance.Text, out distance)
                & int.TryParse(iptDyas.Text, out days))
            {
                // calculate Company A cost
                if (days > 7) // more than 7 days
                {
                    costA = onePersonRateA * people + distance * distanceRateA + sevenDayAboveRateA;
                }
                else if (days >= 4) // 4 to 7 days
                {
                    costA = onePersonRateA * people + distance * distanceRateA + fourToSevenDayRateA;
                }
                else if (days == 3) // 3 days
                {
                    costA = onePersonRateA * people + distance * distanceRateA + threeDayRateA;
                }
                else if (days == 2) // 2 days
                {
                    costA = onePersonRateA * people + distance * distanceRateA + twoDayRateA;
                }
                else // 1 day
                {
                    costA = onePersonRateA * people + distance * distanceRateA + oneDayRateA;
                }


                // calcuate Company B Cost
                if (people >= 200) // 200 people or more
                {
                    if (days > 4)
                    {
                        costB = people * above200RateB + distance * distanceRateB + above4DaysB;
                    }
                    else 
                    {
                        costB = people * above200RateB + distance * distanceRateB + under4DaysB;
                    }
                }
                else if (people >= 100)// 100 to 199 people
                {
                    if (days > 4)
                    {
                        costB = people * hundrenTo200RateB + distance * distanceRateB + above4DaysB;
                    }
                    else
                    {
                        costB = people * hundrenTo200RateB + distance * distanceRateB + under4DaysB;
                    }
                }
                else if (people >= 50)// 50 to 99 people
                {
                    if (days > 4)
                    {
                        costB = people * fiftyTo100RateB + distance * distanceRateB + above4DaysB;
                    }
                    else 
                    {
                        costB = people * fiftyTo100RateB + distance * distanceRateB + under4DaysB;
                    }
                }
                else if (people >= 10)//10 to 49 people
                {
                    if (days > 4)
                    {
                        costB = people * tenToFiftyRateB + distance * distanceRateB + above4DaysB;
                    }
                    else 
                    {
                        costB = people * tenToFiftyRateB + distance * distanceRateB + under4DaysB;
                    }
                }
                else // less than 10 people
                {
                    if (days > 4)
                    {
                        costB = people * underTenRateB + distance * distanceRateB + above4DaysB;
                    }
                    else 
                    {
                        costB = people * underTenRateB + distance * distanceRateB + under4DaysB;
                    }
                }
                                
                //calcute Company C Cost
                if (distance >= 1000) // 1000 miles or more
                {
                    costC = people * onePersonRateC + above1000MileC + prepDaysFee;
                }
                else if (distance >= 750) //750 to 999 miles
                {
                    costC = people * onePersonRateC + above750MileC + prepDaysFee;
                }
                else if (distance >= 500) //500 to 749 miles
                {
                    costC = people * onePersonRateC + above500MileC + prepDaysFee;
                }
                else if (distance >= 200) // 200 to 499 miles
                {
                    costC = people * onePersonRateC + above200MileC + prepDaysFee;
                }
                else // less than 200 miles
                {
                    costC = people * onePersonRateC + under200MileC + prepDaysFee;
                }
            // dispaly the cost of each company
            optACost.Text = $"{costA:C}";
            optBCost.Text = $"{costB:C}";
            optCCost.Text = $"{costC:C}";

            // compare the cost of three companies and display the lowest cost option
            lowestCost = costA;
             optResult.Text = ($"The lowest cost company is : A");
            if (lowestCost > costB)
                {
                    lowestCost = costB;
                    optResult.Text = ($"The lowest cost company is : B");
                }
            if (lowestCost > costC)
                {
                    lowestCost = costC;
                    optResult.Text = ($"The lowest cost company is : C");
                }

            }

           // message to show input is incorrect
            else
                MessageBox.Show("Please enter the correct order!");

            
        }
    }
}
