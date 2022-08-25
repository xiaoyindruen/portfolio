// Program 1A
// CIS 200-50
// Due: 9/27/2021
// By: 5461407
// a concrete class inherits from AirPackage

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{ 
    public class NextDayAirPackage : AirPackage
    {
        private readonly decimal _expressFee; // a fee that is different from store to store
        protected decimal baseCost, heavyPackageCost, largePackageCost; //different kinds of cost included in nextdaypackage
        protected const double baseRateSize = 0.35, baseRateWeight = 0.25, heavyRate = 0.20, largeRate = 0.22; //rates to caculate next day package

        //constructor
        public NextDayAirPackage(Address originAddress, Address destAddress, double length, double width,
            double height, double weight, decimal expressFee)
            : base(originAddress, destAddress, length, width, height, weight)
        {
            BaseCost = (decimal)(baseRateSize * (length + width + weight) + baseRateWeight * (weight)) + ExpressFee;
            HeavyPackageCost = (decimal)(weight * heavyRate);//extra cost for heavy packages
            LargePackageCost = (decimal)(largeRate * (length + width + height));//extra cost for large packages
        }


        //property for ExpressFee
        // Precondition: none
        // Postcondition: expressfee is ready only
        protected decimal ExpressFee
        {
            get
            {
                return _expressFee;
            }
        }

        // set properties for baseCost, heavyPackageCost, largePackageCost so ToString methods can access the datas
        protected decimal BaseCost
        {
            get
            {
                return baseCost;
            }

            set
            {
                baseCost = value;  
            }

        }

        protected decimal HeavyPackageCost
        {
            get
            {
                return heavyPackageCost;
            }

            set
            {
                heavyPackageCost = value;//extra cost for heavy packages
            }

        }

        protected decimal LargePackageCost
        {
            get
            {
                return largePackageCost;
            }

            set
            {
                largePackageCost = value;//extra cost for large packages
            }

        }

        //details of calculating cost of next day package
        public override decimal CalcCost()
        {
            decimal nextDayPackageCost;//variable for holding different kinds of cost included in nextdaypackage


            if (IsHeavy == true)//when package is heavy
            { nextDayPackageCost = HeavyPackageCost + BaseCost; }
            else
            { nextDayPackageCost = BaseCost; }

            if (IsLarge == true)//when package is large
            { nextDayPackageCost = LargePackageCost + BaseCost; }
            else
            { nextDayPackageCost = BaseCost; }

            if (IsHeavy == true && IsLarge == true)//when package is large and heavy
            { nextDayPackageCost = LargePackageCost + HeavyPackageCost + BaseCost; }
            else
            { nextDayPackageCost = BaseCost; }

            return nextDayPackageCost;

        }

        public override string ToString()
        {
            return $"Total cost:{base.ToString()}\n" + //Let base class help
                   $"Base Cost:{BaseCost:c}\n" +
                   $"Extra cost for heavy weight:{HeavyPackageCost:c}\n" +
                   $"Extra cost for large size:{LargePackageCost:c}\n";
        }
    }
}

