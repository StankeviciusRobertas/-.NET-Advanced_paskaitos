using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._7.Lambda
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Pet> Pets { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Pets = new List<Pet>();
        }

    }
}
