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

            var bmw = new BmwCar(true, "Bmw", 50);
            var audi = new AudiCar(true, "Audi", 50);

            bmw.Drive();
            bmw.Refuel(30);
            bmw.Drive();

            audi.Drive();
            audi.Refuel(100);
            audi.Drive();
            audi.Refuel(15);
            audi.Drive();
                                  
         }
    }
}