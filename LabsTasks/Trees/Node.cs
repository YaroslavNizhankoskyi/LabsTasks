using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTasks.Trees
{
    internal class Node<T>
    {
        public Node(T value)
        {
            this.Value = value;
        }

        public Node(T value, Node<T> left, Node<T> right)
        {
            this.Value = value;
            this.Right = right;
            this.Left = left;
        }

        public T Value { get; set; }
    
        public Node<T> Right { get; set; }
        public Node<T> Left { get; set; }
    }
}
