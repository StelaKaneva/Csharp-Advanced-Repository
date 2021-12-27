using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class CustomList<T>
    {
        private T[] array;
        private int index = 0;

        public CustomList()
        {
            array = new T[8];
        }

        public IEnumerator<T> GetEnumerator()
        {
            Console.WriteLine("Starting");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine("In the yield method");
                yield return array[i];
            }
        }
        public void Add(T element)
        {
            array[index] = element;
            index++;
        }
    }
}
