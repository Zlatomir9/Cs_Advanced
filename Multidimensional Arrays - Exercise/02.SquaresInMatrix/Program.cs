using System;
using System.Linq;

namespace _2.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            int equalsCount = 0;

            char[,] matrix = ReadMatrix(rows, cols);

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if ((matrix[row, col] == matrix[row, col + 1])
                        && (matrix[row + 1, col] == matrix[row + 1, col + 1])
                        && (matrix[row, col] == matrix[row + 1, col]))
                    {
                        equalsCount++;
                    }
                }
            }
            Console.WriteLine(equalsCount);
        }

        static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = char.Parse(rowData[col]);
                }
            }

            return matrix;
        }
    }
}
