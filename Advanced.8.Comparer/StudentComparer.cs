﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._8.Comparer
{
    internal class StudentComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            if (x.Year > y.Year)
            {
                return -1;
            }
            else if(x.Year < y.Year)
            {
                return 1;
            }
            else
            {
                return 0;
            }            
        }
    }
}
