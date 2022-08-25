// Program 1A
// CIS 200-50
// Due: 9/27/2021
// By: 5461407
//concrete class inherits from AirPackage

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{   
    public class TwoDayAirPackage : AirPackage
    {
        public enum delivery {early, saver } // includes the delivery types
        decimal baseCost; //variable for base cost two day package cost
        
        const double sizeRate = 0.18, weightRate = 0.20;//rates for two day package cost

        protected delivery _deliveryType; // delivery type

        //constructor
        public TwoDayAirPackage(Address originAddress, Address destAddress, double length, double width, double height,
              double weight, delivery deliveryType)
        : base(originAddress, destAddress, length, width, height, weight)
        {
            DeliveryType = _deliveryType;
            baseCost = (decimal)(sizeRate * (length + width + height) + weightRate * (weight));// cost for early package
        }

        //property
        // Precondition: none
        // Postcondition: delivery type is decided
        protected delivery DeliveryType
        {
            get
            {
                return _deliveryType;
            }
            set
            {
                if (value == delivery.early || value == delivery.saver)
                {
                    _deliveryType = value;
                    
                }

                else
                    throw new ArgumentOutOfRangeException($"{nameof(DeliveryType)}", value,
                        $"{nameof(DeliveryType)} must be early or saver");

            }
        }

        //property of base cost to use in ToSring()
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
        //details of calculating two day air package
        public override decimal CalcCost()
        {

            decimal  twoDayPackageCost; //variables for two day package cost
            const decimal discountToSaver = 0.85m;//If the package is Saver delivery type, the final cost will be reduced by 15% 
            if (DeliveryType == delivery.saver) //provides a discount for saver package
            { twoDayPackageCost = BaseCost * discountToSaver; }
            else
            { twoDayPackageCost = BaseCost; }//when it is not a saver package

            return twoDayPackageCost; ;

        }

       
        public override string ToString()
        {
            string output;
            output = $"{base.ToString()}\n" + // Use base class string
                     $"Base Cost:{BaseCost:c}\n";

            if (DeliveryType == delivery.saver)//apply a discount for a saver package
            {
                output += $"Cost after 15% off for a saver package:{CalcCost():c}\n"; 
            }


            return output; 

        }

    }
}

 


