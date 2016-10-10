using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree
    {
        private Node _root;
        public int Count { get; private set; }


        public BinaryTree()
        {
            _root = null;
            Count = 0;
        }
        public bool IsEmpty()
        {
            return _root == null;
        }

        public void Insert(int d)
        {
            if (IsEmpty())
            {
                _root = new Node(d);
            }
            else
            {
                _root.InsertNode(ref _root, d);
            }

            Count++;
        }

        public bool Search(int s)
        {
            return _root.Find(_root, s);
        }

        public bool IsLeaf()
        {
            if (!IsEmpty())
                return _root.IsLeaf(ref _root);

            return true;
        }

        public void Display()
        {
            if (!IsEmpty())
                _root.Display(_root);
        }
    }
}
