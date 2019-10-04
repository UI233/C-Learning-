class Solution(object):
    def simplifyPath(self, path):
        """
        :type path: str
        :rtype: str
        """
        ans = ""
        comps = path.split('/')
        simplified = []
        for comp in comps:
            if comp == "..":
                if len(simplified) != 0:
                    simplified.pop()
            elif comp == "." or comp == "":
                continue
            else:
                simplified.append(comp)
        for item in simplified:
            ans = ans + "/" + item
        if ans == "":
            ans = "/"
        return ans
        