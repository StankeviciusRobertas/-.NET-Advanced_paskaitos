using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._5.Extension_methods
{
    public static class ExtensionExercises
    {
        public static bool IsPositive(this int integer)
        {
            return integer > 0;
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsBigger(this int number, int number2)
        {
            return number < number2;
        }

        public static bool IsSpaces(this string text)
        {
            return text.Contains(" ");
        }

        public static string CreateEmail(this string fullname, string yearOfBirth, string domain)
        {
            string nameWithoutSpaces = fullname.Replace(" ", "");
            return nameWithoutSpaces + yearOfBirth + domain;
        }

        public static T FindAndReturnIfEqual<T>(this List<T> list, T item)
        {           
            
                if (list.Contains(item))
                {
                    return item;
                }
            else
            {
                Console.WriteLine($"Elementas {item} nerastas sarase");
                return default;
            }          
        }        
    }
}
