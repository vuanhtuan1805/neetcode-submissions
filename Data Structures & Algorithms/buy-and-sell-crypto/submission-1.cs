public class Solution {
    public int MaxProfit(int[] prices) {
        int buyPrice = prices[0];
        int profit = 0;

        for(int i = 1; i < prices.Length; i++){
            profit = Math.Max(prices[i] - buyPrice, profit);
            buyPrice = Math.Min(buyPrice, prices[i]);
        }

        return profit;
    }
}
