// CIS 199
// Program 4
// By: R2696
// Due: 04/18/2021
// This program creats output that contains car repair records 
// info about the Service Location Zip code, vehicle make and model, car serial number, model year
// appointment length, the technician name and the warranty coverage, calculates cost according to the appointment length and warranty coverage

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class Program
    {
        static void Main(string[] args)
        {
            RepairRecord[] records = new RepairRecord[6]; // an array that holds properties of the RepairRecord class

            //put values to set the properties
            records[0] = new RepairRecord(41051, "Ford F150", "C493768459", 2011, 45, "Bob Jones", false);
            records[1] = new RepairRecord(40203, "Toyota Matrix", "C857395785", 2005, 60, "Monica Fitzgerald", true);
            records[2] = new RepairRecord(40202, "Tesla Model 3", "C58395358", 2019, 15, "Bob Jones", false);
            records[3] = new RepairRecord(40208, "Mclaren F1", "C968486749", 2020, 120, "Mike Lewis", true);
            records[4] = new RepairRecord(40212, "Gallifreyan Tardis", "C968857575", 2500, 150, "The Doctor", true);
            records[5] = new RepairRecord(40211, "Correllian Tie Fighter", "C565756555", 3600, 80, "Luke Skywalker", false);


            OutputRepairRecords(records); // call OutputRepairRecords method to display info in the properties
           

            //change at least one property in each record
            records[0].ServiceLocationZipCode = 100000;// change zip code to invalid value
            records[1].MakeModel = ""; // empty model
            records[2].SerialNumber = "C85739578";// invalid serial number
            records[3].Year = 2088; // change year to 2088
            records[4].TechnicianName = ""; // empty technician name
            records[5].AppointmentLength = 2; // change appointment length to 2 minutes
            Console.WriteLine("New date after some properties changed:");

            OutputRepairRecords(records);// call OutputRepairRecords method again to show new data
        }

        //display method
        public static void OutputRepairRecords(RepairRecord[] my_records)
        {
            for (int i = 0; i < my_records.Length; i++)
                Console.WriteLine($"{my_records[i]}"); // call ToString method to dispaly output 
        }
    }
}
