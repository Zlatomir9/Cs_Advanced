using System;
using System.Linq;

namespace _4.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = ReadMatrix(rows, cols);

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] splitted = command.Split();
                string keyWord = splitted[0];

                if (keyWord == "swap" && splitted.Length == 5)
                {
                    int row1 = int.Parse(splitted[1]);
                    int col1 = int.Parse(splitted[2]);
                    int row2 = int.Parse(splitted[3]);
                    int col2 = int.Parse(splitted[4]);

                    if ((row1 >= 0 && row1 < rows)
                        && (row2 >= 0 && row1 < rows)
                        && (col1 >= 0 && col1 < cols)
                        && (col2 >= 0 && col2 < cols))
                    {
                        string temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }

        static string[,] ReadMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }
    }
}
