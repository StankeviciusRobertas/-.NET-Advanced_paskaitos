namespace Advanced._2.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("=================================================");

            //TwoGenericsParameters<int, string> manoKlase = new TwoGenericsParameters<int, string>(10, "Labas");

            //manoKlase.SpausdintiT1(); // Spausdins: T1 reikšmė: 10
            //manoKlase.SpausdintiT2(); // Spausdins: T2 reikšmė: Labas

            //manoKlase.PakeistiT1(20);
            //manoKlase.PakeistiT2("Pasauli");

            //manoKlase.SpausdintiT1(); // Spausdins: T1 reikšmė: 20
            //manoKlase.SpausdintiT2(); // Spausdins: T2 reikšmė: Pasauli

            //Console.WriteLine("=================================================");

            //FourSideGeometricFigure rectangle = new FourSideGeometricFigure("Rectnagle", 5.0, 10.0);
            //Generator<FourSideGeometricFigure> generator = new Generator<FourSideGeometricFigure>();

            //generator.Show(rectangle);

            //Console.WriteLine("=================================================");

            //TypeHolder<int, string> typeHolder = new TypeHolder<int, string>();

            //int exampleInt = 42;
            //string exampleString = "Hello, World!";

            //typeHolder.GetType(exampleInt);    // Type of input: System.Int32
            //typeHolder.GetType(exampleString); // Type of input: System.String

            Console.WriteLine("=================================================");

            SportoLyga<FootballTeam> futboloLyga = new SportoLyga<FootballTeam>();

            // Pridedam futbolo komandas.
            futboloLyga.AddTeam(new FootballTeam("FC Barcelona"));
            futboloLyga.AddTeam(new FootballTeam("Real Madrid"));

            // Atspausdinam futbolo komandas.
            futboloLyga.PrintTeam();

            try
            {
                // Bandom pridėti krepšinio komandą į futbolo lygą (turėtų mesti exception).
                futboloLyga.AddTeam(new FootballTeam("Los Angeles Lakers"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Klaida: {ex.Message}");
            }

            Console.WriteLine("=================================================");
        }
    }
}