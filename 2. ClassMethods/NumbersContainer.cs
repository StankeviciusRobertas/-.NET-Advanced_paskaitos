using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._ClassMethods
{
    internal class NumbersContainer
    {
        public List<int> Numbers { get; set; } = new List<int>();

        public void AddNumber(int number)
        {
            Numbers.Add(number);
        }

        public void PrintAllNumbers()
        {
            foreach (int number in Numbers)
            {
                Console.WriteLine(number);
            }
        }
    }   
}
