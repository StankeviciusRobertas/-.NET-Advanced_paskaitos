using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._8.Comparer
{
    internal class BmwCar : Car
    {
        public bool IsXDriver { get; set; }
        public BmwCar(bool isXDriver, string model, int maxFuelCapacity) : base(model, maxFuelCapacity)
        {
            IsXDriver = isXDriver;
        }
    }
}
