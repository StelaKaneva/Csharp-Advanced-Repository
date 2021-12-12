using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class Threeuple<TFirst, TSecond, TThird>
    {
        private TFirst item1;
        private TSecond item2;
        private TThird item3;

        public Threeuple(TFirst item1, TSecond item2, TThird item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public override string ToString()
        {
            return $"{item1} -> {item2} -> {item3}";
        }
    }
}
