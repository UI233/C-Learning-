// Four sums
public class Solution {
    List<IList<int>> ans;
    private void TwoSum(ref int[] nums, int i, int k, int target) {
        int l = k + 1, r = nums.Length - 1;
        while (l < r) {
            int sum = nums[l] + nums[r];

            if (sum < target)
                ++l;
            else if (sum > target)
                --r;
            else {
                var temp = new int[4]{nums[i], nums[k], nums[l], nums[r]};
                ans.Add(temp.ToList());
                while (l < nums.Length - 1 && nums[l] == nums[l + 1])
                    ++l;
                while (r >= 1 && nums[r] == nums[r - 1])
                    --r;
                ++l;
                --r;
            }
        }
    }

    public IList<IList<int>> FourSum(int[] nums, int target) {
        ans = new List<IList<int>>();
        Array.Sort(nums);
        // foreach (var v in nums)
        //    Console.WriteLine(v);
        for (int l = 0; l < nums.Length - 3; ++l) {
            if (l != 0 && nums[l] == nums[l - 1])
                continue;
            for (int k = l + 1; k < nums.Length; k++) {
                if (k != l + 1 && nums[k] == nums[k - 1])
                    continue;
                TwoSum(ref nums, l, k,target - nums[k] - nums[l]);
            }
        }

        return ans;
    }
}