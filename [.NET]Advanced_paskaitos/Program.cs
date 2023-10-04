namespace _.NET_Advanced_paskaitos
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Car myCar = new Car();
            //myCar.Brand = "Lexus";
            //myCar.Doors = 5;
            //myCar.MaxSpeed = 220;
            //myCar.CreationDate = new DateTime(2007, 12, 1);

            //Console.WriteLine($"Automobilio gamintojas: {myCar.Brand}");
            //Console.WriteLine($"Duru skaicius: {myCar.Doors}");
            //Console.WriteLine($"Maksimalus greitis: {myCar.MaxSpeed}");
            //Console.WriteLine($"Pagaminimo data: {myCar.CreationDate}");
            //Console.WriteLine("=================================================");

            //Car emptyCar = new Car();
            //Console.WriteLine($"Automobilio gamintojas: {emptyCar.Brand}");
            //Console.WriteLine($"Duru skaicius: {emptyCar.Doors}");
            //Console.WriteLine($"Maksimalus greitis: {emptyCar.MaxSpeed}");
            //Console.WriteLine($"Pagaminimo data: {emptyCar.CreationDate}");
            //Console.WriteLine("=================================================");

            //Car carWithBrand = new Car("BMW"); //Galima ir Console.ReadLine();
            //Console.WriteLine($"Automobilio gamintojas: {carWithBrand.Brand}");
            //Console.WriteLine($"Duru skaicius: {carWithBrand.Doors}");            
            //Console.WriteLine($"Pagaminimo data: {carWithBrand.CreationDate}");
            //Console.WriteLine("=================================================");

            //Person newPerson = new Person();
            //Person newPerson1 = new Person(1.80);
            //Console.WriteLine($"Vardas: {newPerson1.Name}, Amzius: {newPerson1.Age} Ugis: {newPerson1.Height} m.");
            //Console.WriteLine($"Ugis: {newPerson1.Height} m.");
            //Console.WriteLine("=================================================");
            //School school = new School();
            //Console.WriteLine($"Pavadinimas: {school.Name}, Mieste: {school.City}, Mokiniu skaicius: {school.Student}");
            //Console.WriteLine("=================================================");

            //Book book = new Book("Lietuva");
            //Console.WriteLine($"Knyga pavadinimas: {book.Name}, Autorius: {book.Author}, Isleidimo metai: {book.Date}, Isleidimo salis: {book.RealeseCountry}");

            //Console.WriteLine("=================================================");
            Console.WriteLine("=================================================");

            Car carWithBrand = new Car("BMW")
            {
                Doors = 5,
                    Engine = new Engine()
                    {
                        Name = "V8",
                        Description = "V8 engine",
                        ReleaseDate = DateTime.Now,
                    },
                    Wheels = new List<Wheel>
                    {
                        new Wheel()
                        {
                            Brand = "Continental",
                            Size = "R15"
                        },
                        new Wheel()
                        {
                            Brand = "Continental",
                            Size = "R15"
                        },
                        new Wheel()
                        {
                            Brand = "Continental",
                            Size = "R15"
                        },
                        new Wheel()
                        {
                            Brand = "Continental",
                            Size = "R15"
                        }
                    }
            };
            Console.WriteLine($"Automobilio gamintojas: {carWithBrand.Brand}");
            Console.WriteLine($"Duru skaicius: {carWithBrand.Doors}");            
            Console.WriteLine($"Pagaminimo data: {carWithBrand.CreationDate}");
            Console.WriteLine($"Variklio pavadinimas: {carWithBrand.Engine}");
            Console.WriteLine($"Variklio aprasymas: {carWithBrand.Description}");
            Console.WriteLine($"Variklio data: {carWithBrand.Engine.ReleaseDate}");
            foreach(var wheel in carWithBrand.Wheels)
            {
                Console.WriteLine($"Ratas {wheel.Brand} ir jo dydis {wheel.Size}");
            }
            carWithBrand.Engine.isRunning = true;
            EngineStatus(carWithBrand);
            Console.WriteLine("=================================================");

            //Book book = new Book("Lietuva");
            //List<string> books = new List<string>
            //{ "Karalyste Robertas St", "Sventaragio tvirtove", "Trys karaliai",
            //"Zebras ir bebras", "Jonukas ir grytute Robertas St", "Pokerio karaliai", ".Net programavimo kalba Robertas St"};
            //string author = book.Author;
            //List<string> result = BookList(books, author);

            //Console.WriteLine($"Knygos is autoriaus {author}");
            //foreach (string knyga in result)
            //{
            //    Console.WriteLine(knyga);
            //}

            //Console.WriteLine("=================================================");
        }
        
        public static void EngineStatus(Car car)
        {
            if (car.Engine.isRunning)
            {
                Console.WriteLine("Engine turn ON");
            }
            else
            {
                Console.WriteLine("Engine turn OFF");
            }
        }
        public static List<string> BookList(List<string> books, string author)
        {
            List<string> authorBooks = new List<string>();

            foreach (string book in books)
            {
                if (book.EndsWith(author))
                {
                    authorBooks.Add(book);
                }                
            }
            return authorBooks;
        }

    }
}