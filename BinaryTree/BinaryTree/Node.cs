using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node
    {
        private int number;
        public Node rightLeaf;
        public Node leftLeaf;

        public Node(int value)
        {
            number = value;
            rightLeaf = null;
            leftLeaf = null;
        }

        public bool IsLeaf(ref Node node)
        {
            return (node.rightLeaf == null && node.leftLeaf == null);

        }

        public void InsertNode(ref Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);

            }
            else if (node.number < data)
            {
                InsertNode(ref node.rightLeaf, data);
            }

            else if (node.number > data)
            {
                InsertNode(ref node.leftLeaf, data);
            }
        }

        public bool Find(Node node, int f)
        {
            if (node == null)
                return false;

            if (node.number == f)
            {
                return true;
            }
            else if (node.number < f)
            {
                return Find(node.rightLeaf, f);
            }
            else if (node.number > f)
            {
                return Find(node.leftLeaf, f);
            }

            return false;
        }

        public void Display(Node n)
        {
            if (n == null)
                return;
            Display(n.leftLeaf);
            Console.Write(" " + n.number);
            Display(n.rightLeaf);
        }
    }
}
