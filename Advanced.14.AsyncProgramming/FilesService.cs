using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._14.AsyncProgramming
{
    public class FilesService
    {
        const string path = "csharp.txt";

        public async Task<string> ReadTextFromFileAsync()
        {
            try
            {
                await Task.Delay(5000);
                var content = await File.ReadAllTextAsync(path);
                return content;
            }
            catch (Exception)
            {
                return "Failas nenuskaitytas";
            }            
        }
    }
}
