// Program 1B (using the solution of program 1A)
// CIS 200-50
// Fall 2021
// Due: 10/08/2021
// By: 5461407
// Use LINQ to create a result variable for each report then display each report, labeling each in the output.

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Address a5 = new Address("Lily Smith", "456 Lyndon ln", "Louisville", "Ky", 40222);// Test Address 5
            Address a6 = new Address("Lucy Brown", "8246 Us Highway 231", "Loogootee", "IN", 47553);// Test Address 6
            Address a7 = new Address("John Authur", "11421 Deer Creek Rd", "Bridgeport", "IL", 62417);// Test Address 7
            Address a8 = new Address("Stanley Druen", "7445 SE 71st ST", "Mercer Island", "WA", 98040);// Test Address 8

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                83, TwoDayAirPackage.Delivery.Saver);

            Letter letter2 = new Letter(a5, a6, 4.78M);                            // Letter test object2
            GroundPackage gp2 = new GroundPackage(a7, a8, 20, 10, 15, 10.5);        // Ground package test object2
            NextDayAirPackage ndap2 = new NextDayAirPackage(a5, a3, 25, 20, 30, 100, 10.50M);   // Next Day air package test object2
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a8, a5, 77.5, 58.5, 25.0, 80.5, TwoDayAirPackage.Delivery.Early);// Two Day Air Package test object2


            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(gp1);
            parcels.Add(ndap1);
            parcels.Add(tdap1);

            parcels.Add(letter2); // Populate list with new test objects
            parcels.Add(gp2);
            parcels.Add(ndap2);
            parcels.Add(tdap2);

            //Select all Parcels and order by destination zip (descending)
            var descDestinationZip =
                from allParcel in parcels
                orderby allParcel.DestinationAddress.Zip descending
                select allParcel;

            // Select all Parcels and order by cost(ascending)
            var asceCost =
                 from allParcel in parcels
                 orderby allParcel.CalcCost()
                 select allParcel;

            //Select all Parcels and order by Parcel type (ascending) and then cost (descending)
            var typeCost =
                from allParcel in parcels
                orderby allParcel.GetType().ToString(), allParcel.CalcCost() descending
                select allParcel;

            //Select all AirPackage objects that are heavy and order by weight (descending)
            var descWeight =
                from allParcel in parcels
                let airPackage = allParcel as AirPackage // a strong cast but it could return null
                where airPackage != null   //avoid null referrence exception
                orderby airPackage.IsHeavy() == true, airPackage.Weight descending 
                select airPackage;




            WriteLine("Original List:");
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();

            //test all Parcels and order by destination zip (descending)
            WriteLine("All Parcels and order by destination zip (descending):");
            foreach (var desZip in descDestinationZip)
            {
                WriteLine(desZip.DestinationAddress.Zip);
                WriteLine("====================");
            }
            Pause();

            //test all Parcels and order by cost(ascending)
            WriteLine("All Parcels order by cost(ascending):");
            foreach (var cost in asceCost)
            {
                WriteLine($"{ cost.CalcCost():c}");
                WriteLine("====================");
            }
            Pause();

            //test all Parcels and order by Parcel type (ascending) and then cost (descending)
            WriteLine("All Parcels order by Parcel type (ascending) and then cost (descending):");
            foreach (var tc in typeCost)
            {
                WriteLine($"{ tc.GetType().ToString()}, Cost: {tc.CalcCost():c}");
                WriteLine("====================");
            }
            Pause();

            //test all AirPackage objects that are heavy and order by weight (descending)
            WriteLine("All AirPackage objects that are heavy and order by weight (descending):");
            foreach (var hp in descWeight)
            {
                WriteLine(hp.Weight);
                WriteLine("====================");
            }
            Pause();
        }



        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            WriteLine("Press Enter to Continue...");
            ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
