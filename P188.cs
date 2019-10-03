public class Solution {
    public int MaxProfit(int k, int[] prices) {
        int[][] dp = new int[2][];
        int ans = 0;
        if (k == 0)
            return ans;
        k = Math.Min(k, prices.Length / 2 + 1);
        for (int i = 0; i < dp.Length; ++i)
            dp[i] = new int[(k + 1) * 2];

        for (int i = 0; i < dp.Length; ++i)
            for (int j = 0; j < dp[i].Length; ++j) {
                dp[i][j] = -3232323;
                if (i == 0 && j == 0)
                    dp[i][j] = 0;
            }

        for (int i = 1; i <= prices.Length; ++i) {
            dp[i % 2][0] = 0;
            dp[i % 2][1] = -3232323;
            for (int j = 1; j <= k; ++j) {
                dp[i % 2][2 * j] = Math.Max(dp[(i - 1) % 2][2 * j], dp[(i - 1) % 2][2 * j + 1] + prices[i - 1]);
                dp[i % 2][2 * j + 1] = Math.Max(dp[(i - 1) % 2][2 * j + 1], dp[(i - 1) % 2][2 * j - 2] - prices[i - 1]);
                // Console.WriteLine($"{i},{j}: {dp[i % 2][2 * j]} {dp[i % 2][2 * j + 1]}");
                ans = Math.Max(ans, dp[i % 2][2 * j]);
                ans = Math.Max(ans, dp[i % 2][2 * j + 1]);
            }
        }

        return ans;
    }
}