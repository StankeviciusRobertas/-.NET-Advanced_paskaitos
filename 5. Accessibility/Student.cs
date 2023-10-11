using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Accessibility
{
    internal class Student : Person
    {        
        private string StudentId { get; set; }

        public Student(string name, int age, string studentId) : base(name, age)
        {
            StudentId = studentId;      
        }
        
        public string GetSudentId()
        {
            return StudentId;
        }        
    }
}
