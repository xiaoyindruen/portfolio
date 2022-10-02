// Class: CIS199-01
// Lab 4
// Due: 2/21/2021
// by R2696

//This program performs to get the decisions of admission acceptances or rejections
// also counts the total of acceptances and rejections


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class admissionForm : Form
    {
        private int totalAcceptCount = 0; // Count total acceptances from zero
        private int totalRejectCount = 0; //Count total rejections from zero

        public admissionForm()
        { 
            InitializeComponent();
        }

        //perfom to decide accept or reject 
        //also count the total of acceptances and rejections
        private void btnResult_Click(object sender, EventArgs e)
        {

            bool accept; // true = accept, false = reject
            double lblGpa; // to store GPA data gathered from users
            int lblTestScore; //to store Test Score gathered from users

            // validate inputs and make the decision of accept or reject
            if (double.TryParse(iptGpa.Text, out lblGpa) && lblGpa >= 0.0 && lblGpa <= 4.0 &&
                int.TryParse(iptTestScore.Text, out lblTestScore) && lblTestScore >= 0 && lblTestScore <= 100)// validate the inputs
            {
                // GPA above 3.0 and test score above 60 to be accepted
                if (lblGpa >= 3.0)
                {
                    if (lblTestScore >= 60)
                    {
                        accept = true;
                    }
                    else
                    {
                        accept = false;
                    }
                }
                //GPA below 3.0 and test score above 80 to be accepted
                else
                {
                    if (lblTestScore >= 80)
                    {
                        accept = true;
                    }
                    else
                    {
                        accept = false;
                    }
                }

                // Display the decision and total counts of acceptances
                if (accept == true)
                {
                    optResult.Text = $"Accept";
                    totalAcceptCount = totalAcceptCount + 1;// add 1 count every time when accept == true
                    optTotalAccept.Text = $"{totalAcceptCount}";
                }
                // Display the decision and total counts of rejections
                else
                {
                    optResult.Text = $"Reject";
                    totalRejectCount = totalRejectCount + 1;// add 1 count every time when accept == false
                    optTotalReject.Text = $"{totalRejectCount}";
                }
            }
            // when inputs fail the validation
            else
                MessageBox.Show("Please enter the valid GPA and Test Score. GPA must be between 0.0 to 4.0 and test score must be between 0 to 100");
        }   
    }
}
