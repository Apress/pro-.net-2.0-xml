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
    }
}
