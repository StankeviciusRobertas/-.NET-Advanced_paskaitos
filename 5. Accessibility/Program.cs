namespace _5._Accessibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Robertas", 29);
            Console.WriteLine(person.PrintInfoFull());

            Student student = new Student("Roberto", 31, "ADF232");
            Console.WriteLine($"{student.PrintInfoFull()} ir ID: {student.GetSudentId()} ");

            Teacher teacher = new Teacher("Antanas", 25, "Matematika");
            Console.WriteLine(teacher.GetSubject());
        }
    }
}