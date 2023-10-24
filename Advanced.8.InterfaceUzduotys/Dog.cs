using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._8.InterfaceUzduotys
{
    internal class Dog : IMammal, IComparable<Dog>
    {
        public string Name { get; set; }
        public int CompareTo(Dog? other)
        {
            return Name.CompareTo(other.Name);
        }

        public void Eat()
        {
            Console.WriteLine("Dog valgo....");
        }
        public void GiveBirth()
        {
            Console.WriteLine("Dog have new puppies");
        }
    }
}
