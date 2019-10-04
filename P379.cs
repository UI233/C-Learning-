public class Solution {
    public int IntegerReplacement(int t) {
        int  ans = 0;
        uint n = (uint)t;
        while (n != 1u)
        {
            if (n % 2u == 0)
            {
                ans++;
                n = n / 2u;
            }
            else 
            {
                if (n == 3u) 
                {
                    ans += 2;
                    n = 1u;
                }
                else if (((n + 1u) & 2u) == 2u)
                {
                    --n;
                    ans++;
                }
                else
                {
                    ++n;
                    ans++;
                }
            }
        }

        return ans;
    }
}