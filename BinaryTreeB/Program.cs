using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeB
{
    class Program
    {
        static void Main(string[] args)
        {
            //test comments

            BinaryTree<int> bTree = new BinaryTree<int>();

            bTree.Add(5);
            bTree.Add(4);
            bTree.Add(8);
            bTree.Add(12);
            bTree.Add(1);
            bTree.Add(3);

            Console.ReadKey();
        }
    }
}
