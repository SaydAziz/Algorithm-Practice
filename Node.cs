using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Node
    {
        public int Value { get; set; }
        public List<Node> Children { get; set; }

        public Node(int value)
        {
            Value = value;
            Children = new List<Node>();
        }
    }
}
