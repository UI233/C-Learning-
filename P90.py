class Solution(object):
    def __init__(self):
        self.cnt = []
        self.res = []
        self.temp = []
        self.size = 0
    def construct(self):
        ret = []
        st = ""
        for i in range(0, self.size):
            ret = ret + [self.cnt[i][0] for k in range(0, self.temp[i])]
            st = st + str(self.temp[i]) + " "
        # print("{0} {1}".format(st, ret))

        return ret
    
    def dfs(self, i):
        if i == self.size:
            self.res.append(self.construct())
            return
        for v in range(0, self.cnt[i][1] + 1):
            self.temp[i] = v
            self.dfs(i + 1)
        
    def subsetsWithDup(self, nums):
        """
        :type nums: List[int]
        :rtype: List[List[int]]
        """
        nums.sort()
        i = 0
        self.size = len(nums)
        size = self.size
        while i < size:
            v = nums[i]
            count = 0
            while i < size and nums[i] == v:
                i = i + 1
                count = count + 1
            self.cnt.append((v, count))
        self.size = len(self.cnt)
        self.temp = [0 for i in range(0, self.size)]
        self.dfs(0)
        return self.res