// CIS 199
// Lab 7
// By: R2696
// Due: 4/4/2021
// This program creates a square pattern of *
// using the input as the number of the square side

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStars; // variable that will hold the input, as the number of stars in each row and the number of columns
            bool isValid = false; // remains false until a positive integer is entered

            do              
            {
                Console.WriteLine("Enter an integer: ");
                if (int.TryParse(Console.ReadLine(), out numOfStars) && numOfStars > 0)
                isValid = true;
                ShowSquareOfStars(numOfStars); // call the method
            } while (!isValid); // keep prompting the user for input until they enter a valid value


        }

        // method to create a square pattern of stars
        public static void ShowSquareOfStars(int numStars)
        {
            for (int row = 1; row <= numStars; row++) 
            {
                for (int col = 1; col <= numStars; col++)
                
                    Console.Write("*");
                    Console.WriteLine();
                                    
            }
        }
    }
}
