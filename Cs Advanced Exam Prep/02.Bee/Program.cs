using System;

namespace _02.Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] beeTeritory = new char[size, size];

            int beeRow = -1;
            int beeCol = -1;
            int polinationedFlowers = 0;

            for (int row = 0; row < beeTeritory.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < beeTeritory.GetLength(1); col++)
                {
                    beeTeritory[row, col] = rowData[col];
                    if (beeTeritory[row, col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                beeTeritory[beeRow, beeCol] = '.';
                switch (command)
                {
                    case "up": beeRow -= 1;
                        break;
                    case "down":
                        beeRow += 1;
                        break;
                    case "left":
                        beeCol -= 1;
                        break;
                    case "right":
                        beeCol += 1;
                        break;
                }

                if (beeRow < 0 || beeRow >= size || beeCol < 0 || beeCol >= size)
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }
                else
                {
                    if (beeTeritory[beeRow, beeCol] == 'f')
                    {
                        polinationedFlowers++;
                    }
                    else if (beeTeritory[beeRow, beeCol] == 'O')
                    {
                        beeTeritory[beeRow, beeCol] = '.';
                        switch (command)
                        {
                            case "up":
                                beeRow -= 1;
                                break;
                            case "down":
                                beeRow += 1;
                                break;
                            case "left":
                                beeCol -= 1;
                                break;
                            case "right":
                                beeCol += 1;
                                break;
                        }
                        if (beeRow < 0 || beeRow >= size || beeCol < 0 || beeCol >= size)
                        {
                            Console.WriteLine("The bee got lost!");
                            break;
                        }
                        if (beeTeritory[beeRow, beeCol] == 'f')
                        {
                            polinationedFlowers++;
                        }
                    }
                }
                beeTeritory[beeRow, beeCol] = 'B';
                command = Console.ReadLine();
            }

            if (polinationedFlowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - polinationedFlowers} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {polinationedFlowers} flowers!");
            }

            for (int row = 0; row < beeTeritory.GetLength(0); row++)
            {
                for (int col = 0; col < beeTeritory.GetLength(1); col++)
                {
                    Console.Write(beeTeritory[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
