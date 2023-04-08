using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTasks.Lab2
{
    internal class Numbers
    {
        //10000, erath - 10000
        public static void CheckNumbers(int[] arr, int max)
        {
            var erathList = ErathosfenList.Get(max);

            for (var i = 0; i < arr.Length; i += 2)
            {
                var numberIsSimple = erathList.Contains(arr[i]);

                Console.WriteLine($"Number: {arr[i]}, index: {i}, simple: {numberIsSimple} ");
            }
        }
    }
}
