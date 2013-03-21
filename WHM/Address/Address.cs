using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WHM
{
    class Address
    {
        #region Fields
        public int AppartmentNumber { get; set; }
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public PostalCode PostalCode { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string Region { get; set; }
        #endregion

        #region Constructors
        public Address(int apptnum, int streetnum, string streetname, PostalCode postalcode, string country, string prov, string region)
        {
            AppartmentNumber = apptnum;
            StreetName = streetname;
            StreetNumber = streetnum;
            PostalCode = postalcode;
            Country = country;
            Province = prov;
            Region = region;

        }
        #endregion 

    }
}
