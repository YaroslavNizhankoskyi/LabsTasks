using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTasks
{
    internal class Lab2_2
    {
        static void Main(string[] args)
        {
            //Menu();
            char key;
            do
            {
                int[] arr = Array();
                SortArray(arr);
                SimplePairs();

                Console.WriteLine("Continue y(0)/n(1)");
                key = (char)Convert.ToInt32(Console.ReadLine());
            } while (key != 1);

        }

        //static void Menu()
        //{
        //    Console.WriteLine("");
        //    Console.WriteLine("");
        //    Console.WriteLine("");
        //    Console.WriteLine("");
        //    Console.WriteLine("");
        //    Console.WriteLine("");
        //}

        static int[] Array()
        {
            try
            {
                Console.WriteLine("Enter the amount of numbers: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the min value of the array element");
                int min = Convert.ToInt32(Console.ReadLine());
                if (min <= 0)
                {
                    Console.WriteLine("Enter the min value of the array element > 0");
                    min = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Enter the max value of the array element");
                int max = Convert.ToInt32(Console.ReadLine());
                if (max <= 0 || max <= min)
                {
                    Console.WriteLine("Enter the max value of the array element > 0 and > min value");
                    max = Convert.ToInt32(Console.ReadLine());
                }

                int[] arr = new int[a];
                Random rand = new Random();
                for (int i = 0; i < a; i++)
                {
                    arr[i] = rand.Next(min, max);
                    Console.Write(arr[i] + " ");
                }
                return arr;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                throw new Exception(/*error.Message +*/ "Error while inputting array elements");
            }
        }

        static void SortArray(int[] arr)
        {
            for (int i = 1; i < arr.Length; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            Console.WriteLine("\nSort: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void SimplePairs()
        {

        }
    }
}
