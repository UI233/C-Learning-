class Solution(object):
    def numDecodings(self, s):
        if s == "":
            return 0
        """
        :type s: str
        :rtype: int
        """
        ans = [0 for i in s]
        if s[0] == '0':
            ans[0] = 0 
        else:
            ans[0] = 1
        for i in range(1, len(s)):
            v = int(s[i])
            if v != 0:
                ans[i] = ans[i] + ans[i - 1]
            t = int(s[i - 1 : i + 1])
            if t <= 26 and t >= 1 and s[i - 1] != '0':
                if i == 1:
                    ans[i] = ans[i] + 1
                else:
                    ans[i] = ans[i] + ans[i - 2]
        return int(ans[len(ans) - 1])