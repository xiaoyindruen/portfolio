using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    //creats the asbstract base class Parcel
    public abstract class Parcel
    {
        //backing fields for original address and destination address
        private Address originalAddress;
        private Address destinationAddress;

        //constructor
        //precondition: original address and destination address use default constructor 
        //postcondition: original address and destination address following the format
        public Parcel(Address originalAddress, Address destinationAddress)
        {
            OriginalAddress = originalAddress;
            DestinationAddress = destinationAddress;
        }

        //constructors for sending address and receiving address
        //precondition: original address can be empty
        //postcondition: original address must not be empty 
        public Address OriginalAddress
        {
            get
            {
                return originalAddress;
            }
            set
            {
                if (value != null) // validates original address is not empty
                    originalAddress = value;
            }
        }
        //precondition: destination address can be empty
        //postcondition: destination address must not be empty 
        public Address DestinationAddress
        {
            get
            {
                return destinationAddress;
            }
            set
            {
                if (value != null)// validates denstination address is not empty
                    destinationAddress = value;
            }
        }
        //precondition: CalcCost method does not exist
        //postcondition: CalcCost method can be overriden by child classes of Parcel class
        public abstract decimal CalcCost(); // abstract method to calculate cost
    }

    //creats a child class of Parcel
    public class Letter : Parcel
    {
        private decimal fixedCost;
        // constructor based on Parcel, adds fixedcost in
        public Letter(Address originalAddress, Address destinationAddress, decimal fixedCost)
           : base(originalAddress, destinationAddress)
        {
            FixedCost = fixedCost;
        }

        // Properties
        //precondition: fixed cost is not limited to any values
        //postcondition: fixed cost must not be negative
        private decimal FixedCost
        {
            get
            {
                return fixedCost;
            }
            set
            {
                if (value <= 0M) // validates cost is not negative
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(FixedCost)} must be > 0 ");
                }

                fixedCost = value;
            }
        }
        // the method to overrive the abstract method to calculate the letter cost
        //precondition: use the abstract method
        //postcondition: override the abstract method 
        public override decimal CalcCost()
        {
            return FixedCost;
        }

        // return string of Letter
        //precondition: use the default
        //postcondition: built a new string format 
        public override string ToString() =>
          
            $"From:\n{OriginalAddress}\n" +
            $"To:\n{DestinationAddress}\n" +
            $"Sending cost: {FixedCost:c2}";


    }
}
