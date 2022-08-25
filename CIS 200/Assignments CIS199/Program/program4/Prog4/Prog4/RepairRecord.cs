using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class RepairRecord
    {
        //private backing fields
        private int _serviceLocationZipCode; // int between 00000-99999, otherwise 40204
        private string _makeModel; // model name
        private string _serialNumber;// length must be 10 characters
        private int _year; //an integer
        private int _appointmentLength; // appointment time in minutes, 15 <= value <=180, otherwise set to 30
        private string _technicianName; // Technician name, otherwise set to John Smith
        private bool _warranty; // T/F
        private double _appointmentHour;// appointment time in hours, appointmentlength/60

        // constructor
        public RepairRecord(int zip, string model, string sn, int year, int length, string name, bool warranty)
        {
            //precondition: 00000<=zip<=99999
            //              when model is invalid, set to "Unknown Make/Model"
            //              sn.Length == 10
            //              int year
            //              15 <= length <=180
            //              when name is invalid, set to "John Smith"
            //              warranty == T or warranty == F       
            //postcondition: The RepairRecord object has been initialized

            ServiceLocationZipCode = zip; // set the ServiceLocationZipCode property
            MakeModel = model; // set the MakeModel property
            SerialNumber = sn;// set the SerialNumber property
            Year = year;// set the Year property
            AppointmentLength = length;// set the AppointmentLength property
            TechnicianName = name;// set the TechnicianName property
            Warranty = warranty;// set the Warranty property
        }

        public int ServiceLocationZipCode
        {
            //precondition: zip code must in between 00000 and 99999, otherwise set to 40204.
            //postcondition: zip has been return
            get
            {
                return _serviceLocationZipCode;
            }

            set
            {
                if (value >= 00000 && value <= 99999)
                    _serviceLocationZipCode = value;
                else                                  // when invalid, set to 40204
                    _serviceLocationZipCode = 40204;
            }
        }

        public string MakeModel
        {
            //precondition: with no value or invalid value, set to "Unknown Make/Model"
            //postcondition: makeModel or "Unknown Make/Model" has been return
            get
            {
                return _makeModel;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))// when value is empty
                    _makeModel = "Unknown Make/Model";
                else
                    _makeModel = value;

            }
        }

        public string SerialNumber
        {
            //precondition: serial number must be 10 characters,
            //              with no value or invalid value, set to "A000000000"
            //postcondition: serialNum has been returned
            get
            {
                return _serialNumber;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length > 10 || value.Length < 10) // when value is empty or serial number is not 10 characters
                    _serialNumber = "A000000000";
                else
                    _serialNumber = value;
            }

        }

        public int Year
        {
            //precondition: an integer
            //postcondition: Year has been return
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        public string TechnicianName
        {
            //precondition: with no value or invalid value, set to "John Smith"
            //postcondition: technicianName has been returned
            get
            {
                return _technicianName;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value)) // when there is no value
                    _technicianName = "John Smith";
                else                                
                    _technicianName = value;
            }
        }

        public int AppointmentLength
        {
            //precondition: 15 <= value <=180, otherwise set to 30
            //postcondition: length has been returned
            get
            {
                return _appointmentLength;
            }

            set
            {
                if (value >= 15 && value <= 180)
                {
                    _appointmentLength = value;
                    _appointmentHour =(double) AppointmentLength / 60; // calculate appointment length in hour
                }
                else
                {
                    _appointmentLength = 30; // set to 30 if value is invalid
                    _appointmentHour =(double) AppointmentLength / 60;
                }
            }

        }

        public double AppoitmentHour
        {
            get
            {
                return _appointmentHour;
            }
        }


        public bool Warranty
        {
            //precondition: T/F
            //postcondition: warranty has been return
            get
            {
                return _warranty;
            }
            set
            {
                _warranty = value;
            }
        }

        // method to calculate cost
        public double CalcCost()
        {
            const int baseFee = 25; // a flat fee when warranty is not covered
            const double rate = 1.50; // price rate per minute
            double costWithNoWarranty; // cost without warranty
            const int costWithWarranty = 20; // 20 per visit with warranty

            costWithNoWarranty = baseFee + rate * AppointmentLength; // calculate cost with no warranty

            if (Warranty == false) // when there is no warranty
                return costWithNoWarranty;
            else                  // where warranty is covered
                return costWithWarranty;
        }

        public override string ToString() // override 
        {
            string outPut;    // build the output with the set properties       
            double cost;         
            if (Warranty == false)
                cost = CalcCost(); // call the method to set the cost when warranty is not covered
            else
                cost = CalcCost();// call the method to set the cost when warranty is covered

            outPut = $"Service Location zip code: {ServiceLocationZipCode} \n" +
                $"Year: {Year}\n" +
                $"Make and Model: {MakeModel}\n" +
                $"Serial Number: {SerialNumber}\n" +
                $"Appointment Length: {AppointmentLength}\n" +
                $"Appointment Hours: {AppoitmentHour}\n" +
                $"Technician Name: {TechnicianName}\n" +
                $"Warranty Coverage: {Warranty}\n" +
                $"Calculate Cost Output: {cost}\n";

            return outPut;
        }
    }
}

