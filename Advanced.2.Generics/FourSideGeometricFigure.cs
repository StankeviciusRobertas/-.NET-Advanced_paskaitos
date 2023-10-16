﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._2.Generics
{
    internal class FourSideGeometricFigure
    {
        public string Name { get; set; }
        public double Base { get; set; }
        public double Height { get; set; }

        public FourSideGeometricFigure(string name, double @base, double height)
        {
            Name = name;
            Base = @base;
            Height = height;
        }

        public double GetArea()
        {
            return Base * Height;
        }

        public override string ToString()
        {
            return $"Figure: {Name}, Base: {Base}, Height: {Height}, Area: {GetArea()}";
        }
    }
}
