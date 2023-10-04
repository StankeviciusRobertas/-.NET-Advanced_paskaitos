using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _.NET_Advanced_paskaitos
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }

        public Person()
        {
            Name = "Robertas";
            Age = 34;
        }
        public Person(double height) : this()
        {
            Height = height;
        }
    }
}
