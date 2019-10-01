public class Solution {
	public int NthUglyNumber(int n) {
		int i1 = 1, i2 = 1, i3 = 1;
		int i = 0;
		int[] dp = new int[1692];
		dp[1] = 1;
		for (i = 1; i < n; ++i)
		{
			while (dp[i1] * 2 <= dp[i])
				++i1;
			while (dp[i2] * 3 <= dp[i])
				++i2;
			while (dp[i3] * 5 <= dp[i])
				++i3;
				
			int a = dp[i1] * 2, b = dp[i2] * 3, c = dp[i3] * 5;
			dp[i + 1] = Math.Min(a, Math.Min(b, c));
		} 

			return dp[n];
	}
}
