using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeB
{
    class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        public BinaryTreeNode<T> root;
        private int count;

        public void Add(T value)
        {
            if (root == null)
            {
                root = new BinaryTreeNode<T>(value);
                Console.WriteLine($"Значение {value} добавлено в корень дерева");
            }
            else
            {
                AddTo(root, value);
            }
            count++;
        }

        public void AddTo(BinaryTreeNode<T> root, T value)
        {
            if (root.Value.CompareTo(value) < 0)
            {
                if (root.Right == null)
                {
                    root.Right = new BinaryTreeNode<T>(value);
                    Console.WriteLine($"Значение {value} добавлено справа от {root.Value}");
                }
                else
                {
                    AddTo(root.Right, value);
                }
            }
            else
            {
                if (root.Left == null)
                {
                    root.Left = new BinaryTreeNode<T>(value);
                    Console.WriteLine($"Значение {value} добавлено слева от {root.Value}");
                }
                else
                {
                    AddTo(root.Left, value);
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
