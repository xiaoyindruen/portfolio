// Program 1A
// CIS 200-50
// Due: 9/27/2021
// By: 5461407

// File: Program.cs
// Simple test program for initial Parcel classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prog0
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ", 
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", 
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321", 
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter l1 = new Letter(a1, a3, 0.50M); // Test Letter 1
            Letter l2 = new Letter(a2, a4, 1.20M); // Test Letter 2
            Letter l3 = new Letter(a4, a1, 1.70M); // Test Letter 3

            List<Parcel> parcels = new List<Parcel> {l1, l2, l3}; // Test list of parcels

            // Display data
            WriteLine("Program 0 - List of Parcels\n");

            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("--------------------");
            }

            GroundPackage gp = new GroundPackage(a1, a2, 2, 3, 4, 5, 4); //test GroundPackage
            NextDayAirPackage ndp = new NextDayAirPackage(a4, a3, 30, 50, 60, 100, 800);//test NextDayAirPackage
            TwoDayAirPackage tdp = new TwoDayAirPackage(a2, a3, 5, 7, 8, 800, TwoDayAirPackage.delivery.early);//testTwoDayPackage
            WriteLine("\nGroup Package:");
            WriteLine(gp);
            WriteLine("\nNext Day Package:");
            WriteLine(ndp);
            WriteLine("\nTwo Day Package:");
            WriteLine(tdp);
            WriteLine(gp.ZoneDistance);

        }
    }
}
