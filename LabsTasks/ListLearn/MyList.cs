using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTasks.ListLearn
{
    //ctor -contrstructor, prop - property
    public class Node<T>
    {
        public T Data { get; set; }

        public Node<T> Next { get; set; }
        public Node(T data, Node<T> next)
        {
            Data = data;
            Next = next;
        }
    }
    public class MyList<T>
    {
        public Node<T> head { get; set; }
        public Node<T> last { get; set; }

        public MyList(T headData)
        {
            head = new Node<T>(headData, null);
            last = head;
        }

        public void RemoveFirst()
        {
            head = head.Next;
        }

        public void Add(T data)
        {
            var newNode = new Node<T>(data, null);
            last.Next = newNode;
            last = last.Next;
        }

        public void RemoveLast()
        {

        }

    }
}
