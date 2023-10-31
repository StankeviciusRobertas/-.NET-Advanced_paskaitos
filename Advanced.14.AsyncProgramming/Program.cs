using System.Diagnostics;
using System.Security.AccessControl;

namespace Advanced._14.AsyncProgramming
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello, Async!");
            ////DaromeSunkuDarba().GetAwaiter().GetResult(); // Taip rasome, jeigu Mainas metodas nepakeistas i async Task

            //Task darbas = DaromeSunkuDarba();
            //while (true)
            //{
            //    Console.Write(".");
            //    if (darbas.IsCompleted)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("Sunkus darbas baigtas visiskai baigtas");
            //        break;
            //    }
            //    Thread.Sleep(500);
            //}

            //Console.WriteLine("=============================");

            //DaromeSunkuDarba_SuKlaida(); // nesulauksime klaidos, nes tai yra void metodas

            //Console.WriteLine("=============================");

            //var fileService = new FilesService();
            //Task<string> contentTask = fileService.ReadTextFromFileAsync();
            
            //while (true)
            //{
            //    Console.Write("*");                
            //    Thread.Sleep(500);
            //    if (contentTask.IsCompleted)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine(contentTask.Result);

            Console.WriteLine("=============================");
            // Baras

            Bar bar = new Bar();
            Stopwatch sw;

            sw = Stopwatch.StartNew();
            await bar.Kitchen.PrepareAsyncImitacija(new List<Meal> 
                {
                new Tea(),
                    new FryedEggs(2),
                    new Toast(slices: 2, jam: EJamType.Melynes)
            });
            sw.Stop();
            Console.WriteLine($"PrepareAsyncImitacija uztruko {sw.Elapsed.TotalSeconds} ms");

            Console.WriteLine();
            Console.WriteLine();

            sw = Stopwatch.StartNew();
            await bar.Kitchen.Prepare(new List<Meal>
                {
                new Tea(),
                    new FryedEggs(2),
                    new Toast(slices: 2, jam: EJamType.Melynes)
            });
            sw.Stop();
            Console.WriteLine($"Prepare uztruko {sw.Elapsed.TotalSeconds} ms");

            Console.WriteLine("=============================");
        }

        public static async Task DaromeSunkuDarba() // Prie async visda turi buti Task
        {
            //Thread.Sleep(5000);
            await Task.Delay(5000);
            Console.WriteLine("Sunkus darbas baigtas");
        }

        public static async void DaromeSunkuDarba_SuKlaida()
        {
            await Task.Delay(5000);
            Console.WriteLine("Sunkus darbas baigtas");
            var a = int.Parse("aaaaaaaaaaaaa");
        }
    }
}