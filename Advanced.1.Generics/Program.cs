namespace Advanced._1.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ShowItem<string>("vienas");
            //ShowItem<int>(1);
            //ShowItem<Human>(new Human("Robertas", "Stankevicius"));

            //var myInteger = 5;
            //var myString = "five";
            //var myHuman = new Human("Robertas", "Stankevicius");
            //Console.WriteLine(GetTypeName<int>(myInteger));
            //Console.WriteLine(GetTypeName<string>(myString));
            //Console.WriteLine(GetTypeName<Human>(myHuman));

            //Console.WriteLine(myInteger.GetType().Name);
            //Console.WriteLine(myString.GetType().Name);
            //Console.WriteLine(myHuman.GetType().Name);

            var mySelfMadeList = new MySelfMadeList<int>();
            for (int i = 0; i < 1000; i++)
            {
                mySelfMadeList.AddElement(i);
            }
            mySelfMadeList.PrintElement();
            mySelfMadeList.DeleteElement(100);
            Console.WriteLine("Deleted element");
            mySelfMadeList.PrintElement();

            //Validation<string> valid = new Validation<string>();
            //valid.Validate<string>("normalus stringas");
            //valid.Validate<string>(null);

            //Validation<string>.Validate<string>(null);

            //ShowTwoItems<string, int>("hello world!", 2);

        }

        public static void ShowTwoItems<T1, T2>(T1 item1, T2 item2)
        {
            Console.WriteLine($"Item 1: {item1}, item 2: {item2}");
        }

        public static void ShowItem<T>(T item)
        {
            Console.WriteLine($"Item: {item}");
        }

        public static string GetTypeName<T>(T input)
        {
            return input.GetType().Name;
        }          
    }
}