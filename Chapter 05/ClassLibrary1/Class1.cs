using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Employee
    {
        private int intEmployeeID;
        private string strFirstName;
        private string strLastName;
        private string strHomePhone;
        private string strNotes;

        public int EmployeeID
        {
            get
            {
                return intEmployeeID;
            }
            set
            {
                intEmployeeID = value;
            }
        }

        public string FirstName
        {
            get
            {
                return strFirstName;
            }
            set
            {
                strFirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return strLastName;
            }
            set
            {
                strLastName = value;
            }
        }

        public string HomePhone
        {
            get
            {
                return strHomePhone;
            }
            set
            {
                strHomePhone = value;
            }
        }

        public string Notes
        {
            get
            {
                return strNotes;
            }
            set
            {
                strNotes = value;
            }
        }
    }
}
