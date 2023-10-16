using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._2.Generics
{
    internal class TypeHolder<T1, T2>
    {
        public void GetType(T1 input)
        {
            Console.WriteLine($"Type of input: {input.GetType()}");
        }

        public void GetType(T2 input)
        {
            Console.WriteLine($"Type of input: {input.GetType()}");
        }
    }
}
