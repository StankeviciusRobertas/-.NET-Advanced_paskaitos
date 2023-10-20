namespace Advanced._7.Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("=================================================");

            //Func<int, int> multiplyByFive = (num) => num * 5;

            //int result = multiplyByFive(7);
            //Console.WriteLine(result);

            //Console.WriteLine("=================================================");

            //Func<int, int, int> multiply = (num1, num2) => num1 * num2;
            //Console.WriteLine(multiply(3, 7));

            //Console.WriteLine("=================================================");

            //Func<bool, string, DateTime, decimal> differentParamaterTypesFunc = (arg1, arg2, arg3) => 1.78m;

            //Console.WriteLine(differentParamaterTypesFunc(false, "Stringas", DateTime.Now));

            //Console.WriteLine("=================================================");

            //Func<string> funcWithoutParameters = () => "returning from func without parameters";            
            //Console.WriteLine(funcWithoutParameters());

            //Console.WriteLine("=================================================");

            //Func<int, bool> isIntegerHigherThanTen = (number) => number > 10;
            //int numberToCheck = 11;
            //if(isIntegerHigherThanTen(numberToCheck))
            //{
            //    Console.WriteLine($"Skaicius didesnis nei 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Skaicius nediesnis nei 10");
            //}

            //Console.WriteLine("=================================================");

            ////Ternerio salyga, if yra ?, else yra :
            //Func<int, int, int> filterNumber = (number1, number2) => number1 > number2 ? number1 : number2;

            //Console.WriteLine(filterNumber(5, 10));

            //Console.WriteLine("=================================================");

            ////Func<string, string> selector = (str) => str.ToUpper();
            //string[] words = new string[] { "orange", "apple", "Article", "elephant" };

            ////List<string> upperWords = new List<string>();
            ////foreach (string word in words)
            ////{
            ////    upperWords.Add(selector(word));
            ////}

            //var upperWordsWithLinq = words.Select((str) => str.ToUpper()); // Func<string, string>
            //var wordsLengths = words.Select(word => word.Length);           // Func<string, int>
            //var areWordsLongerThan5 = words.Select(word => word.Length > 5);// Func<string, bool>, grazina visoms reiksmes ar tai true ar false

            //var wordsLongerThan5 = words.Where(str => str.Length > 5);      //filtras, grazinta tik atitinkancias reiksmes

            //var orderedWords = words.OrderBy(word => word);                 //surikiuoja pagal abecele
            //var orderedWordsByLength = words.OrderBy(words => words.Length); // surikiuoja pagal zodzio ilgi

            //var singleOrDefaultWordWith8Symbols = words.SingleOrDefault(word => word.Length == 8); //grazina viena elementa jeigu atitinka salyga, jeigu daugiau, nei vienas atitinka salyga gaunam exceptiona,jeigu neranda ne vieno gaunam null
            //var singleWordWith8Symbols = words.Single(word => word.Length == 8); // tas pats kas SingleOrDefault, bet bus klaida jei nerado tokio ilgio zodzio.
            //var wordsCount = words.Count(); // grazina kiek zodziu yra
            //var wordsCountLongerThan5 = words.Count(word => word.Length > 5); // grazina zodziu kieki, pagal salyga

            //words.ToList().ForEach(word => Console.WriteLine(word)); //ForEach veikia tik Listams taigi masyva paverciame i List<string> su ToList() metodu, ir ForEach yra void


            Console.WriteLine("=================================================");

            //List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var intSquare = ints.Select(integer => integer * integer);
            //List<int> ints2 = new List<int> { 1, -2, 3, -4, 5, -6, 7, 8, -9, 10 };
            //var intPositive = ints2.Where(positiveInt => positiveInt > 0);

            //List<int> ints3 = new List<int> { 1, -2, 3, -4, 55, -6, 27, 8, -9, 10 };
            //var intPositiveAndBiggerWhen10 = ints3.Where(positiveInt => positiveInt > 0 && positiveInt < 10);

            //var intToBigest = ints3.OrderBy(toBigestInt => toBigestInt);
            //var intToSmallest = ints3.OrderByDescending(toSmallest => toSmallest);

            //var biggestInt = ints3.Max();
            //Console.WriteLine(biggestInt);

            //Console.WriteLine("=================================================");

            //List<Person> people = new List<Person>();
            //people.Add(new Person("Robertas", 33));
            //people.Add(new Person("Petras", 15));
            //people.Add(new Person("Povilas", 22));
            //people.Add(new Person("Arturas", 44));
            //people.Add(new Person("Vaclovas", 65));
            //people.Add(new Person("Kestas", 28));            

            //var onlyNames = people.Select(name => name.Name);
            //onlyNames.ToList().ForEach(name => Console.WriteLine(name));
            //var onlyAge = people.Select(age => age.Age);
            //onlyAge.ToList().ForEach(age => Console.WriteLine(age));

            //var sortAgeToSmallest = people.OrderByDescending(age => age.Age);
            //foreach(var person in sortAgeToSmallest)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}

            //var createNamesAletter = people.Where(name => name.Name.StartsWith("A"));
            //foreach(var person in createNamesAletter)
            //{
            //    Console.WriteLine(person.Name);
            //}

            //var createAbove40 = people.Where(person => person.Age > 40).OrderBy(person => person.Name).ToList();
            //Console.WriteLine("Spausdinam nuo 40 metu, ir isrikiuotais vardais");
            //foreach(var age in createAbove40)
            //{
            //    Console.WriteLine($"Name: {age.Name}, Age {age.Age}");
            //}

            Console.WriteLine("=================================================");

            var person1 = new Person("Petras", 25)
            { 
                Pets = new List<Pet>

                {
                    new Pet { PetName = "Suo"},
                    new Pet { PetName = "Kate"},
                }
            };

            var person2 = new Person("Jonas", 25)
            {                
                Pets = new List<Pet>

                {
                    new Pet { PetName = "Sunis"},
                    new Pet { PetName = "Katinas"},
                    new Pet { PetName = "Papuga"},
                }
            };

            var person3 = new Person("Juozas", 25)
            {                
                Pets = new List<Pet>

                {
                    new Pet { PetName = "Smauglys"},
                }
            };

            var personsList = new List<Person> { person1, person2, person3 };
            var personsPets = personsList.SelectMany(person => person.Pets).ToList();


            Console.WriteLine("=================================================");
        }
    }
}