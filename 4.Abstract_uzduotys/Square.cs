using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Abstract_uzduotys
{
    internal class Square : GeometricShape
    {

        public double  Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }

        public override double GetArea()
        {
            return Side * Side;

        }
        public override double GetPerimeter()
        {
            return 4 * Side;
        }
    }
}
