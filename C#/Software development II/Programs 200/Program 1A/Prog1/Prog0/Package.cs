// Program 1A
// CIS 200-50
// Due: 9/27/2021
// By: 5461407
//An abstract class inherits from Parcel

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{    
    public abstract class Package : Parcel
    {
        protected double _length, _width, _height, _weight; //variables will be used in Package class
        protected bool isHeavy, isLarge; // will used to decide cost of package
        const int heavyWeight = 75, largeSize = 100;// constants for package cost standards

        //constructor 
        public Package(Address originAddress, Address destAddress, double length, double width, double height, double weight)
       : base(originAddress, destAddress)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }

        //Properties
        // Precondition:  none
        // Postcondition: IsHeavy is decided by package's weight
        protected bool IsHeavy
        {
            get
            {
                return isHeavy;
            }
            set
            {
                if (Weight >= heavyWeight)
                    isHeavy = true;
            }
        }

        // Precondition:  none
        // Postcondition: IsLarge is decided by package's length, width and height       
        protected bool IsLarge
        {
            get
            {
                return isLarge;
            }
            set
            {
                if (Length + Width + Height >= largeSize)
                    isLarge = true;
            }
        }
        //property for length
        // Precondition:  none
        // Postcondition: Length is a postive double
        protected double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value >= 0)
                    _length = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Length)}", value,
                        $"{nameof(Length)} must be >= 0");
            }
        }

        //Property for width
        // Precondition:  none
        // Postcondition: Width is a postive double
        protected double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value >= 0)
                    _width = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Width)}", value,
                        $"{nameof(Width)} must be >= 0");
            }


        }
        //Property for height
        // Precondition:  none
        // Postcondition: Height is a postive double
        protected double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value >= 0)
                    _height = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Height)}", value,
                        $"{nameof(Height)} must be >= 0");
            }

        }
        //Property for weight
        // Precondition:  none
        // Postcondition: Weight is a postive double
        protected double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value >= 0)
                    _weight = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Weight)}", value,
                        $"{nameof(Weight)} must be >= 0");
            }
        }

        
        public override string ToString()
        {
            return $"{base.ToString()}"; // Let base class help
        }



    }
 }
