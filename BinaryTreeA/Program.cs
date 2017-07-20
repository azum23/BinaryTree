using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeA
{
    class Program
    {
        static void Main(string[] args)
        {

            BinaryTreeNode<int> Node1 = new BinaryTreeNode<int>(5);
            BinaryTreeNode<int> Node2 = new BinaryTreeNode<int>(3);
            BinaryTreeNode<int> Node3 = new BinaryTreeNode<int>(8);

            if (Node1.CompareNode(Node2) >= 0)
            {
                Node1.Left = Node2;
            }
            else
            {
                Node1.Right = Node2;
            }

            if (Node1.CompareNode(Node3) >= 0)
            {
                Node1.Left = Node3;
            }
            else
            {
                Node1.Right = Node3;
            }


            Console.WriteLine($"Left children of node [{Node1.Value}] : [{Node1.Left.Value}]");
            Console.WriteLine($"Right children of node [{Node1.Value}] : [{Node1.Right.Value}]");

            Console.WriteLine(new string('-',30));

            Console.WriteLine(Node1.CompareNode(Node2));
            Console.WriteLine(Node1.Value.CompareTo(Node2.Value));

            Console.ReadLine();
        }
    }
}
