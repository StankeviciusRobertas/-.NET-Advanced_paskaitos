namespace Advanced._8.InterfaceUzduotys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Bass bass = new Bass();
            Carp carp = new Carp();

            List<IAnimal> list = new List<IAnimal>();
            list.Add(dog);
            list.Add(cat);
            list.Add(bass);
            list.Add(carp);
            dog.Name = "Dogas";          
            cat.Name = "Dziule";           
            bass.Name = "Basas";           
            carp.Name = "karpis";            

            list.ForEach(animal => animal.Eat());


            List<IMammal> list2 = new List<IMammal>();
            list2.Add(dog);
            list2.Add(cat);            

            list2.ForEach(animal => animal.GiveBirth());

            List<IFish> list3 = new List<IFish>();            
            list3.Add(bass);
            list3.Add(carp);

            list3.ForEach(animal => animal.Swim());

            var sortedList = list.OrderBy(animal => animal.Name).ToList();
            Console.WriteLine("Surusiuotas sarasas: ");
            foreach(var animal in list)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}