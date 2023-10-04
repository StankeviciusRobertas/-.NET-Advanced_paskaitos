using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _.NET_Advanced_paskaitos
{
    public class Car
    {
        internal object Description;

        public string Brand { get; set; }
        public int Doors { get; set; }
        public double MaxSpeed { get; set; }
        public DateTime CreationDate { get; set; }
        public Engine Engine { get; set; }
        public List<Wheel> Wheels { get; set; }

        public Car()
        {
            Brand = "Lexus";            
            CreationDate = DateTime.Now;
        }

        public Car(string brand) : this()
        {
            Brand = brand;
            CreationDate = DateTime.Now;
        }

    }
}
