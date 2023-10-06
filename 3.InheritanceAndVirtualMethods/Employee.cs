using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InheritanceAndVirtualMethods
{
    internal class Employee : Human
    {
        public double Salary { get; set; }
        public DateTime EmploymentDate { get; set; }
    }
}
