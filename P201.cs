public class Solution {
    public int RangeBitwiseAnd(int m, int n) {
        int ans = 0;
        
        for (var i = 0 ; i < 31; i++) {
            int bits = (1 << i);
            if (m / bits == n / bits && (m / bits) % 2 == 1)
                ans = ans | bits;
        }
        
        return ans;
    }
}