using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InheritanceAndVirtualMethods
{
    internal class Square : Polygon
    {
        public double Size { get; set; }

        public Square()
        {
            NumberOfAngles = 4;
        }

        public Square(double size)
        {
            Size = size;
            NumberOfAngles = 4;
        }

        public override double GetPerimeter()
        {
            return Size * NumberOfAngles;
        }
    }
}
