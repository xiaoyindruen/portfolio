//CIS 200-50
//Student ID: 5461407
//Due: 09/22/2021
//Lab 1
//Perform the queries on the array of Invoice objects and displays the results
//a) Use LINQ to sort the Invoice objects by PartDescription.
//b) Use LINQ to sort the Invoice objects by Price.
//c) Use LINQ to select the PartDescription and Quantity and sort the results by Quantity.
//d) Use LINQ to select from each Invoice the PartDescription and the value of the Invoice (i.e., Quantity * Price). Name the calculated column InvoiceTotal. 
//    Order the results by Invoice value. 
//e) Using the results of the LINQ query in Part d, select the InvoiceTotals in the range $200 to $500." [Note: This should be an inclusive range.]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Lab1
{
    public class LinqTest
    {
        public static void Main(string[] args)
        {
            // initialize array of invoices
            Invoice[] invoices = { 
                new Invoice( 83, "Electric sander", 7, 57.98M ), 
                new Invoice( 24, "Power saw", 18, 99.99M ), 
                new Invoice( 7, "Sledge hammer", 11, 21.5M ), 
                new Invoice( 77, "Hammer", 76, 11.99M ), 
                new Invoice( 39, "Lawn mower", 3, 79.5M ), 
                new Invoice( 68, "Screwdriver", 106, 6.99M ), 
                new Invoice( 56, "Jig saw", 21, 11M ), 
                new Invoice( 3, "Wrench", 34, 7.5M ) };

            // Display original array
            WriteLine("Original Invoice Data\n");
            WriteLine("P.Num Part Description     Quant Price"); // Column Headers
            WriteLine("----- -------------------- ----- ------");

            foreach (Invoice inv in invoices)
                WriteLine(inv);

            // Precondition: none
            //sort the Invoice objects by PartDescription
            var sortedPartDescription =  //variable that holds the sorted Invoice objects by PartDescription
                from a in invoices 
                orderby a.PartDescription // sort
                select a;
            WriteLine("\nsort the Invoice objects by PartDescription:");
            WriteLine("P.Num Part Description     Quant Price");
            WriteLine("----- -------------------- ----- ------");
            foreach (var pd in sortedPartDescription) //print objects after sorting by PartDescription
            {
                WriteLine($"{pd}");
            }
            // Precondition: none
            // Postcondition:sort the Invoice objects by Price
            WriteLine("\nsort the Invoice objects by Price:");
            WriteLine("P.Num Part Description     Quant Price");
            WriteLine("----- -------------------- ----- ------");
            var sortedByPrice =  // variable that holds the Invoice objects sorted by Price
                from b in invoices
                orderby b.Price
                select b;

            foreach (var p in sortedByPrice) //print objects after sorting by Price
            {
                WriteLine($"{p}");
            }

            // Precondition: none
            // Postcondition:select the PartDescription and Quantity and sort the results by Quantity
            WriteLine("\nselect the PartDescription and Quantity and sort the results by Quantity:");
            WriteLine("Part Description     Quant");
            WriteLine("----- -------------------- ----- ------");
            var selectPQ =    // variable that holds the selected PartDescription and Quantity
                from pq in invoices
                select new { pq.PartDescription, pq.Quantity }; 

            var order =       // variable that holds the selectPQ objects sorted by quantity
                from sortedOrder in selectPQ
                orderby sortedOrder.Quantity // sort results by quantity
                select sortedOrder;
            
            //print objects after sorting by quantity
            foreach (var orderByQ in order)  
            {
                WriteLine($"{orderByQ.PartDescription, -20} {orderByQ.Quantity,-10}");
            }


            // Precondition: none
            // Postcondition:select from each Invoice the PartDescription and the value of the Invoice 
            //               Order the results by Invoice value
            var ivalue =      // variable that holds the calculated total invoice values
                from IV in invoices
                let myIV = IV.Price * IV.Quantity // set the total invoice value
                select new { IV.PartDescription, myIV };

            var resultOrder =    // variable that holds calculated total invoice values by order
                from result in ivalue
                orderby result.myIV //order the results by invoice value
                select result;

            //print
            WriteLine("\nselect from each Invoice the PartDescription and the value of the Invoice\nOrder the results by Invoice value:");
            WriteLine("Part Description     Invoice Total");
            WriteLine("----- -------------------- ----- ------");
            foreach (var myOrder in resultOrder)
            {
                WriteLine($"{myOrder.PartDescription,-18}     {myOrder.myIV:c}"); //format the dispay
            }

            // Precondition: none
            // Postcondition:select the InvoiceTotals in the range $200 to $500."
            var r200to500 =  //variable that holds total value between 200 to 500
                from myValue in ivalue
                where (myValue.myIV >= 200) && (myValue.myIV <= 500) //select values from 200-500
                select myValue;

            //print
            WriteLine("\nselect the InvoiceTotals in the range $200 to $500:");
            WriteLine("Part Description     Invoice Total");
            WriteLine("----- -------------------- ----- ------");
            foreach (var value200to500 in r200to500)
                WriteLine($"{value200to500.PartDescription,-20}  {value200to500.myIV:c}");//format the dispay



        }
    }
}
