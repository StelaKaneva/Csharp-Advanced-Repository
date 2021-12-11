using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsConstraints
{
    public class GenericList<T> where T : IComparable<T>
    {
        private T[] array;

        public T GetMax()
        {
            T min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (min.CompareTo(array[i]) < 0)
                {
                    min = array[i];
                }
            }

            return min;
        }
    }
}
