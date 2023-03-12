using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTasks.Lab2
{
    public static class Lab2_6
    {
        public static void Solution()
        {
            var matrix = new int[10, 10];

            var max = int.MinValue; 
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        var num = matrix[i, j];

                        if(max < num) 
                        {
                            max = num;
                        }
                    }
                }
            }

            Console.WriteLine($"Max of students: {max}");
        }
    }
}
