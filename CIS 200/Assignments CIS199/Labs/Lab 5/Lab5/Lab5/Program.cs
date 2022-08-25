// CIS 199
// LAB 5
// Due: 03/07/2021
// by: R2696
// This program continuously promt users for daily high temperature
// until the user enters 999
// It also validates the input data and calculate the average temperature of the inputs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
         bool validTemp; // to see if the input meets requirements
         int temp; // stores valid inputs
         int count=0; // count valid inputs
         double sum=0; // sum all the valid inputs
         double mean; // avarage of all the inputs
         
        // Promt users for valid temperature
         WriteLine("Enter temperatures from -20 to 130 (999 to stop)");
         Write("Enter temperature:");

        //validate if input is an integer
         validTemp = int. TryParse(ReadLine(), out temp);

            // while loop
            while (temp != 999) // 999 as sentinel
            {              
                if (!validTemp || temp < -20 || temp > 130) // if input is not an integer or an integer smaller than -20 or greater than 130
                {
                    WriteLine("Valid temperatures range from - 20 to 130.Please reenter temperature.");
                }
                else // when the input is a valid temperature
                {
                    sum += temp; // sum the inputs
                    count++; // count the inputs
                }
                Write("Enter temperature: ");
                validTemp = int.TryParse(ReadLine(), out temp);
            }
            mean = (double)sum / count; // average of the inputs

            // displays the counts and mean of inputs 
            WriteLine($"You entered {count} valid temperatures.");
            WriteLine($"The mean temperature is {mean:f1} degrees.");

        }
        
    }
}
