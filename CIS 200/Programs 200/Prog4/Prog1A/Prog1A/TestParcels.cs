// Program 4
// CIS 200-50
// Fall 2021
// Due: 11/29/2021
// By: 5461407

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
                "Portland", "ME", 42101); // Test Address 4

            Address a5 = new Address("Lily Smith", "456 Lyndon ln", "Louisville", "Ky", 40222);// Test Address 5
            Address a6 = new Address("Lucy Brown", "8246 Us Highway 231", "Loogootee", "IN", 47553);// Test Address 6
            Address a7 = new Address("John Authur", "11421 Deer Creek Rd", "Bridgeport", "IL", 62417);// Test Address 7
            Address a8 = new Address("Stanley Druen", "7445 SE 71st ST", "Mercer Island", "WA", 98040);// Test Address 8
           
            
            // Add 6 more parcels test data
            Letter letter1 = new Letter(a1, a8, 3.95M);                                     
            GroundPackage gp1 = new GroundPackage(a3, a7, 14, 10, 5, 12.5);       
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a5, 25, 15, 15, 85, 7.50M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a6, 46.5, 39.5, 28.0, 80.5, TwoDayAirPackage.Delivery.Saver);           
            Letter letter2 = new Letter(a8, a1, 14.5M);                           
            Letter letter3 = new Letter(a5, a2, 2.08M);                           
            GroundPackage gp2 = new GroundPackage(a7, a3, 25, 68, 8, 22.5);          
            GroundPackage gp3 = new GroundPackage(a6, a4, 25, 77, 11, 52.4);        
            NextDayAirPackage ndap2 = new NextDayAirPackage(a3, a5, 75, 62, 15, 85, 10.70M);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a2, a7, 3.22, 55, 28.0, 9.5, TwoDayAirPackage.Delivery.Early);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(gp1);
            parcels.Add(ndap1);
            parcels.Add(tdap1);
            parcels.Add(letter2); 
            parcels.Add(gp2);
            parcels.Add(ndap2);
            parcels.Add(tdap2);
            parcels.Add(letter3); 
            parcels.Add(gp3);


            WriteLine("Original List:");
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();

            //Sort parcels ascending by cost
            parcels.Sort(); 
            WriteLine("Sorted parcels ascending by cost:");
            foreach (Parcel p in parcels)
            {
                WriteLine($"{p.CalcCost():c}"); // display the list of parcels ascending by cost 
                WriteLine("====================");
            }
            Pause();

            //Sort parcels descending by destination zip code
            parcels.Sort(new DescendingZipCode());
            WriteLine("Sorted parcels descending by destination zip code:");
            foreach (Parcel p in parcels)
            {
                WriteLine(p.DestinationAddress.Zip); // display the list of parcels descending by destination zip code 
                WriteLine("====================");
            }
                Pause();

            //Sort parcels ascending by parcel type then descending by cost within grouping
            parcels.Sort(new TypeCostOrder());
            WriteLine("Sorted parcels ascending by parcel type then descending by cost within grouping:");
            {
                foreach (Parcel p in parcels)// display the list of parcels descending by parcel type then descending by cost within grouping 
                    WriteLine($"{p.GetType().ToString()}    Cost:{p.CalcCost():c}" ); 
                   
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
