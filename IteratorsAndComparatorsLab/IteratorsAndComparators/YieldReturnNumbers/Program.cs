using System;
using System.Collections;
using System.Collections.Generic;

namespace YieldReturnNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //IEnumerator<int> enumerator = GetNums().GetEnumerator();
            IEnumerator<int> enumerator = new GetNumsEnumerator();
            var result = 0;

            enumerator.MoveNext();

            result += enumerator.Current;
            enumerator.MoveNext();
            result += enumerator.Current;
            enumerator.MoveNext();
            result += enumerator.Current;
            Console.WriteLine(result);
        }

        public static IEnumerable<int> GetNums()
        {
            yield return 5;
            Console.WriteLine("After first return");
            yield return 8;
            yield return 9;
            
        }

        private class GetNumsEnumerator : IEnumerator<int>
        {
            private int index = -1;
            public int Current {
                get
                {
                    if (index == 0)
                    {
                        return 5;
                    }
                    if (index == 1)
                    {
                        Console.WriteLine("After first return");
                        return 8;
                    }
                    if (index == 2)
                    {
                        return 9;
                    }

                    return -1;
                } 
            }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                index++;
                if (index >= 3)
                {
                    return false;
                }

                return true;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
