using System;
using System.Data;
using System.Linq;

namespace _5.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string snakeName = Console.ReadLine();

            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] matrix = new char[rows, cols];
            int currentChar = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snakeName[currentChar];
                        currentChar++;

                        if (currentChar == snakeName.Length)
                        {
                            currentChar = 0;
                        }
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snakeName[currentChar];
                        currentChar++;

                        if (currentChar == snakeName.Length)
                        {
                            currentChar = 0;
                        }
                    }
                }
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
