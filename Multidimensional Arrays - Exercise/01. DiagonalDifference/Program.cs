using System;
using System.Linq;

namespace _1.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = ReadMatrix(size, size);

            int primarySum = 0;
            int secondarySum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        primarySum += matrix[row, col];
                    }
                }
            }

            int currRow = 0;

            for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
            {
                for (int row = currRow; row < matrix.GetLength(0); row++)
                {
                    secondarySum += matrix[row, col];
                    currRow++;
                    break;
                }
            }

            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }
    }
}
