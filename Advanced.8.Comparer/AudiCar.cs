using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._8.Comparer
{
    internal class AudiCar : Car
    {
        public bool IsQuattro { get; set; }
        public AudiCar(bool isQuattro, string model, int maxFuelCapacity) : base(model, maxFuelCapacity)
        {
            IsQuattro = isQuattro;
        }
    }
}
