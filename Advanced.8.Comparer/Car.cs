using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._8.Comparer
{
    abstract class Car : IVehicle
    {
        public string Model { get; set; }
        public int Fuel { get; set; }
        public int MaxFuelCapacity { get; set; }  

        public Car(string model, int maxFuelCapacity, int fuel)
        {
            Model = model;
            MaxFuelCapacity = maxFuelCapacity;
            Fuel = fuel;        
        }

        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine($"Automobilis {Model} vaziuoja.");
                Fuel = Fuel - 10;
            }
            else
            {
                Console.WriteLine($"Automobilis {Model} negali vaziuoti, nes trūksta degalų.");
            }
        }

        public void Refuel(int amount)
        {
            if (amount >= 0)
            {
                if (Fuel + amount <= MaxFuelCapacity)
                {
                    Fuel += amount;
                    Console.WriteLine($"Automobilis {Model} sekmingai papildytas {amount} litrais degalų.");
                }
                else
                {
                    Console.WriteLine($"Automobilio {Model} degalų bakas negali tilpti tiek degalų.");
                }
            }
            else
            {
                Console.WriteLine("Negalima papildyti neigiamu degalų kiekiu.");
            }
        }        
    }
}
