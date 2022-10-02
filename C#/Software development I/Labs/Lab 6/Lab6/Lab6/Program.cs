//CIS 199
//Lab 6
//Due: 3/21/2021
//By: G2696
// This program produce 3 different star pattern for display 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab6
{
    class Program
    {
        // creats 3 different star output patterns
        static void Main(string[] args)
        {
            const int MAX_ROWS = 10; //each pattern has 10 rows

            // Pattern A
            WriteLine("Pattern A");
            WriteLine();
            for (int row = 1; row <= MAX_ROWS; row++) 
            {
                for (int star = 1; star <= row; star++)//loop to write stars
                Write("*");
                WriteLine();

             }

            // Pattern B
            WriteLine();
            WriteLine("Pattern B");
            WriteLine();
            for (int row = 1; row <= MAX_ROWS; row++)
            { 
                for (int star = MAX_ROWS; star >= row; star--)//loop to write stars
                    Write("*");
                WriteLine();
            }

            // Pattern C
            WriteLine();
            WriteLine("Pattern C");
            WriteLine();
            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int space = 1; space < row; space++)//loop to write spaces
                    Write(" ");

                for (int star = MAX_ROWS; star >= row; star--)//loop to write stars
                    Write("*");
                    WriteLine(); 
            }

            // Pattern D
            WriteLine();
            WriteLine("Pattern D");
            WriteLine();
            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int space =9; space >= row; space--)//loop to write spaces
                    Write(" ");

                for (int star = 1; star <= row; star++)//loop to write stars

                    Write("*");
                    WriteLine();
            }

        }   
    }
 }

        
 

