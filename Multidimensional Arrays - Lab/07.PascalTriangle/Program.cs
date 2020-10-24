using System;

namespace _7.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] matrix = new long[rows][];
            int cols = 1;

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new long[cols];
                matrix[row][0] = 1;
                matrix[row][matrix[row].Length - 1] = 1;

                if (row > 1)
                {
                    for (int col = 1; col < matrix[row].Length - 1; col++)
                    {
                        long[] prevRow = matrix[row - 1];
                        long firstNum = prevRow[col];
                        long secondNUm = prevRow[col - 1];
                        matrix[row][col] = firstNum + secondNUm;
                    }
                }

                cols++;
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
