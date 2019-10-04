public class Solution {
    public bool CanJump(int[] nums) {
        int max_jump = 0;
        int i = 0;
        foreach (var v in nums)  {
            if (max_jump >= i) {
                max_jump = Math.Max(max_jump, i + v);
            }
            ++i;
        }

        return max_jump >= nums.Length - 1;
    }
}