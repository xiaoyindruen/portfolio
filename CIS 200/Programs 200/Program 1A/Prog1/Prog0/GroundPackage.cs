// Program 1A
// CIS 200-50
// Due: 9/27/2021
// By: 5461407
//GroundPackage inherutes from Package

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{   
    
    public class GroundPackage : Package
    {
        private readonly int _zoneDistance; //distance between two addresses
        const int zipDigit = 10000; // used for geting the first number of zip code

        //constructor
        public GroundPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight, int zoneDistance)
            : base(originAddress, destAddress, length, width, height, weight)
        {
            _zoneDistance = Math.Abs(originAddress.Zip / zipDigit - destAddress.Zip / zipDigit);// a positive int decided by zip codes
        }
        //property for ZoneDistance
        // Precondition: none
        // Postcondition: zonedistance is ready only
        public int ZoneDistance
        {
            get {
                return _zoneDistance;
            }
        }

        //put details in the CalcCost method for ground packages
        public override decimal CalcCost()
        {

            decimal groundPackageCost;//variables needed for calculating the cost
            const double baseSizeRate=0.15, zoneRate=0.07; //rates for ground package cost

                groundPackageCost =(decimal)( baseSizeRate * (Length + Width + Height) + zoneRate * (ZoneDistance + 1) * (Weight));

            return groundPackageCost;
        }

        public override string ToString()
        {
            return $"{base.ToString()}"; // Use base class string
        }

    }

    }

