// Program 4
// CIS 200-50
// Fall 2021
// Due: 11/29/2021
// By: 5461407
// A class to sort the parcel list by descending the zip code of its destination zip code

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    // Precondition:  None
    // Postcondition: Order the parcle list by descending the zip code of its destination zip code 
    //                When p1 < p2, method returns positive #
    //                When p1 == p2, method returns zero
    //                When p1 > p2, method returns negative #
    public class DescendingZipCode: Comparer<Parcel> 
    {
        public override int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null && p2 == null)
                return 0; //when both p1 and p2 are null

            if (p1 == null)
                return -1;

            if (p2 == null)
                return 1;

            return (-1)*p1.DestinationAddress.Zip.CompareTo(p2.DestinationAddress.Zip); // by miltiplying -1 to reverse the order
        }
    }
}
