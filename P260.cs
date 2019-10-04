public class Solution {
    public int[] SingleNumber(int[] nums) {
        int xor = 0;
        foreach (var v in nums)
            xor ^= v;
        int[] res = new int[2]{0, 0};
        int i = 0;
        for (i = 0; i < 31; ++i)
            if (((xor >> i) & 1) == 1)
                break;
        
        foreach (var v in nums)
        {
            if (((v >> i) & 1) == 1)
                res[0] ^= v;
            else res[1] ^= v;
        }

        return res;
    }
}