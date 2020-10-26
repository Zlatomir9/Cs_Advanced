using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins
{
    public static void Main(string[] args)
    {
        var availableCoins = new[] { 1, 2, 5, 10, 20, 50 };
        var targetSum = 923;

        var selectedCoins = ChooseCoins(availableCoins, targetSum);

        Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
        foreach (var selectedCoin in selectedCoins)
        {
            Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
        }
    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {
        Dictionary<int, int> returnedCoins = new Dictionary<int, int>();
       
        coins = coins.OrderByDescending(x => x).ToArray();
        int change = 0;

        while (change < targetSum)
        {
            for (int i = 0; i < coins.Count; i++)
            {
                if (change + coins[i] <= targetSum)
                {
                    change += coins[i];
                    if (!returnedCoins.ContainsKey(coins[i]))
                    {
                        returnedCoins.Add(coins[i], 1);
                    }
                    else
                    {
                        returnedCoins[coins[i]]++;
                    }
                    break;
                }
            }
        }

        return returnedCoins;
    }
}