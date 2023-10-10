using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Abstrakcijos
{
    internal class Suo : Gyvunas
    {
        public Suo(string vardas, int svoris) : base(vardas, svoris)
        {

        }
        public override void Kalbek()
        {
            Console.WriteLine("Woof woof");
        }
    }
}
