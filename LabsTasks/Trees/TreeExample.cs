using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTasks.Trees
{
    internal static class TreeExample
    {

        public static void Run()
        {
            var roots = CreateTrees();

            foreach(var root in roots) 
            {
                Console.WriteLine("Tree Showcase *** \n");

                LeftRecursiveRead(root);

                Console.WriteLine("\n Tree Showcase ***");
            }

            foreach (var root in roots)
            {
                Console.WriteLine("Tree Showcase *** \n");

                RightRecursiveRead(root);

                Console.WriteLine("\n Tree Showcase ***");
            }

        }

        public static List<Node<int>> CreateTrees()
        {
            var treeDep2 = new Node<int>(10,
                new Node<int>(5),
                new Node<int>(16)
            );

            var treeDep3 = new Node<int>(10,
                new Node<int>(5,
                    new Node<int>(1),
                    new Node<int>(4)
                ),
                new Node<int>(16,
                    new Node<int>(17),
                    new Node<int>(21)
                )
            );

            return new List<Node<int>> { treeDep2, treeDep3 };
        }

        public static void LeftRecursiveRead(Node<int> root)
        {
            Console.WriteLine(root.Value);

            if(root.Left != null)
            {
                LeftRecursiveRead(root.Left);
            }

            if (root.Right != null)
            {
                LeftRecursiveRead(root.Right);
            }
        }


        public static void RightRecursiveRead(Node<int> root)
        {
            Console.WriteLine(root.Value);

            if (root.Right != null)
            {
                RightRecursiveRead(root.Right);
            }


            if (root.Left != null)
            {
                RightRecursiveRead(root.Left);
            }
        }
    }
}
