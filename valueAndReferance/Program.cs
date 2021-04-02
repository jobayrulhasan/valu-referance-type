using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valueAndReferance
{
    class Program
    {
        static void Main(string[] args)
        {
            //int firstNumber = 100;
            //int secondNumber = firstNumber;
            //firstNumber = 200;
            //Console.WriteLine(secondNumber);

            Person person;
            person = new Person();
            person.firstName = "Saiful";
            person.lastName = "Islam";
            string fullname = person.getFullName();
            Console.WriteLine(fullname);


            Person person2;
            person2 = new Person();
            person2 = person; //person jake point kora person2 take point kora.
            person2.lastName = "Hamid";
            fullname = person2.getFullName();
            Console.WriteLine(fullname);

            Person person3;
            person3 = new Person();
            person3 = person;
            person3.firstName = "Jobayrul";
            person3.lastName = "Hasan";
            fullname = person3.getFullName();
            Console.WriteLine(fullname);

            Console.ReadKey();
        }
    }
}
