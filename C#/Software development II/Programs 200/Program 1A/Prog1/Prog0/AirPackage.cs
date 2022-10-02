// Program 1A
// CIS 200-50
// Due: 9/27/2021
// By: 5461407
// an abstract class inherits from package

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{   
    public abstract class AirPackage : Package
    {
       // constructor
        public AirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight)
        : base(originAddress, destAddress, length, width, height, weight)
        {
         //empty body
        }


        public override string ToString()
        {
            return $"{base.ToString()}"; // Let base class help
        }
    }

}
