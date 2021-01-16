namespace LeetCode.Ex121
{
    public class Solution
    {
        private int _mode = 1;

        public int MaxProfit(int[] prices)
        {
            return _mode == 0 ? Simple(prices) : Advanced(prices);
        }

        private int Simple(int[] prices)
        {
            var currentMax = 0;
            for (var i = 0; i < prices.Length - 1; i++)
            {
                for (var j = i + 1; j < prices.Length; j++)
                {
                    var profit = prices[j] - prices[i];
                    if (profit > currentMax)
                    {
                        currentMax = profit;
                    }
                }
            }

            return currentMax;
        }

        private int Advanced(int[] prices)
        {
            var currentMaxProfit = 0;
            var currentLowestPrice = int.MaxValue;

            for (var i = 0; i < prices.Length; i++)
            {
                var currentPrice = prices[i];
                if (currentPrice < currentLowestPrice)
                {
                    currentLowestPrice = currentPrice;
                }
                else
                {
                    var profit = currentPrice - currentLowestPrice;
                    if (profit > currentMaxProfit)
                    {
                        currentMaxProfit = profit;
                    }
                }
            }

            return currentMaxProfit;
        }
    }
}
