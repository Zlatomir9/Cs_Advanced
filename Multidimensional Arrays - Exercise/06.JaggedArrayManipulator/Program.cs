using System;
using System.Linq;

namespace _6.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] matrix = new double[rows][];

            ReadMatrix(matrix, rows);

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2;
                        matrix[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] /= 2;
                    }
                    for (int col1 = 0; col1 < matrix[row + 1].Length; col1++)
                    {
                        matrix[row + 1][col1] /= 2;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] splitted = command.Split();
                string operation = splitted[0];
                int row = int.Parse(splitted[1]);
                int col = int.Parse(splitted[2]);
                int value = int.Parse(splitted[3]);

                if ((row >= 0 && row < rows)
                    && (col >= 0 && col < matrix[row].Length))
                {
                    if (operation == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    else if (operation == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }
                command = Console.ReadLine();
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(double[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void ReadMatrix(double[][] matrix, int rows)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[row] = new double[rowData.Length];

                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row][col] = rowData[col];
                }
            }
        }
    }
}
