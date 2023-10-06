using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InheritanceAndVirtualMethods
{
    internal class Employe
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employe(string name)
        {
            Name = name;
        }

        public Employe()
        {

        }
    }
}
