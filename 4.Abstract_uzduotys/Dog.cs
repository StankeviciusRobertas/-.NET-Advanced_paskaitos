using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Abstract_uzduotys
{
    internal class Dog : Animal
    {
        public string Noise { get; set; }

        public Dog(string noise)
        {
            Noise = noise;
        }

        public override string MakeNoise()
        {
            return "au au au";
        }
    }
}
