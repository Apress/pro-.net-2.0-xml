using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication45
{
    public class Manager:Employee
    {
        private int intNoOfSubordinates;

        public int NoOfSubordinates
        {
            get
            {
                return intNoOfSubordinates;
            }
            set
            {
                intNoOfSubordinates = value;
            }
        }
    }
}
