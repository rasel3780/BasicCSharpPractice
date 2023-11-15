using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Person_Example
{
    internal class Person
    {
        public string firtName;
        public string middleName;
        public string lastName;

        public string GetFullName()
        {
            string fullName;
            fullName = firtName + " " + middleName + " " + lastName;
            return fullName;
        }

        public string GetReverseFullName()
        {
            string fullName = GetFullName();
            string revFullName = "";
            for(int i= fullName.Length-1; i>=0; i--) 
            {
                revFullName += fullName[i];
            }
            return revFullName;
        }
    }
}
