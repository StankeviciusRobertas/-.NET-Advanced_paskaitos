namespace _1.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowItem<string>("vienas");
            ShowItem<int>(1);
        }

        public static void ShowItem<T>(T item)
        {
            Console.WriteLine($"Item: {item}");
        }
    }
}