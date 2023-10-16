using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._3.Generics
{
    internal class ReadOnlyList<T>
    {
        private readonly List<T> readOnlySarasas;

        // Konstruktorius priima sąrašą reikšmių ir jį naudoja norint inicializuoti read-only sąrašą.
        public ReadOnlyList(List<T> sarasas)
        {
            if (sarasas == null)
            {
                throw new ArgumentNullException(nameof(sarasas));
            }

            readOnlySarasas = new List<T>(sarasas);
        }

        public void PrintList()
        {
            Console.WriteLine("Sarasas: ");
            foreach (var element in readOnlySarasas)
            {
                Console.WriteLine($"{element}");
            }
            Console.WriteLine();
        }
        // Metodas, kuris leidžia gauti read-only sąrašo kopiją.
        public IEnumerable<T> GautiReadOnlySarasa()
        {
            return readOnlySarasas;
        }

        public T[] ListToArray()
        {
            return readOnlySarasas.ToArray();
        }

        public T FindElement(T element)
        {
            foreach (var el in readOnlySarasas)
            {
                if (el.Equals(element))
                {
                    return el;
                }
            }
            throw new InvalidOperationException("Rasta daugiau ar mažiau negu vienas atitikmuo sąraše.");
        }

        public T FindElementOrDefault(T element)
        {
            T foundElement = default(T);
            bool foundOnce = false;

            foreach (var el in readOnlySarasas)
            {
                if (el.Equals(element))
                {
                    if (foundOnce)
                    {
                        throw new InvalidOperationException("Rasta daugiau negu vienas atitikmuo sąraše.");
                    }
                    foundElement = el;
                    foundOnce = true;
                }
            }
            return foundElement;
        }

        public bool ArYraElementas(T element)
        {
            return readOnlySarasas.Contains(element);
        }
    }
}
