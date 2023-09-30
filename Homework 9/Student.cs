using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    internal class Student : Person
    {
        public Student()
        {


        }

        public string Name;
        public string ;
        public int age;
        public string address;

        public string GetFullName()
       


        {
            return Name + " " + surname;
        }


        public string GetAllFullData()
        {
            string result = GetFullName();
            resutl += " - Telebe";
            return id + " " + address + Name + " " + GetFullName() + " " + age;

        }
    }


    }
}
