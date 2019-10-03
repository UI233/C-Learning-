public class Solution {
    private int[] sum;
    private bool Check(int len, int s) {
        if (len == sum.Length)
            return false;
        for (int i = 0; i + len < sum.Length; ++i)
            if (sum[i + len] - sum[i] >= s)
                return true;
        return false;
    }

    public int MinSubArrayLen(int s, int[] nums) {
        sum = new int[nums.Length + 1];
        sum[0] = 0;
        for (int i = 1; i <= nums.Length; ++i)
            sum[i] = sum[i - 1] + nums[i - 1];
        int l = 1, r = nums.Length + 1;
        while (l < r) {
            int mid = (l + r) / 2;
            if (Check(mid, s)) 
                r = mid;
            else 
                l = mid + 1;
        }

        return r == sum.Length ? 0 : r;
    }
}