namespace Advanced._6.Delegatai
{
    internal class Program
    {
        private static readonly int GlobalNumber = 10;
        private delegate int NumberChanger(int n);
        private delegate string NameBuilder(string firstName, string lastName, int age);
        private delegate int TwoNumbers(int number1, int number2);
        private delegate List<int> ElementSelect(List<int> numbers, int step);        

        static void Main(string[] args)
        {
            //Console.WriteLine("=================================================");

            //Console.WriteLine(AddNumber(5));
            //Console.WriteLine(SubstractNumber(6));

            //var numberChanger1 = new NumberChanger(AddNumber);
            //var numberChanger2 = new NumberChanger(SubstractNumber);

            //Console.WriteLine(numberChanger1(5));
            //Console.WriteLine(numberChanger2(6));

            //NumberChanger numberChanger;
            //Console.WriteLine("Ar jus norite prideti (+) ar atimti (-)");
            //string userSelection = Console.ReadLine();
            //if(userSelection == "+")
            //{
            //    numberChanger = new NumberChanger(AddNumber);
            //}
            //else
            //{
            //    numberChanger = new NumberChanger(SubstractNumber);
            //}

            //Console.WriteLine(numberChanger(5));

            //Console.WriteLine("=================================================");

            //var nameBuilder = new NameBuilder(CreateName);
            //Console.WriteLine(nameBuilder("Robertas", "Stankevicius", 33));

            //Console.WriteLine("=================================================");

            //var createNumber = new TwoNumbers(CreateTwoNumbers);
            //Console.WriteLine(createNumber(5, 10));

            //Console.WriteLine("=================================================");

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            //ElementSelect elementSelector = ReturnInts;

            //List<int> selectedElement = elementSelector(numbers, 2);

            //Console.WriteLine("selected element: ");
            //foreach (int element in selectedElement)
            //{
            //    Console.WriteLine(element);
            //}

            Console.WriteLine("=================================================");
        }

        public static List<int> ReturnInts(List<int> list, int step)
        {
            List<int> selectedElements = new List<int>();

            for (int i = step - 1; i < list.Count; i += step)
            {
                selectedElements.Add(list[i]);
            }
            return selectedElements;
        }
        public static int CreateTwoNumbers(int number, int number2)
        {
            return number + number2;
        }
        public static string CreateName(string name, string surname, int age)
        {
            return name + " " + surname + " " + age;
        }
        public static int AddNumber(int number)
        {
            return GlobalNumber + number;
        }

        public static int SubstractNumber(int number)
        {
            return GlobalNumber - number;
        }
    }
}