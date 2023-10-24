using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._8.InterfaceUzduotys
{
    internal class Carp : IFish
    {
        public string Name { get; set; }
        public int CompareTo(Dog? other)
        {
            return Name.CompareTo(other.Name);
        }
        public void Eat()
        {
            Console.WriteLine("Karpis valgo....");
        }
        public void Swim()
        {
            Console.WriteLine("Karpis going to swim");
        }        
    }
}
