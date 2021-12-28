using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ListyIterator
{
    public class ListyIterator<T>
    {
        private int currentIndex;
        private List<T> items;

        public ListyIterator(List<T> initialItems)
        {
            this.currentIndex = 0;
            this.items = initialItems;
        }

        public int Count => this.items.Count;

        public bool Move()
        {
            if (this.HasNext())
            {
                this.currentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.currentIndex < this.Count - 1)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.items[this.currentIndex]);
        }
    }
}
