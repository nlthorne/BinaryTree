using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            tree.Insert(1);
            tree.Insert(8);
            tree.Insert(5);
            tree.Insert(2);
            tree.Insert(9);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(3);
            tree.Insert(10);

            tree.Display();

            Console.ReadLine();
        }
    }
}
