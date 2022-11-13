using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary.Math
{
    public static class Matrix
    {
        public static decimal CramerDeterminant(int[,] arr)
        {
            if(arr.GetLength(0) != arr.GetLength(1))
            {
                throw new ArgumentException("Array has to be square");
            }

            if (arr.GetLength(0) == 2)
            {
                return (arr[0, 0] * arr[1, 1]) - (arr[1, 0] * arr[0, 1]);
            }

            decimal result = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                result += (int)System.Math.Pow(-1, i + 2) * arr[0, i] * CramerDeterminant(GetTrunc(i, arr));
            }
            return result;
        }
        static int[,] GetTrunc(int column, int[,] arr)
        {
            int size = arr.GetLength(0);
            var result = new int[size - 1, size - 1];
            for (int x = 0; x < result.GetLength(0); x++)
            {
                int offset = 0;
                for (int y = 0; y < result.GetLength(0); y++)
                {
                    if (y == column)
                    {
                        offset++;
                    }
                    result[x, y] = arr[x + 1, y + offset];
                }
            }
            return result;
        }

        public static void Print(int[,] arr)
        {
            for (int x = 0; x < arr.GetLength(0); x++)
            {
                for (int y = 0; y < arr.GetLength(0); y++)
                {
                    Console.Write($"{arr[x, y]} ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] Generate(int size)
        {
            int[,] result = new int[size, size];
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    result[x, y] = Random.Shared.Next(0, 5);
                }
            }
            return result;
        }
    }
}
