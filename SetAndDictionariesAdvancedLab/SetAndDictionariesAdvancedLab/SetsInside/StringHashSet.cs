using System;
using System.Collections.Generic;
using System.Text;

namespace SetsInside
{
    class SetElement
    {
        public List<string> Keys { get; set; }
    }
    public class StringHashSet
    {
        private SetElement[] array;
        public StringHashSet(int capacity = 8)
        {
            array = new SetElement[capacity];
        }

        public void Add(string key)
        {
            int index = HashFunction(key);

            if (array[index] != null)
            {
                array[index].Keys.Add(key);
            }
            else
            {
                array[index] = new SetElement() { Keys = new List<string>() {key} };
            }
            
        }

        private int HashFunction(string key)
        {
            UInt64 hashedValue = 3074457345618258791ul;
            for (int i = 0; i < key.Length; i++)
            {
                hashedValue += key[i];
                hashedValue *= 3074457345618258799ul;
            }

            UInt64 count = (UInt64)array.Length;
            return (int)(hashedValue % count);


            //return Math.Abs(key.GetHashCode() % array.Length);


            //int asciiResult = 0;

            //for (int i = 0; i < key.Length; i++)
            //{
            //    asciiResult += key[i];
            //}
            //return asciiResult % array.Length;
        }

        public bool Contains(string key)
        {
            int index = HashFunction(key);

            if (array[index] != null)
            {
                for (int i = 0; i < array[index].Keys.Count; i++)
                {
                    if (array[index].Keys[i] == key)
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }
    }
}    
