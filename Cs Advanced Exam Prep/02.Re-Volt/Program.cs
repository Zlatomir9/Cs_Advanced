using System;

namespace _02.Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int commandsCount = int.Parse(Console.ReadLine());

            char[,] field = new char[size, size];
            int playerRow = -1;
            int playerCol = -1;
            bool hasWon = false;

            for (int row = 0; row < field.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = rowData[col];
                    if (field[row,col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            for (int i = 0; i < commandsCount; i++)
            {
                string movement = Console.ReadLine();
                field[playerRow, playerCol] = '-';

                switch (movement)
                {
                    case "up": playerRow -= 1;
                        if (playerRow < 0)
                        {
                            playerRow = size - 1;
                        }
                        break;
                    case "down":
                        playerRow += 1;
                        if (playerRow >= size)
                        {
                            playerRow = 0;
                        }
                        break;
                    case "left":
                        playerCol -= 1;
                        if (playerCol < 0)
                        {
                            playerCol = size - 1;
                        }
                        break;
                    case "right":
                        playerCol += 1;
                        if (playerCol >= size)
                        {
                            playerCol = 0;
                        }
                        break;
                }

                if (field[playerRow, playerCol] == 'B')
                {
                    switch (movement)
                    {
                        case "up":
                            playerRow -= 1;
                            if (playerRow < 0)
                            {
                                playerRow = size - 1;
                            }
                            break;
                        case "down":
                            playerRow += 1;
                            if (playerRow >= size)
                            {
                                playerRow = 0;
                            }
                            break;
                        case "left":
                            playerCol -= 1;
                            if (playerCol < 0)
                            {
                                playerCol = size - 1;
                            }
                            break;
                        case "right":
                            playerCol += 1;
                            if (playerCol >= size)
                            {
                                playerCol = 0;
                            }
                            break;
                    }
                }
                if (field[playerRow, playerCol] == 'T') 
                {
                    switch (movement)
                    {
                        case "up":
                            playerRow += 1;
                            if (playerRow >= size)
                            {
                                playerRow = 0;
                            }
                            break;
                        case "down":
                            playerRow += 1;
                            playerRow -= 1;
                            if (playerRow < 0)
                            {
                                playerRow = size - 1;
                            }
                            break;
                        case "left":
                            playerCol += 1;
                            if (playerCol >= size)
                            {
                                playerCol = 0;
                            }
                            break;
                        case "right":
                            playerCol -= 1;
                            if (playerCol < 0)
                            {
                                playerCol = size - 1;
                            }
                            break;
                    }
                }
                else if (field[playerRow, playerCol] == 'F') 
                {
                    hasWon = true;
                    break;
                }
            }
            field[playerRow, playerCol] = 'f';

            if (hasWon)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write($"{field[row,col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
