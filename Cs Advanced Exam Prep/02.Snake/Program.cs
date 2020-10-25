using System;

namespace _02.Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] territory = new char[size, size];
            int snakeRow = -1;
            int snakeCol = -1;
            int eatenFood = 0;

            for (int row = 0; row < territory.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < territory.GetLength(1); col++)
                {
                    territory[row, col] = rowData[col];
                    if (territory[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                }
            }

            string command = Console.ReadLine();

            while (true)
            {
                territory[snakeRow, snakeCol] = '.';
                switch (command) 
                {
                    case "up": snakeRow -= 1;
                        break;
                    case "down": snakeRow += 1;
                        break;
                    case "left": snakeCol -= 1;
                        break;
                    case "right": snakeCol += 1;
                        break;
                }

                if (snakeRow < 0 || snakeRow >= size || snakeCol < 0 || snakeCol >= size)
                {
                    Console.WriteLine("Game over!");
                    break;
                }
                if (territory[snakeRow, snakeCol] == '*')
                {
                    eatenFood++;
                    if (eatenFood >= 10)
                    {
                        Console.WriteLine("You won! You fed the snake.");
                        territory[snakeRow, snakeCol] = 'S';
                        break;
                    }
                }
                else if (territory[snakeRow, snakeCol] == 'B')
                {
                    territory[snakeRow, snakeCol] = '.';
                    bool escaped = false;

                    for (int row = 0; row < territory.GetLength(0); row++)
                    {
                        for (int col = 0; col < territory.GetLength(1); col++)
                        {
                            if (territory[row, col] == 'B')
                            {
                                snakeRow = row;
                                snakeCol = col;
                                escaped = true;
                                break;
                            }
                        }
                        if (escaped)
                        {
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Food eaten: {eatenFood}");

            for (int row = 0; row < territory.GetLength(0); row++)
            {
                for (int col = 0; col < territory.GetLength(1); col++)
                {
                    Console.Write(territory[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
