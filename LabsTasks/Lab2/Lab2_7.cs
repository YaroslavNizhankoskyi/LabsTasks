using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LabsTasks.Lab2
{
    internal static class Lab2_7
    {
        public static void Solution()
        {
            var matrix = new int[10, 10];

            FillMatrix(matrix, 10);

            var rows = new List<RowData>();

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                var rowData = new RowData();
                var rowArr = new int[matrix.GetLength(0)];

                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    rowArr[j] = matrix[i, j];
                }

                Array.Sort(rowArr);
                rowData.Row = rowArr;
                rowData.Position = i;
                rowData.Sum = rowArr.Sum();
                rows.Add(rowData);
            }

            rows = rows.OrderBy(row => row.Sum).ToList();

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    var row = rows[i];
                    matrix[i, j] = row.Row[j];
                }
            }

            ShowMatrix(matrix);   

        }

        public static void ShowMatrix(int[,] matrix)
        {
            //TODO
        }

        public static void FillMatrix(int[,] matrix, int dim)
        {
            Random rand = new Random();

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    matrix[i, j] = rand.Next(0, 300);
                }
            }
        }
    }


    public class RowData
    {
        public int Sum { get; set; }
        public int Position { get; set; }
        public int[] Row { get; set; }
    }
}
