﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03.Stack
{
    public class MyStack<T> : IEnumerable<T>
    {
        private List<T> items;

        public int Count => this.items.Count;

        public MyStack()
        {
            items = new List<T>();
        }

        public void Push(T item)
        {
            this.items.Add(item);
        }

        public T Pop()
        {
            T item = this.items[items.Count - 1];
            //T item = this.items[^1]; 
            this.items.RemoveAt(this.items.Count - 1);
            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.items.Count - 1; i >= 0; i--)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
