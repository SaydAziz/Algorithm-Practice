using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Tree
    {
        public Node Root { get; set; }

        public Tree(int[] values)
        {
            Root = new Node(values[0]);
            for (int i = 1; i < values.Length; i++)
            {
                AddNode(Root, values[i]);
            }
        }

        public void AddNode(Node parent, int value)
        {
            Node newNode = new Node(value);
            parent.Children.Add(newNode);
        }
    }
}
