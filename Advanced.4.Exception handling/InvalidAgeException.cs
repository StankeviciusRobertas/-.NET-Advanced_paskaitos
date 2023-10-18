using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._4.Exception_handling
{
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }
}
