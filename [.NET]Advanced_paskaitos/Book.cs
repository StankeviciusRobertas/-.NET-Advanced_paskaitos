using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _.NET_Advanced_paskaitos
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public DateOnly Date { get; set; }
        public string RealeseCountry { get; set; }

        public Book()
        {
            Name = ".Net programavimo kalba";
            Author = "Robertas St";
            Date = new DateOnly(2023,10,04);            
        }
        public Book(string releaseCountry) : this()  
        {
            RealeseCountry = releaseCountry;
        }
    }
}
