using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Address
    {
        public int StreetNumber { get; set; }

        public string StreetName { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public int ZipCode { get; set; }


        public Address()
        {
            StreetNumber = 0;
            StreetName = "";
            State = "";
            City = "";
            ZipCode = 0;
        }

        public Address(int streetNumber, string streetName, string state, string city, int zipCode);
        

    }
}
