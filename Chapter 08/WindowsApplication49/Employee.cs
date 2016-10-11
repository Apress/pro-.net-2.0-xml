using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WindowsApplication49
{
    [XmlRoot(ElementName="MyEmployee")]
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

        [XmlAttribute(AttributeName="EmployeeCode")]
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

        [XmlElement(ElementName="FName")]
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

        [XmlElement(ElementName = "LName")]
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

        [XmlIgnore]
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

        [XmlElement(ElementName="Remarks")]
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

        [XmlElement(ElementName="EmployeeType")]
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

        [XmlArray(ElementName="EmailAddresses")]
        [XmlArrayItem(ElementName="Email")]
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

        [XmlElement(IsNullable=true)]
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
