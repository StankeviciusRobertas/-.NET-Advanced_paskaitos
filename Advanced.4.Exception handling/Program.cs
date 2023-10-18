using System.Linq.Expressions;
using System.Threading.Tasks.Dataflow;

namespace Advanced._4.Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("=================================================");
            //try
            //{
            //    int skaicius = 0;
            //    int result = 10 / skaicius;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"Dalyba is nulio negalima {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("Baigta");
            //}

            //try
            //{
            //    int[] skaicia = { 2, 5, 6, 100, 50, 20, 59, 69 };

            //    Console.WriteLine(skaicia[4]);

            //    Console.WriteLine(skaicia[50]);
            //}
            //catch ( IndexOutOfRangeException e )
            //{
            //    Console.WriteLine($"exception: {e.Message}");
            //}

            //Console.WriteLine("=================================================");

            //try
            //{
            //    ValidateAge(15);
            //    ValidateAge(-10);
            //}
            //catch (InvalidAgeException ex)
            //{
            //    Console.WriteLine("Exception: " + ex.Message);
            //}

            //static void ValidateAge(int age)
            //{
            //    if (age < 0)
            //    {
            //        throw new InvalidAgeException("Amzius negali buti mazesnis uz 0");
            //    }
            //}

            //Console.WriteLine("=================================================");


            //string input = "neleistinasString"; // Pakeiskite į norimą string reikšmę

            //try
            //{
            //    double result = System.Convert.ToDouble(input);
            //    Console.WriteLine($"Konvertavimas pavyko: {result}");
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine($"Klaida: Nepavyko konvertuoti į double. Klaidos pranešimas: {e.Message}");
            //}
            //catch (OverflowException e)
            //{
            //    Console.WriteLine($"Klaida: Per didelis arba per mažas skaičius. Klaidos pranešimas: {e.Message}");
            //}
            //catch (InvalidCastException e)
            //{
            //    Console.WriteLine($"Cast klaida: {e.Message}");
            //}

            //Console.WriteLine("=================================================");

            //int[] arr = { 1, 2, 3, 4, 5, 6 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //try
            //{
            //     Console.WriteLine(arr[7]);
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine($"Isejote uz masyvo ribu // Technine klaida: {e.Message}");
            //}

            //Console.WriteLine("=================================================");

            //int[] arr = { 19, 0, 75, 52 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    try
            //    {
            //        Console.WriteLine(arr[i] / arr[i + 1]);
            //    }
            //    catch (IndexOutOfRangeException e)
            //    {
            //        Console.WriteLine("Isejote uz masyvo ribu");
            //    }
            //    catch (DivideByZeroException e)
            //    {
            //        Console.WriteLine("Dalyba is 0 negalima");
            //    }
            //}

            Console.WriteLine("=================================================");

            string filePath = "C:\\Users\\rstak\\source\\Savarnkiskas darbas\\[.NET]Advanced_paskaitos\\Advanced.4.Exception handling\\bin\\Debug\\net6.0\\Tire.txt";
            FileReader fileReader = new FileReader(filePath);
            fileReader.ReadFile();

            Console.WriteLine("=================================================");

        }
    }
}