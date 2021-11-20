using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Node
    {
        public Position Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }

        public Node(Position value)
        {
            this.Value = value;
        }
    }
}
