public class Solution {
	public int NthSuperUglyNumber(int n, int[] primes) {
		int[] counts = new int[primes.Length];
		int[] dp = new int[n + 1];
		for (int i = 0; i < primes.Length; ++i)
			counts[i] = 0;
		dp[0] = 1;
		for (int i = 0; i < n; ++i)
		{
			dp[i + 1] = -1;
			for (int j = 0; j < primes.Length; ++j)
			{
				while (primes[j] * dp[counts[j]] <= dp[i])
					++counts[j];
				if (dp[i + 1] < 0)
					dp [i + 1] = dp[counts[j]] * primes[j];
				else dp[ i + 1] = Math.Min(dp[i + 1], dp[counts[j]] * primes[j]);
			}
		}

		return dp[n - 1];
	}
}
