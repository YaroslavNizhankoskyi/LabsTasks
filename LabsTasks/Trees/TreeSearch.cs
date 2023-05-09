using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTasks.Trees
{
    internal class TreeSearch
    {
        List<Node<int>> Roots { get; set; } = CreateTrees();

        public int Min { get; set; } = int.MaxValue;
        public int Max { get; set; } = int.MinValue;

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

        public void Search(Node<int> root, bool searchIsMin)
        {
            if (searchIsMin)
            {
                if (root.Value < Min)
                {
                    Min = root.Value;
                }
            }
            else
            {
                if (root.Value > Max)
                {
                    Max = root.Value;
                }
            }

            if (root.Left != null)
            {
                Search(root.Left, searchIsMin);
            }

            if (root.Right != null)
            {
                Search(root.Right, searchIsMin);
            }
        }

        public void FindMinMax()
        {
            var root = Roots[1];

            Search(root, true);
            Search(root, false);

            Console.WriteLine($"Min = {Min}");
            Console.WriteLine($"Max = {Max}");
        }

    }
}
