namespace _3.InheritanceAndVirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("=================================================");

            //Square square = new Square(3.5);
            //Console.WriteLine($"Kvadratas turi {square.NumberOfAngles} kampus");
            //Console.WriteLine($"Kvadrato krastines ilgis = {square.Size}");

            //Console.WriteLine($"Kvadrato perimetras {square.GetPerimeter()}");

            //Entity entity = new Entity();
            //Human human = new Human();
            //Employee employee = new Employee();

            //// entity turi tik Id nes yra tevine klase ir pati is nieko nepaveldi
            //entity.Id = 1;

            //// human tures savo properciu + tai ka turi Entity
            //human.Name = "Robertas";
            //human.Surname = "Stankevicius";
            //human.Birthday = DateTime.Now;
            //human.Id = 2;

            //// employee tres savo propercius + tai ka turi Human + tai ka turi Entity
            //employee.Salary = 1000;
            //employee.EmploymentDate = DateTime.Now;
            //employee.Name = "Vardenis";
            //employee.Surname = "Pavardenis";
            //employee.Birthday = new DateTime(2000, 01, 01);
            //employee.Id = 3;

            //Console.WriteLine("=================================================");

            //Car car = new Car();
            //car.Speed = 90;
            //Console.WriteLine($"Automobilio greitis: {car.Speed}");
            //Bike bike = new Bike();
            //bike.Speed = 50;
            //Console.WriteLine($"Motociklo greitis: {bike.Speed}");

            //Console.WriteLine("=================================================");

            Manager manager = new Manager();
            Employe employe = new Employe();

            manager.Name = "Robertas";
            manager.Salary = 500;

            employe.Name = "Jurgis";
            employe.Salary = 100;
            manager.Employes = 2;         

            Console.WriteLine($"Vadovas: {manager.Name}, atlyginimas {manager.Salary}, darbuotoju skaicius: {manager.Employes}");      

            //Console.WriteLine("=================================================");

            //Transport transport = new Transport();
            //Console.WriteLine($"Transporto greitis: {transport.MeasuredSpeed()}");

            //TransportCar transportCar = new TransportCar();
            //Console.WriteLine($"Transporto automobilio greitis: {transportCar.MeasuredSpeed()}");

            Console.WriteLine("=================================================");
        }
    }
}