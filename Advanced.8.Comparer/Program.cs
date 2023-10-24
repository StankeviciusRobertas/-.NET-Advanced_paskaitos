namespace Advanced._8.Comparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Student> students = new List<Student>()
            //{
            //    new Student {
            //        Id = 1,
            //        Name = "Robertas",
            //        Year = 1999,
            //    },
            //    new Student {
            //        Id = 2,
            //        Name = "Jonas",
            //        Year = 2009,
            //    },
            //    new Student {
            //        Id = 3,
            //        Name = "Antanas",
            //        Year = 1968,
            //    },
            //};

            //foreach (Student student in students)
            //{
            //    Console.WriteLine(student.Name);
            //}
            //Console.WriteLine();
            //Console.WriteLine("======================================");
            //Console.WriteLine();
            //students.Sort(new StudentComparer());
            //foreach (Student student in students)
            //{
            //    Console.WriteLine(student.Name);
            //}

            Console.WriteLine("======================================");

            //var bmw = new BmwCar(true, "Bmw", 50);
            List<BmwCar> bmw = new List<BmwCar>()
            {
                new BmwCar(true, "MDrive", 80, 40),                        
                new BmwCar(true, "XDrive", 50, 10),
                new BmwCar(false, "FullDrive", 30, 20)
            };

            foreach(BmwCar bmwCar in bmw)
            {
                Console.WriteLine(bmwCar.Fuel);
            }
            
            Console.WriteLine("Sorted Cars by fuel");
            Console.WriteLine();
            bmw.Sort(new BmwCarComparer());
            foreach(BmwCar bmwCar in bmw)
            {
                Console.WriteLine(bmwCar.Fuel);
            }
            //var audi = new AudiCar(true, "Audi", 50);

            //bmw.Drive();
            //bmw.Refuel(30);
            //bmw.Drive();

            //audi.Drive();
            //audi.Refuel(100);
            //audi.Drive();
            //audi.Refuel(15);
            //audi.Drive();

        }
    }
}