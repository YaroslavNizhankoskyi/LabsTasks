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

        public static void Binary(int[] arr, int searchValue)
        {
            Console.WriteLine("Sorted array");
            System.Array.Sort(arr);
            foreach (int ar in arr)
            {
                Console.Write(ar + " ");
            }

            int min = 0;
            int max = arr.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                int midIndex = arr[mid];

                if (midIndex == searchValue)
                {
                    Console.WriteLine($"Number {searchValue} - found");
                    return;
                }
                else if (midIndex < searchValue)
                    min = mid + 1;
                else
                    max = mid - 1;
            }
            Console.WriteLine($"Number {searchValue} - not found");
        }

        //public static void Binary(int[] arr, int searchValue)
        //{
        //    Console.WriteLine("Sorted array");
        //    System.Array.Sort(arr);
        //    foreach (int ar in arr)
        //    {
        //        Console.Write(ar + " ");
        //    }

        //    int min = 0;
        //    int max = arr.Length - 1;
        //    while (min <= max)
        //    {
        //        int mid = (min + max) / 2;
        //        int midIndex = arr[mid];

        //        if (midIndex == searchValue)
        //        {
        //            Console.WriteLine($"Number {searchValue} - found");
        //            return;
        //        }
        //        else if (midIndex < searchValue)
        //            min = mid + 1;
        //        else
        //            max = mid - 1;
        //    }
        //    Console.WriteLine($"Number {searchValue} - not found");
        //}
        public static bool GoldenSectionBinaryArray(int[] arr, int searchValue)
        {
            Console.WriteLine("Sorted array");
            System.Array.Sort(arr);
            foreach (int ar in arr)
            {
                Console.Write(ar + " ");
            }

            int min = 0;
            int max = arr.Length - 1;
            double mid = (1 + Math.Sqrt(5)) / 2;
            int x1 = (int)Math.Floor(max - (max - min) / mid); //повертає більше значення            
            int x2 = (int)Math.Ceiling(min + (max - min) / mid); //повертає менше значення

            while (min <= max)
            {
                if (arr[x1] == searchValue || arr[x2] == searchValue)
                {
                    Console.WriteLine($"\nNumber {searchValue} - found");
                    return true;
                }
                if (searchValue < arr[x1])
                    max = x1 - 1;
                else if (searchValue > arr[x2])
                    min = x2 + 1;
                else
                {
                    min = x1 + 1;
                max = x2 - 1;
                }
                x1 = (int)Math.Floor(max - (max - min) / mid);
                x2 = (int)Math.Ceiling(min + (max - min) / mid);
            }
            Console.WriteLine($"\nNumber {searchValue} - not found");
            return false;

        }

        public static bool GoldenSectionBinaryList(List<int> list, int searchValue)
        {
            Console.WriteLine("Sorted array");

            list.Sort();

            foreach (int ar in list)
            {
                Console.Write(ar + " ");
            }

            int min = 0;
            int max = list.Count - 1;
            double mid = (1 + Math.Sqrt(5)) / 2;
            int x1 = (int)Math.Floor(max - (max - min) / mid); //повертає більше значення            
            int x2 = (int)Math.Ceiling(min + (max - min) / mid); //повертає менше значення

            while (min <= max)
            {
                if (list[x1] == searchValue || list[x2] == searchValue)
                {
                    Console.WriteLine($"\nNumber {searchValue} - found");
                    return true;
                }
                if (searchValue < list[x1])
                    max = x1 - 1;
                else if (searchValue > list[x2])
                    min = x2 + 1;
                else
                {
                    min = x1 + 1;
                    max = x2 - 1;
                }
                x1 = (int)Math.Floor(max - (max - min) / mid);
                x2 = (int)Math.Ceiling(min + (max - min) / mid);
            }
            Console.WriteLine($"\nNumber {searchValue} - not found");
            return false;
        }
    }
}
