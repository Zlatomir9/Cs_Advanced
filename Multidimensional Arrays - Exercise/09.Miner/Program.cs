using System;

namespace _9.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            string[] directions = Console.ReadLine().Split();

            ReadMatrix(matrix, size);

            int minerRow = 0;
            int minerCol = 0;
            int totalCoals = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                    }
                    else if (matrix[row, col] == 'c')
                    {
                        totalCoals++;
                    }
                }
            }

            int collectedCoals = 0;

            for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i] == "left" && minerCol - 1 < size && minerCol - 1 >= 0)
                {
                    minerCol = minerCol - 1;
                }
                else if (directions[i] == "right" && minerCol + 1 < size && minerCol + 1 >= 0)
                {
                    minerCol = minerCol + 1;
                }
                else if (directions[i] == "up" && minerRow - 1 < size && minerRow - 1 >= 0)
                {
                    minerRow = minerRow - 1;
                }
                else if (directions[i] == "down" && minerRow + 1 < size && minerRow + 1 >= 0)
                {
                    minerRow = minerRow + 1;
                }

                if (matrix[minerRow, minerCol] == 'c')
                {
                    matrix[minerRow, minerCol] = '*';
                    collectedCoals++;
                    if (collectedCoals == totalCoals)
                    {
                        Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                        return;
                    }
                }
                else if (matrix[minerRow, minerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                    return;
                }
            }

            Console.WriteLine($"{totalCoals - collectedCoals} coals left. ({minerRow}, {minerCol})");
        }

        private static void ReadMatrix(char[,] matrix, int size)
        {
            for (int row = 0; row < size; row++)
            {
                string[] rowData = Console.ReadLine().Split();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = char.Parse(rowData[col]);
                }
            }
        }
    }
}
