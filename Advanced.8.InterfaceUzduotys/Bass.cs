using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._8.InterfaceUzduotys
{
    internal class Bass : IFish
    {
        public string Name { get; set; }
        public int CompareTo(Dog? other)
        {
            return Name.CompareTo(other.Name);
        }
        public void Eat()
        {
            Console.WriteLine("Bass valgo....");
        }
        public void Swim()
        {
            Console.WriteLine("Bass going to swim");
        }
    }
}
