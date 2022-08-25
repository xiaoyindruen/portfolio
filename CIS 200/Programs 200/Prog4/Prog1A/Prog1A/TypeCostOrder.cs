// Program 4
// CIS 200-50
// Fall 2021
// Due: 11/29/2021
// By: 5461407
// A class to sort the parcel list asscending by the name of the parcel type then descending by cost within grouping


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    // Precondition:  None
    // Postcondition: sorts the parcel list asscending by the name of the parcel type then descending by cost within grouping
    //                When p1 < p2, method returns positive #
    //                When p1 == p2, method returns zero
    //                When p1 > p2, method returns negative #
    class TypeCostOrder :Comparer<Parcel>
    {
        public override int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null && p2 == null)
                return 0; //when both p1 and p2 are null

            if (p1 == null)
                return -1;

            if (p2 == null)
                return 1;

            // asscending by the name of the parcel type then descending by cost within grouping
            int result = p1.GetType().ToString().CompareTo(p2.GetType().ToString());//result of comparing the parcel type string

            if ( result == 0) //when the parcel is from the same type
            {
                // sort by number by the name of the parcel type
                return (-1)*p1.CompareTo(p2); // multiplying by -1 to reverse the nature order
            }
            else
            {
                return result;
            }
                               
        }

    }
}
