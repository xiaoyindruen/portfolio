﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   
    //builds the address class
    public class Address
    {

            // backing fields 
            private string name;
            private string address1;
            private string address2;
            private string city;
            private string state;
            private int zip;

            // constructor to display a full address with address2
            public Address(string name, string address1, string address2, string city, string state, int zip) 
            {
                Name = name;
                Address1 = address1;
                Address2 = address2;
                State = state;
                City = city;
                Zip = zip;
            }

        // overloading constructor without address2
        public Address(string name, string address1,  string city, string state, int zip) 
            {
            Name = name;
            Address1 = address1;
            Address2 = address2;
            State = state;
            City = city;
            Zip = zip;
             }

        //Properties
        private string Name
            {
                get { return name; }

                set
                {
                if (string.IsNullOrWhiteSpace(value)) // validation, name can not be white space or empty
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(Name)} must not be empty");
                }
                    name = value;
                }
            }

            private string Address1
            {
                get { return address1; }

                set
            {
                if (string.IsNullOrWhiteSpace(value))// validation, address1 can not be white space or empty
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(Address1)} must not be empty");
                }
                address1 = value;
                }
            }

            private string Address2
            {
                get { return address2; }

                set
                {
                    if (String.IsNullOrWhiteSpace(value)) //when address2 is empty or white space, trim the white space
                    {
                    address2 ="";
                    }
                    else
                    address2 = value; // when address is not empty
                }
            }

            private string City
            {
                get { return city; }

                set
                {
                if (string.IsNullOrWhiteSpace(value))// validation, city can not be white space or empty
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(City)} must not be empty");
                }
                city = value;
                }
            }

            private string State
            {
                get { return state; }

                set
                {
                if (string.IsNullOrWhiteSpace(value))// validation, state can not be white space or empty
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(State)} must not be empty");
                }
                state = value;
                }
            }

            private int Zip
            {
                get { return zip; }

                set
                {
                    if (value < 0 || value > 99999) // validation, zip must be between 0 to 99999
                    {
                        throw new ArgumentOutOfRangeException(nameof(value),
                           value, $"{nameof(Zip)} must be > 0 and < 99999");
                    }

                    zip = value;
                }
            }
        //return string of Address
        public override string ToString()
        {
            string output;
            output = $"{Name}\n{Address1}\n";

            if (Address2 == "") //if address2 is empty, the address is 3 lines
            { output += $"{City},{State},{Zip:d5} "; }
            else
            { output += $"{Address2}\n{City},{State},{Zip:d5} "; }//if address2 is not empty, the address is 4 lines including address2
            return output;

        }
            
    }
    }

