using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SumOfCoins
{
    public class SumOfCoins
    {
        public static void Main(string[] args)
        {
            int[] availableCoins = new[] { 1, 2, 5, 10, 20, 50 };
            int targetSum = 923;

            Dictionary<int, int> selectedCoins = ChooseCoins(availableCoins, targetSum);

            Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
            foreach (var selectedCoin in selectedCoins)
            {
                Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            List<int> sortedCoins = coins.OrderByDescending(x => x).ToList();
            Dictionary<int, int> chosenCoins = new Dictionary<int, int>();
            int currentSum = 0;
            int coinIndex = 0;
            while (currentSum != targetSum && coinIndex < sortedCoins.Count)
            {
                int currentCoinValue = sortedCoins[coinIndex];
                int remainingSum = targetSum - currentSum;
                int numberOfCoinsToTake = remainingSum / currentCoinValue;
                if (numberOfCoinsToTake > 0)
                {
                    chosenCoins.Add(currentCoinValue, numberOfCoinsToTake);
                    currentSum += currentCoinValue * numberOfCoinsToTake;
                }
                coinIndex++;
            }
            if (currentSum != targetSum)
            {
                throw new Exception("Can't return result with given coins");
            }
            return chosenCoins;
        }
    }
}
