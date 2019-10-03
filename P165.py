class Solution(object):
    def compareVersion(self, version1, version2):
        """
        :type version1: str
        :type version2: str
        :rtype: int
        """
        subversion1 = version1.split('.')
        subversion2 = version2.split('.')
        i = 0
        comp = [] 
        while i < len(subversion1) or i < len(subversion2):
            k1 = 0
            k2 = 0
            if i < len(subversion1):
                k1 = int(subversion1[i])
            if i < len(subversion2):
                k2 = int(subversion2[i])
            comp.append((k1, k2))
            i = i + 1 

        for i, j in comp:
            if i < j:
                return -1
            elif j < i:
                return 1
        return 0
        