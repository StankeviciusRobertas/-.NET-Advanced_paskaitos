using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Abstrakcijos
{
    internal abstract class Gyvunas
    {
        public string Vardas { get; set; }
        public int Svoris { get; set; }

        public Gyvunas(string vardas, int svoris)
        {
            Vardas = vardas;
            Svoris = svoris;
        }

        public abstract void Kalbek();
        public void ParasykVarda()
        {
            Console.WriteLine($"Mano vardas: {Vardas}");
        }
    }
}
