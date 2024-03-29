﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(params int[] stones)
        {
            this.stones = stones.ToList();
        }

        public IEnumerator<int> GetEnumerator()
        {
            int count = this.stones.Count;

            for (int i = 0; i < count; i+=2)
            {
                yield return this.stones[i];
            }

            //count 8, last index 7
            //count 9, last index 8

            int lastOddIndex = count - 1;

            if (lastOddIndex % 2 == 0)
            {
                lastOddIndex--;
            }

            for (int i = lastOddIndex; i >= 0; i-=2)
            {
                yield return this.stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
