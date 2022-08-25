// CIS 200-50
// Program 0
// Due: Sep 9th
//Student ID: 5461407
// This is a program to print addresses of letter's senders and receriver, and the cost
// built a address class
// buile abstract class Parcel and letter class inherits from Parcel


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {   // includes 4 different addresses and create 3 letters
        static void Main(string[] args)
        {
            // data of names and addresses of senders and receivers
            var addr1 = new Address("Smith", "1234 Lyndon Ln", "   ", "Louisville", "KY", 40222); // address2 is white space to test the validation and output
            var addr2 = new Address("Mary", "2345 3rd Street", "Louisville", "KY", 40216); // test overloading constructor by not entering address2
            var addr3 = new Address("Brown", "5641 Moon Street", "Apt 666", "Louisville", "KY", 8); //one-digit zip to test validations and output format
            var addr4 = new Address("Nobody", "1234 Sun Ln", "Room 99", "Louisville", "KY", 40111);
            decimal fixedCost1 = 0.49M; // price of sending first type of letter
            decimal fixedCost2 = 0.99M;// price of sending second type of letter


            // data of letters' sender, receiver and cost
            var myLetter1 = new Letter(addr1, addr2, fixedCost1);
            var myLetter2 = new Letter(addr3, addr4, fixedCost2);
            var myLetter3 = new Letter(addr4, addr1, fixedCost2);

            // a list of 3 letters
            List<Parcel> myParcels = new List<Parcel>();
            myParcels.Add(myLetter1);
            myParcels.Add(myLetter2);
            myParcels.Add(myLetter3);

            //Displaying addresses for producing parcels and cost
            for (int i = 0; i < myParcels.Count; i++) 
            {
                Console.WriteLine($"The parcel for the letter{i+1}:"); 
                Console.WriteLine(myParcels[i]);
                Console.WriteLine();
             }

        }
    }
}
