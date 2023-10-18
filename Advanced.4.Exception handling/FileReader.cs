using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._4.Exception_handling
{
    internal class FileReader
    {
        private string filePath;

        public FileReader(string filePath)
        {
            this.filePath = filePath;
        }

        public void ReadFile()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unepxtected error: {ex.Message}");
            }
        }
    }
}
