using System;
using System.Linq;

namespace _4.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = ReadMatrix(size, size);

            char symbol = char.Parse(Console.ReadLine());

            int searchedRow = 0;
            int searchedCol = 0;
            bool isFound = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (isFound)
                {
                    break;
                }
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        searchedRow = row;
                        searchedCol = col;
                        isFound = true;
                        break;
                    }
                }
            }

            if (isFound)
            {
                Console.WriteLine($"({searchedRow}, {searchedCol})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix ");
            }
        }

        static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }
    }
}
