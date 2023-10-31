namespace Advanced._14.AsyncProgramming
{
    public abstract class Meal
    {
        public abstract string Title { get; }
        public virtual Task<Meal> Prepare()
        {
            throw new NotImplementedException();
        }
    }

    public class Tea : Meal
    {
        public override string Title => "Arbata";
        public override async Task<Meal> Prepare()
        {
            Console.WriteLine("+(arbata) Pilame vandeni i arbatinuka");
            await Task.Delay(1000);
            Console.WriteLine("+(arbata) Verdame vandeni");
            await Task.Delay(4000);
            Console.WriteLine("+(arbata) Vanduo uzvire");
            Console.WriteLine("+(arbata) Pripilame vandeni i puoduka");
            Console.WriteLine("+(arbata) Laukiame kol pritrauks arbata");
            await Task.Delay(3000);
            Console.WriteLine("Ding! arbata paruosta");

            return new Tea();
        }
    }

    public class FryedEggs : Meal
    {
        private int _eggsCount;
        public FryedEggs(int eggsCount)
        {
            _eggsCount = eggsCount;
        }

        public override string Title => "Kiausiniene";
        public override async Task<Meal> Prepare()
        {
            Console.WriteLine("+(Kiausiniene) Pridedame aliejaus");
            await Task.Delay(5000);
            Console.WriteLine($"+(Kiausiniene) Ikrauname {_eggsCount} kiausinius");
            Console.WriteLine("+(Kiausiniene) kepame kiausinius ...");
            await Task.Delay(2000);
            Console.WriteLine("+(Kiausiniene) dedam kiausiniene i lekste");
            
            Console.WriteLine("Ding! Kiausiniene paruosta");


            return new FryedEggs(_eggsCount);
        }
    }

    public class Toast : Meal
    {
        private int _slices;
        private EJamType _jam;

        public Toast(int slices, EJamType jam)
        {
            _slices = slices;
            _jam = jam;
        }
        public override string Title => "Tostas";
        public override async Task<Meal> Prepare()
        {
            await KeptiDuona();
            await TeptiSviesta();
            await TeptiUogiene();
            Console.WriteLine("DING! tostas su uogiene paruostas");
            return new Toast(_slices, _jam);
        }
        private async Task KeptiDuona()
        {
            for (int slice = 0; slice < _slices; slice++)
            {
                Console.WriteLine($"+(toste) dedam duona i tosteri");
                Console.WriteLine($"+(toste) pradeda kepti duona...");
                await Task.Delay(1000);
                Console.WriteLine($"+(toste) isimam duona is tosterio");
            }
        }

        private async Task TeptiSviesta()
        {
            Console.WriteLine("+++ Tepame sviesta");
            await Task.Delay(1000);
        }

        private async Task TeptiUogiene()
        {
            Console.WriteLine($"+++ Tepame {_jam} uogiene");
            await Task.Delay(1000);
        }
        
    }

    public enum EJamType
    { 
        Melynes,
        Braskes
    }
}