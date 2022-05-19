using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.Practice.T02.Problem02
{
    internal class Program
    {
        static public int FindMaxSubArray(int[] inputArray, int subLength)
        {
            int max = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                int sum = 0;
                for (int j=i; j<i+subLength; j++)
                {
                    sum += inputArray[j];                 
                    max = Math.Max(sum, max);
                    if (j >= subLength) { break; }
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[]  inputArray  = { 1, 2, 5, -4, 3 };
            Console.WriteLine(FindMaxSubArray(inputArray,3));
        }
    }
}
