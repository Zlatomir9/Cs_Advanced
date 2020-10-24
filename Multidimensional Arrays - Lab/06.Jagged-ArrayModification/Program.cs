using System;
using System.Linq;

namespace _6.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = ReadMatrix(rows);

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] splitted = command.Split();
                string operation = splitted[0];
                int row = int.Parse(splitted[1]);
                int col = int.Parse(splitted[2]);
                int value = int.Parse(splitted[3]);

                if ((matrix.Length <= row || row < 0)
                    || (matrix[row].Length <= col || col < 0))
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (operation == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    if (operation == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }
                command = Console.ReadLine();
            }

            PrintMatrix(matrix);
        }

        static int[][] ReadMatrix(int rows)
        {
            int[][] matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                int[] rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                matrix[row] = new int[rowData.Length];
                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row][col] = rowData[col];
                }
            }

            return matrix;
        }

        static void PrintMatrix(int[][] matrix)
        {
            foreach (var item in matrix)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
