public class Solution {
    public string LongestPalindrome(string s) {
        string ans = "";
        bool update = false;
        int len = s.Length;
        bool[][] dp = new bool[len + 1][];
        for (int i = 0; i <= len; ++i)
            dp[i] = new bool[len];
        for (int i = 0; i < len; ++i) {
            dp[0][i] =true;
            if (len >= 1) {
                dp[1][i] = true;
                ans = s[i].ToString();
            }
        }
        
        for (int i = 2; i <= len; ++i) {
            update = false;
            for (int j = 0; j < len; ++j) {
                int last = i - 2, now = i;
                if (j != len - 1 && dp[last][j + 1]) {
                    if (j + i - 1 < len && s[j + i - 1] == s[j]) {
                        dp[now][j] = true;
                        if (!update) {
                            update = true;
                            ans = s.Substring(j, i);
                        }
                    }
                }
            }
        }

        return ans;
    }
}