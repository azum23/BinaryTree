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

        public int Count
        {
            get { return count; }
        }

        public bool Contains(T value)
        {
            BinaryTreeNode<T> parent;
            return FindWithParent(value, out parent) != null;
        }

        public BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
        {
            BinaryTreeNode<T> current = root;
            Console.WriteLine($"---\tНaчинаем поиск [{value}] с корня дерева [{current.Value}]");
            parent = null;

            while (current != null)
            {
                int result = current.CompareTo(value);
                if (result > 0)
                {
                    parent = current;
                    current = current.Left;
                    Console.WriteLine($"---\tСпускаемся влево к ноде [{current.Value}]");

                }
                else if (result < 0 )
                {
                    parent = current;
                    current = current.Right;
                    Console.WriteLine($"---\tСпускаемся вправо к ноде [{current.Value}]");
                }
                else
                {
                    Console.WriteLine($"---\tИскомый элемент {value} найден");
                    break;
                }
            }
            return current;
        }
    }
}
