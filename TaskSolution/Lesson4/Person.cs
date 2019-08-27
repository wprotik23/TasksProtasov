using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Person
    {
        public string name { get; set; }

        public int age { get; set; }

        public IEnumerable<string> PhoneNumbers { get; set; }

        public Person(string name, int age, IEnumerable<string> PhoneNumbers)
        {
            this.name = name;
            this.age = age;
            this.PhoneNumbers = PhoneNumbers;

        }
    }
}
