namespace _6.Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string content = File.ReadAllText("path.txt");
            //File.WriteAllText("anotherPath.txt", content);

            //Console.WriteLine("=================================================");

            //IEnumerable<string> contentLines = File.ReadLines("path.txt");
            //for(int i = 0;i < contentLines.Count(); i++)
            //{
            //    if (contentLines.ElementAt(i).Contains("Main"))
            //    {
            //        Console.WriteLine($"Main metodas prasideda eiluteje  { i + 1}");
            //        break;
            //    }
            //}

            //Console.WriteLine("=================================================");

            //File.WriteAllLines("anotherPathLines.txt", contentLines);

            //Console.WriteLine("=================================================");

            //DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();
            //using (var writer = new StreamWriter("CDriverDris.txt"))
            //{
            //    foreach (var dir in cDirs)
            //    {
            //        writer.WriteLine(dir.Name);
            //    }
            //}            

            //string line = "";
            //using (var reader = new StreamReader("CDriverDris.txt"))
            //{
            //    while(line != null)
            //    {
            //        line = reader.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //}

            //Console.WriteLine("=================================================");
            //string fileStreamLine = "";
            //using (var readFileStream = new FileStream("path.txt", FileMode.Open, FileAccess.Read, FileShare.Read))
            //{
            //}

            //Console.WriteLine("=================================================");
            ////1 uzduotis
            //string fileRead = File.ReadAllText("Insert.txt");
            //Console.WriteLine(fileRead);

            //Console.WriteLine("=================================================");

            //List<string> list = new List<string>();
            //list.Add("pirmas");
            //list.Add("antras");
            //list.Add("Vardas");
            //list.Add("Robertas");
            //list.Add("Koks cia tekstas");
            //list.Add("Viskas gerai");

            //File.WriteAllLines("newListFile.txt", list);

            //Console.WriteLine("=================================================");

            //bool boolTrue = true;
            //File.Copy("Insert.txt", "newListFile.txt", boolTrue);

            //Console.WriteLine("=================================================");

            //IEnumerable<string> fileLineRead = File.ReadLines("Insert.txt");
            //foreach(string line in fileLineRead)
            //{
            //    int symbols = line.Count();
            //    Console.WriteLine(symbols);
            //}

            //Console.WriteLine("=================================================");
            //List<string> list = new List<string>();
            //list.Add("pirmas@23");
            //list.Add("2312");
            //list.Add("@#$!@#");
            //list.Add("Robertas");
            //list.Add("Koks cia tekstas");
            //list.Add("!!!!!");

            //using (var writer = new StreamWriter("Insert.txt"))
            //{
            //    foreach(var name in list)
            //    {
            //        writer.WriteLine(name);
            //    }
            //}

            Console.WriteLine("=================================================");
            
            //using (BinaryWriter bw = new BinaryWriter(File.Open(
            //  @"C:\Users\rstak\source\Savarnkiskas darbas\[.NET]Advanced_paskaitos\6.Streams\bin\Debug\net6.0.binary.txt", FileMode.Create)))
            //{
            //    //writes the data to the stream
            //    bw.Write(25);
            //    bw.Write(23.98);
            //    bw.Write('c');
            //    bw.Write("GeeksForGeeks");
            //    bw.Write(true);
            //    Console.WriteLine("Successfully Written");
            //    Console.ReadLine();
            //}

            using (BinaryReader bw = new BinaryReader
                   (File.Open(@"C:\Users\rstak\source\Savarnkiskas darbas\[.NET]Advanced_paskaitos\6.Streams\bin\Debug\net6.0.binary.txt", FileMode.Open)))
            {
                //Reads the data to the stream
                Console.WriteLine("String value is " + bw.ReadInt32());
                Console.WriteLine("Double value is " + bw.ReadDouble());
                Console.WriteLine("Char value is " + bw.ReadChar());
                Console.WriteLine("value of string is " + bw.ReadString());
                Console.WriteLine("for boolean value is " + bw.ReadBoolean());
                Console.Read();

            }


            Console.WriteLine("=================================================");

        }
    }
}