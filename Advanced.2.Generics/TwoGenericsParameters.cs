using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._2.Generics
{
    public class TwoGenericsParameters<T1, T2>
    {
        private T1 PirmasParametras;
        private T2 AntrasParametras;

        public TwoGenericsParameters(T1 pirmas, T2 antras)
        {
            PirmasParametras = pirmas;
            AntrasParametras = antras;
        }

        public void SpausdintiT1()
        {
            Console.WriteLine("T1 reikšmė: " + PirmasParametras);
        }

        public void SpausdintiT2()
        {
            Console.WriteLine("T2 reikšmė: " + AntrasParametras);
        }

        public void PakeistiT1(T1 naujaReiksme)
        {
            this.PirmasParametras = naujaReiksme;
        }

        public void PakeistiT2(T2 naujaReiksme)
        {
            this.AntrasParametras = naujaReiksme;
        }
    }
}
