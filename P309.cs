public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 0)
            return 0;
        int sellout = -323232, buyin = -prices[0], freeze = -323232, free = 0;

        for (int i = 1; i < prices.Length; ++i) {
            int osellout = sellout, obuyin = buyin, ofreeze = freeze, ofree = free;
            freeze = Math.Max(ofreeze, osellout);
            free = Math.Max(ofreeze, free);
            buyin = Math.Max(ofreeze - prices[i], Math.Max(ofree - prices[i], buyin));
            sellout = Math.Max(sellout, obuyin + prices[i]);
        }

        return Math.Max(0, Math.Max(Math.Max(buyin, freeze), Math.Max(sellout, free)));
    }
}