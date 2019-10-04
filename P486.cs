public class Solution {
    private bool Dfs(ref int[] nums, int left, int right, int sc1, int sc2) {
        if (left >= right)
            return sc1 >= sc2;
        bool win = false;
        // Player 1 picks left
        if (left == right - 1)
            win |= Dfs(ref nums, left + 1, right - 1, sc1 + nums[left], sc2 + nums[right]);
        else 
            win |= Dfs(ref nums, left + 1, right - 1, sc1 + nums[left], sc2 + nums[right]) && Dfs(ref nums, left + 2, right, sc1 + nums[left], sc2 + nums[left + 1]);
        if (win)
            return true;
        // Player 1 picks right
        if (left == right - 1)
            win |= Dfs(ref nums, left + 1, right - 1, sc1 + nums[right], sc2 + nums[left]);
        else 
            win |= Dfs(ref nums, left + 1, right - 1, sc1 + nums[right], sc2 + nums[left]) && Dfs(ref nums, left, right - 2, sc1 + nums[right], sc2 + nums[right - 1]);
        return win;
    }

    public bool PredictTheWinner(int[] nums) {
        if (nums.Length == 0)
            return true;
        return Dfs(ref nums, 0, nums.Length - 1, 0, 0);
    }
}