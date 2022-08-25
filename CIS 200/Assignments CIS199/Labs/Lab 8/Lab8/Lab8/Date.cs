using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Date
    {   // private backing fields
        private int _month;
        private int _day;
        private int _year;

        public Date(int m, int d, int y) // constructor
        {
            // preconditions: 0<m<=12
            //                0<d<=31
            //                y>=0
            Month = m;
            Day = d;
            Year = y;
        }


        public int Month 
            {
            get
            {
                return _month;
            }
            set
            {
                if (value > 0 && value <= 12)
                    _month = value;
                else
                    _month = 1;
            }
            }

        public int Day
        {
            get
            {
                return _day;
            }
            set
            {
                if (value > 0 && value <= 31)
                    _day = value;
                else
                    _day = 1;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value >= 0)
                    _year = value;
                else
                    _year = 2019;
            }
        }

        public override string ToString()
        {
            string outPut;

            outPut = $"{Month:D2}/{Day:D2}/{Year:D4}";

            return outPut;

        }
    }
}
