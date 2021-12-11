using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClasses
{
    public class GenericList<T>
    {
        private T[] internalArray;
        private int index = 0;

        public GenericList()
        {
            internalArray = new T[8];
        }

        public void Add(T element)
        {
            internalArray[index] = element;
            index++;
        }
    }
}
