using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Abstrakcijos
{
    internal class Kate : Gyvunas
    {
        public Kate(string vardas, int svoris) : base(vardas, svoris)
        {

        }
        public override void Kalbek()
        {
            Console.WriteLine("Mew mew");
        }
    }
}
