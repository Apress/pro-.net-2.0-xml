using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;

namespace EmployeeLibrary
{
    [DataContract]
    public class Employee
    {
        private int intID;
        private string strFName;
        private string strLName;

        [DataMember]
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

        [DataMember]
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

        [DataMember]
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
    }
}
