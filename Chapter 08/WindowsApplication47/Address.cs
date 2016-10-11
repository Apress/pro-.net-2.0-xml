using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication45
{
    public class Address
    {
        private string strStreet;
        private string strCity;
        private string strState;
        private string strCountry;
        private string strPostalCode;

        public string Street
        {
            get
            {
                return strStreet;
            }
            set
            {
                strStreet = value;
            }
        }

        public string City
        {
            get
            {
                return strCity;
            }
            set
            {
                strCity = value;
            }
        }

        public string State
        {
            get
            {
                return strState;
            }
            set
            {
                strState = value;
            }
        }

        public string Country
        {
            get
            {
                return strCountry;
            }
            set
            {
                strCountry = value;
            }
        }

        public string PostalCode
        {
            get
            {
                return strPostalCode;
            }
            set
            {
                strPostalCode = value;
            }
        }
    }
}
