class Solution(object):
    def isValidSeq(self, a, b, st, num):
        now = st
        while now < len(num):
            res = a + b
            if now + len(str(res)) <= len (num):
                # print (num[now : now + len(str(res))])
                if num[now : now + len(str(res))] != str(res):
                    return False
            else:
                return False
            now = now + len(str(res))
            a,b = b,res
        return True

    def isAdditiveNumber(self, num):
        """
        :type num: str
        :rtype: bool
        """
        for i in range(1, len(num) - 1):
            for j in range(i + 1, len(num)):
                a, b = num[0: i], num[i : j]
                # print()
                if num[i: i + 1] == '0' and j != i + 1:
                    continue
                if self.isValidSeq(int(a), int(b), j, num):
                    return True
            if num[0] == '0':
                return False
        return False
        