public class Solution {
    public int MaxCoins(int[] nums) {
        if (nums.Length == 0)
            return 0;
        int[][] dp = new int[nums.Length][];
        for (int i = 0; i <nums.Length; ++i)
            dp[i] = new int[nums.Length];
        for (int i = 0; i < nums.Length; ++i)
            for (int j = 0; j < nums.Length; ++j)
                dp[i][j] = 0;
        for (int len = 0; len < nums.Length; len++) {
            for (int st = 0; st + len < nums.Length; ++st) {
                int left = st == 0 ?  1 : nums[st - 1];
                int right = st + len == nums.Length - 1 ? 1 : nums[st + len + 1];
                for (int p = st; p <= st + len; p++) {
                    int ldp, rdp;
                    if (p == 0)
                        ldp = 0;
                    else ldp = dp[st][p - 1];
                    if (p == nums.Length - 1)
                        rdp = 0;
                    else rdp = dp[p + 1][st + len];
                    dp[st][st + len] = Math.Max(dp[st][st + len], left * right * nums[p] +  ldp + rdp);
                }
            }
        }

        return dp[0][nums.Length - 1];
    }
}