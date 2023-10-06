using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._ClassMethods
{
    internal class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public void CalculateArea()
        {
            int result = Height * Width;
            Console.WriteLine($"Rectangle area: {result}");
        }

        public void CalculatePerimeter()
        {
            int result = 2 * (Height + Width);
            Console.WriteLine($"Rectangle perimeter: {result}");
        }
    }
}
