using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication45
{
    public class Employee
    {
        private int intID;
        private string strFName;
        private string strLName;
        private string strHPhone;
        private string strNotes;
        private string[] strEmails;
        private EmployeeType enumType;
        private Address objAddress=new Address();

        public int EmployeeID
        {
            get
            {
                return intID;
            }
            set
            {
                intID = value;
            }
        }

        public string FirstName
        {
            get
            {
                return strFName;
            }
            set
            {
                strFName = value;
            }
        }

        public string LastName
        {
            get
            {
                return strLName;
            }
            set
            {
                strLName = value;
            }
        }

        public string HomePhone
        {
            get
            {
                return strHPhone;
            }
            set
            {
                strHPhone = value;
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

        public EmployeeType Type
        {
            get
            {
                return enumType;
            }
            set
            {
                enumType = value;
            }
        }

        public string[] Emails
        {
            get
            {
                return strEmails;
            }
            set
            {
                strEmails = value;
            }
        }

        public Address Address
        {
            get
            {
                return objAddress;
            }
            set
            {
                objAddress = value;
            }
        }
    }

}
