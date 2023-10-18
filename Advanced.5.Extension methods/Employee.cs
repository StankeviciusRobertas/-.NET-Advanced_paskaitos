using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._5.Extension_methods
{
    public class Employee
    {
        private string alias;
        private string name;

        public int Age { get; set; }

        public static string Nationality { get; set; }

        public Employee(string alias, string name)
        {
            this.alias = alias;
            this.name = name;

            this.Age = 33;
            Nationality = "Lietuvis"; // negalime naudoti this nes tai statinis propertis

            this.SayHello();
            SayHelloStatic(); // negalime naudoti this nes tai statinis metodas
        } 

        public void SayHello()
        {
            Console.WriteLine("Sveiki");
        }

        public static void SayHelloStatic()
        {
            Console.WriteLine("Sveiki is statinio metodo");
        }
    }
}
