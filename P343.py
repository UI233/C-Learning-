class Solution(object):
    ans = 0
    def dfs(self, last, now, res, depth):
        if depth <= 1 and now == 0:
            return 
        if last == 1 or now == 0:
            self.ans = max(self.ans, res)
            return
        for i in range(1, min(last + 1, now + 1)):
            self.dfs(i, now - i, res * i, depth + 1)
        return

    def integerBreak(self, n):
        """
        :type n: int
        :rtype: int
        """
        self.dfs(n, n, 1, 0)
        return self.ans