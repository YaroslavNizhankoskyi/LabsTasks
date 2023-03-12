using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTasks.Lab2.Lab2
{
    public static class Lab2_5
    {
        public static void Solution()
        {
            var min = 1;
            var max = 100;

            var list = Enumerable.Range(min, max).ToList();

            var arr = Enumerable.Range(50, 200).ToArray();

            var count = 0;
            var foundNumbers = new List<int>(); // 1 - 100, 50 - 200

            foreach (var searchNum in list)
            {
                //Practica1.Binary(arr, searchNum)

                var index = Array.BinarySearch<int>(arr, searchNum);
                if (index >= 0)
                {
                    count++;
                    foundNumbers.Add(searchNum);
                }
            }

            Console.WriteLine($"Count: {count}");

            foreach (var searchNum in foundNumbers)
            {
                Console.WriteLine(searchNum);
            }
        }
    }
}
