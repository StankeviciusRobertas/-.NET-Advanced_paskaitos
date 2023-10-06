using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._ClassMethods
{
    internal class Book
    {
        public string Books { get; set; }

        public Book(string book)
        {
            Books = book;
        }

        public override string ToString()
        {
            return Books;
        }
    }
}
