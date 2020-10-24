using System;
using System.Linq;
using System.Runtime.Serialization;

namespace _8.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            ReadMatrix(matrix, size);

            string[] bombsPlaces = Console.ReadLine().Split();

            for (int i = 0; i < bombsPlaces.Length; i++)
            {
                string[] splitted = bombsPlaces[i].Split(',');
                int row = int.Parse(splitted[0]);
                int col = int.Parse(splitted[1]);

                int bombValue = matrix[row, col];
                if (bombValue > 0)
                {
                    if ((row - 1 < size && row - 1 >= 0)
                    && (matrix[row - 1, col] > 0))
                    {
                        matrix[row - 1, col] -= bombValue;
                    }
                    if ((row + 1 < size && row + 1 >= 0)
                        && (matrix[row + 1, col] > 0))
                    {
                        matrix[row + 1, col] -= bombValue;
                    }
                    if ((col + 1 < size && col + 1 >= 0)
                        && (matrix[row, col + 1] > 0))
                    {
                        matrix[row, col + 1] -= bombValue;
                    }
                    if ((col - 1 < size && col - 1 >= 0)
                        && (matrix[row, col - 1] > 0))
                    {
                        matrix[row, col - 1] -= bombValue;
                    }
                    if ((row - 1 < size && col - 1 < size)
                        && (row - 1 >= 0 && col - 1 >= 0)
                        && (matrix[row - 1, col - 1] > 0))
                    {
                        matrix[row - 1, col - 1] -= bombValue;
                    }
                    if ((row - 1 < size && col + 1 < size)
                        && (row - 1 >= 0 && col + 1 >= 0)
                        && matrix[row - 1, col + 1] > 0)
                    {
                        matrix[row - 1, col + 1] -= bombValue;
                    }
                    if ((row + 1 < size && col + 1 < size)
                        && (row + 1 >= 0 && col + 1 >= 0)
                        && (matrix[row + 1, col + 1] > 0))
                    {
                        matrix[row + 1, col + 1] -= bombValue;
                    }
                    if ((row + 1 < size && col - 1 < size)
                        && (row + 1 >= 0 && col - 1 >= 0)
                        && (matrix[row + 1, col - 1] > 0))
                    {
                        matrix[row + 1, col - 1] -= bombValue;
                    }

                    matrix[row, col] = 0;
                }
            }

            int aliveCells = 0;
            int sum = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void ReadMatrix(int[,] matrix, int size)
        {
            for (int row = 0; row < size; row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
