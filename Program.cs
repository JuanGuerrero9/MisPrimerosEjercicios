using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //Esta variable n es la que quiero usar en el metodo diagonalDifference

            int n = Convert.ToInt32(Console.ReadLine().Trim());




            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

    class Result
    {
        //Aqui

        public static int diagonalDifference(List<List<int>> arr)
        {
            
            int d1 = 0;
            int d2 = 0;

            for (int i = 0; i < n; i++)
            {
                d1 += arr[i][i];
                d2 += arr[i][n - 1 - i];
            }
            return Math.Abs(d1 - d2);

        }
    }
}
