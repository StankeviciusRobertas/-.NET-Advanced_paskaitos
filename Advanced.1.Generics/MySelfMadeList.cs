using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._1.Generics
{
    public class MySelfMadeList<T>
    {        
        private int index = 0;
        private int size = 10;

        public T[] MyArray { get; set; }

        public MySelfMadeList()
        {
            MyArray = new T[size];
        }

        public void PrintElement()
        {
            foreach(var item in MyArray)
            {
                Console.WriteLine(item);
            }
        }
        public void DeleteElement(T elementToDelete)
        {
            int foundIndex = Array.IndexOf(MyArray, elementToDelete);

            if (foundIndex != -1)
            {
                for(int i = foundIndex; i < index - 1; i++)
                {
                    MyArray[i] = MyArray[i + 1];
                }
                MyArray[index - 1] = default(T);
                index--;
            }
            else
            {
                Console.WriteLine("elementas nerastas");
            }
        }
        public void AddElement(T elementToAdd)
        {
            if (CheckIfFull())
            {
                MyArray = IncreaseListSize();
            }

            if (elementToAdd != null)
            {
                MyArray[index] = elementToAdd;
                index++;
            }
            else
            {
                throw new ArgumentNullException(nameof(elementToAdd));
            }
        }

        private bool CheckIfFull()
        {
            if (index == size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private T[] IncreaseListSize()
        {
            size += (size / 2);             //size = size +(size/2);
            var newArray = new T[size];     //tuscias 15 elementu masyvas (nes pradzioje buvo 10 elementu)
            MyArray.CopyTo(newArray, 0);    // perkopijuojame MyArray i sita nauja masyva
            return newArray;                // graziname kvietejui padidinta ir perkopijuota masyva
        }
    }
}
