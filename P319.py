class Solution(object):
    def bulbSwitch(self, n):
        """
        :type n: int
        :rtype: int
        """
        l = 0
        r = n
        while l < r:
            mid = (l + r) // 2
            # print("{0} {1}".format(l, r))
            if mid * mid <= n:
                l = mid  + 1
            else:
                r = mid
        if l * l > n:
            l = l - 1
        return l