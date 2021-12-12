using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{
    public class Box<T> where T: IComparable
    {
        public List<T> Values { get; set; } = new List<T>();

        public Box(List<T> values)
        {
            this.Values = values;
        }

        public int CountOfGreaterValues(T value, List<T> values)
        {
            int counter = 0;

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].CompareTo(value) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }

    }    
}
