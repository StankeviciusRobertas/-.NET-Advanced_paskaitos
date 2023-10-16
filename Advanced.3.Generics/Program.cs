namespace Advanced._3.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> skaiciai = new List<int> { 1, 2, 3, 4, 5 };

            //// Sukuriamas read-only sąrašas su generic tipo int.
            //ReadOnlyList<int> readOnlySarasas = new ReadOnlyList<int>(skaiciai);

            //// Gauti read-only sąrašo kopiją ir atspausdinti jo turinį.
            //IReadOnlyList<int> readOnlyKopija = readOnlySarasas.GautiReadOnlySarasa();

            //readOnlySarasas.PrintList();

            //int[] masyvas = readOnlySarasas.ListToArray();
            //Console.WriteLine("Sarasas konvertuotas i masyva: ");

            //foreach (var element in masyvas)
            //{
            //    Console.WriteLine($"{element}");
            //}
            //Console.WriteLine();

            //int oneElement = readOnlySarasas.FindElement(3);
            //Console.WriteLine($"Surastas vienas elementas: {oneElement}");

            //int searchedElement = readOnlySarasas.FindElementOrDefault(6);
            //Console.WriteLine($"Surastas elementas arba default: {searchedElement}");

            //bool isElement = readOnlySarasas.ArYraElementas(4);
            //Console.WriteLine($"Ar yra elementas 4 sarase {isElement}");

            //try
            //{
            //    skaiciai.Add(6);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Klaida: {ex.Message}");
            //}
        }
    }
}