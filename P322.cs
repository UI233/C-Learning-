public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int[] dp = new int[amount + 1];
        int inf = 32323232;
        foreach (var v in coins)
            if (v <= amount)
                dp[v] = 1;
        dp[0] = 0;
        for (int i = 1; i <= amount; ++i)
            dp[i] = inf;
        for (int i = 0; i <= amount; ++i)
        {
            if (dp[i] != inf)
                foreach (var v in coins)
                    if (i + v <= amount && i + v >= 0)
                        dp[i + v] = Math.Min(dp[i] + 1, dp[i + v]);
        }

        return dp[amount] == inf ? -1 : dp[amount];
    }
}