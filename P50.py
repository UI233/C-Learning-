class Solution(object):
    def myPow(self, x, n):
        """
        :type x: float
        :type n: int
        :rtype: float
        """
        res = 1.0
        times = abs(n)
        temp = x
        while times > 0:
            if times & 1:
                res *= temp
            temp *= temp
            times >>= 1
        if n < 0:
            return 1.0 / res
        else:
            return res

        