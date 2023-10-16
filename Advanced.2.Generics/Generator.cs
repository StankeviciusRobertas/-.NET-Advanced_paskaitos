using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._2.Generics
{
    internal class Generator<T>
    {
        public void Show(T obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
