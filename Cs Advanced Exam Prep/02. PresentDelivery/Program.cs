using System;

namespace _02._PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int presents = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            int santaRow = -1;
            int santaCol = -1;
            int niceKidsCount = 0;
            int niceKidsWithPresents = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = char.Parse(rowData[col]);
                    if (matrix[row, col] == 'S')
                    {
                        santaRow = row;
                        santaCol = col;
                    }
                    else if (matrix[row, col] == 'V')
                    {
                        niceKidsCount++;
                    }
                }
            }

            string move;

            while ((move = Console.ReadLine()) != "Christmas morning")
            {
                matrix[santaRow, santaCol] = '-';
                switch (move)
                {
                    case "up":
                        santaRow--;
                        break;
                    case "down":
                        santaRow++;
                        break;
                    case "left":
                        santaCol--;
                        break;
                    case "right":
                        santaCol++;
                        break;
                }
                if (matrix[santaRow, santaCol] == 'X' || matrix[santaRow, santaCol] == 'V' || matrix[santaRow, santaCol] == '-')
                {
                    if (matrix[santaRow, santaCol] == 'V')
                    {
                        presents--;
                        niceKidsWithPresents++;
                        if (presents <= 0)
                        {
                            break;
                        }
                    }
                    matrix[santaRow, santaCol] = '-';
                    continue;
                }
                else if (matrix[santaRow, santaCol] == 'C')
                {
                    char moveUp = matrix[santaRow - 1, santaCol];
                    char moveDown = matrix[santaRow + 1, santaCol];
                    char moveLeft = matrix[santaRow, santaCol - 1];
                    char moveRight = matrix[santaRow, santaCol + 1];
                    if (moveUp == 'V' || moveUp == 'X')
                    {
                        presents--;
                        if (moveUp == 'V')
                        {
                            niceKidsWithPresents++;
                        }
                        matrix[santaRow - 1, santaCol] = '-';
                        if (presents <= 0)
                        {
                            break;
                        }
                    }
                    if (moveDown == 'V' || moveDown == 'X')
                    {
                        presents--;
                        if (moveDown == 'V')
                        {
                            niceKidsWithPresents++;
                        }
                        matrix[santaRow + 1, santaCol] = '-';
                        if (presents <= 0)
                        {
                            break;
                        }
                    }
                    if (moveLeft == 'V' || moveLeft == 'X')
                    {
                        presents--;
                        if (moveLeft == 'V')
                        {
                            niceKidsWithPresents++;
                        }
                        matrix[santaRow, santaCol - 1] = '-';
                        if (presents <= 0)
                        {
                            break;
                        }
                    }
                    if (moveRight == 'V' || moveRight == 'X')
                    {
                        presents--;
                        if (moveRight == 'V')
                        {
                            niceKidsWithPresents++;
                        }
                        matrix[santaRow, santaCol + 1] = '-';
                        if (presents <= 0)
                        {
                            break;
                        }
                    }
                }
                if (presents <= 0)
                {
                    break;
                }
            }

            matrix[santaRow, santaCol] = 'S';

            if (presents <= 0)
            {
                Console.WriteLine("Santa ran out of presents!");
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }

            if (niceKidsCount > niceKidsWithPresents)
            {
                Console.WriteLine($"No presents for {niceKidsCount - niceKidsWithPresents} nice kid/s.");
            }
            else
            {
                Console.WriteLine($"Good job, Santa! {niceKidsWithPresents} happy nice kid/s.");
            }
        }
    }
}
