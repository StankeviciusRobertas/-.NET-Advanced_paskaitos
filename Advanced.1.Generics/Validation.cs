using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._1.Generics
{
    internal class Validation<T>
    {
        public static void Validate<T>(T parameter)
        {
            if(parameter == null)
            {                
                throw new ArgumentNullException("Paduotas null, nevalidus argumentas");
            }
        }
    }
}
