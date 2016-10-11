using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WindowsApplication45
{
    [Serializable]
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

        private string Encode(string str)
        {
            byte[] data = ASCIIEncoding.ASCII.GetBytes(str);
            return Convert.ToBase64String(data);
        }

        private string Decode(string str)
        {
            byte[] data=Convert.FromBase64String(str);
            return ASCIIEncoding.ASCII.GetString(data);
        }

        [OnSerializing]
        public void OnSerializing(StreamingContext context)
        {
            strFName = Encode(strFName);
            strLName = Encode(strLName);
            strHPhone = Encode(strHPhone);
            strNotes = Encode(strNotes);
        }

        [OnSerialized]
        public void OnSerialized(StreamingContext context)
        {
            strFName = Decode(strFName);
            strLName = Decode(strLName);
            strHPhone = Decode(strHPhone);
            strNotes = Decode(strNotes);
        }

        [OnDeserializing]
        public void OnDeserializing(StreamingContext context)
        {
            //no code here
        }

        [OnDeserialized]
        public void OnDeserialized(StreamingContext context)
        {
            strFName = Decode(strFName);
            strLName = Decode(strLName);
            strHPhone = Decode(strHPhone);
            strNotes = Decode(strNotes);
        }

    }
}
