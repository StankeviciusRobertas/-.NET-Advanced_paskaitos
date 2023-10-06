using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InheritanceAndVirtualMethods
{
    internal class TransportCar : Transport
    {
        public override double MeasuredSpeed()
        {
            return 90;
        }
    }
}
