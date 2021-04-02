using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valueAndReferance
{
    class Person
    {
        public string firstName;
        public string lastName;
        public string getFullName()
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }
    }
}
