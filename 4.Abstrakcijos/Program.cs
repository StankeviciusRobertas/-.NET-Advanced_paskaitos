namespace _4.Abstrakcijos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var suo = new Suo("Rocky", 16);
            var kate = new Kate("Rainius", 9);
            var suo1 = new Suo("Cucekas", 16);
            var kate1 = new Kate("Tomas", 9);
            var suo2 = new Suo("Amsius", 16);
            var kate2 = new Kate("Miauksius", 9);

            List<Gyvunas> gyvunai = new List<Gyvunas>();

            gyvunai.Add(suo);
            gyvunai.Add(suo1);
            gyvunai.Add(suo2);

            gyvunai.Add(kate);
            gyvunai.Add(kate1);
            gyvunai.Add(kate2);

            foreach (var gyvunas in gyvunai)
            {
                gyvunas.ParasykVarda();
                gyvunas.Kalbek();
                Console.WriteLine("=========================");
            }

        }
    }
}