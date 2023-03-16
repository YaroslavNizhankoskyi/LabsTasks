using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTasks
{
    internal static class Lab2_9
    {
        public static void Calculate(string str = "1+3*4/11")
        {
            str = RemoveGarbageSymbols(str);

            var symbols = new char[] { '*', '+', '-', '/' };

            var calcList = str.ToList();

            var operations = calcList
                .FindAll(x => symbols.Contains(x))
                .ToList(); 

            for(var i = 0; i < calcList.Count; i++)
            {
                if (symbols.Contains(calcList[i]))
                {
                    calcList[i] = ',';
                }
            }

            var numsString = new string(calcList.ToArray());
            var nums = numsString
                .Split(',')
                .Select(x => int.Parse(x))  
                .ToList();

            var result = int.MinValue;

            if(nums.Count - 1 == operations.Count)
            {
                while (nums.Count > 0)
                {
                    if(result == int.MinValue)
                    {
                        var leftOp = nums[0];
                        var rightOp = nums[1];
                        var operation = operations[0];

                        //switch

                        result = CalcOperation(leftOp, rightOp, operation);
                        operations.RemoveAt(0);
                        nums.RemoveAt(0);
                        nums.RemoveAt(0);
                    }else
                    {
                        result = CalcOperation(result, nums[0], operations[0]);
                        operations.RemoveAt(0);
                        nums.RemoveAt(0);
                    }
                }
            }

            Console.WriteLine(result);
        }

        private static List<char> GetOperations()
        {
            throw new NotImplementedException(); //TODO
        }

        private static string RemoveGarbageSymbols(string str)
        {            
            return str; //TODO;
        }

        public static int CalcOperation(int num1, int num2, char operation)
        {
            return num1 + num2; //TODO
        }
    }
}
