using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTasks
{
    internal class Practica1
    {

        public static void Search(int[] arr, int searchValue)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == searchValue)
                    Console.WriteLine(arr[i]);
            }
        }

        public static void SearchWithBarrier(int[] arr, int searchValue)
        {
            var arrCopy = new int[arr.Length + 1];

            for (var i = 0; i < arr.Length; i++)
            {
                arrCopy[i] = arr[i];
            }

            //[1,2,3]  Length - 3, indexMax - 2
            //arrCopy Length - 6, indexMax - 5
            arrCopy[arrCopy.Length - 1] = searchValue;

            Search(arrCopy, searchValue);  
        }
    }
}
