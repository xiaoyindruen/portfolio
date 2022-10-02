using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //creats the asbstract base class Parcel
    public abstract class Parcel 
    {   
        //backing fields for original address and destination address
        private Address originalAddress;
        private Address destinationAddress;

        //constructor
        public Parcel(Address originalAddress, Address destinationAddress) 
        {
            OriginalAddress = originalAddress;
            DestinationAddress = destinationAddress;
        }

        //constructors for sending address and receiving address
        public Address OriginalAddress
        {
            get
            {
                return originalAddress;
            }
            set
            {
                if (value!=null) // validates original address is not empty
                originalAddress = value;
            }
        }
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
        private decimal FixedCost
        {
            get
            {
                return fixedCost;
            }
            set
            {
                if (value <= 0M ) // validates cost is not negative
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(FixedCost)} must be > 0 ");
                }

                fixedCost = value;
            }
        }
        // the method to overrive the abstract method to calculate the letter cost
        public override decimal CalcCost() 
        {
            return FixedCost;
        }

        // return string of Letter
        public override string ToString() => 
            $"From:\n{OriginalAddress}\n" +
            $"To:\n{DestinationAddress}\n" +
            $"Sending cost: {FixedCost:c2}";


    }
}


