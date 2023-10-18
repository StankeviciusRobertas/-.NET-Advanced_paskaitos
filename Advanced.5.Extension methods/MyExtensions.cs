using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._5.Extension_methods
{
    public static class MyExtensions
    {
        public static int WordCount(this string str) // Sveiki, kaip gyvenate?
        {
            //"Sveiki", "kaip", "gyvenate";
            var wordsArray = str.Split(new char[] { ' ', '.', '?', ',', ':' }, StringSplitOptions.RemoveEmptyEntries);
            return wordsArray.Length;
        }

        public static int WordCount(this string str, char[] seperators) 
        {
            //"Sveiki", "kaip", "gyvenate";
            var wordsArray = str.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            return wordsArray.Length;
        }

        public static bool IsNegative(this int integer)
        {
            return integer < 0;
        }

        public static bool IsAdult(this Employee employee)
        {
            return employee.Age > 18;
        }
    }
}
