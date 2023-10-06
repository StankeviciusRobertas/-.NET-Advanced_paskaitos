using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._ClassMethods
{
    internal class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void CircleArea()
        {
            double area = Math.PI * Radius * Radius;
            Console.WriteLine($"Circle area: {area}");
        }
    }
}
