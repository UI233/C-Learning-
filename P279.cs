public class Solution {
    public int MaxProduct(int[] nums) {
        if (nums.Length == 0)
            return 0;
        if (nums.Length == 1)
            return nums[0];
        int[] min = new int[nums.Length], max = new int[nums.Length];
        max[0] = Math.Max(0, nums[0]);
        min[0] = Math.Min(1, nums[0]);
        for (int i = 1; i < nums.Length; ++i)
        {
            max[i] = Math.Max(Math.Max(0, nums[i]), Math.Max(nums[i] * max[i - 1], nums[i] * min[i - 1]));
            min[i] = Math.Min(Math.Min(1, nums[i]), Math.Min(nums[i] * max[i - 1], nums[i] * min[i - 1]));
        }

        int ans = 0;
        foreach (var v in max)
            ans = Math.Max(ans, v);
        return ans;
    }
}