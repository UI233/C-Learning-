// 3Sum Problem

public class Solution {
    List<IList<int>> ans;
    private void TwoSum(ref int[] nums, int k) {
        int target = -nums[k];
        int l = k + 1, r = nums.Length - 1;
        while (l < r) {
            int sum = nums[l] + nums[r];

            if (sum < target)
                ++l;
            else if (sum > target)
                --r;
            else {
                var temp = new int[3]{nums[k], nums[l], nums[r]};
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

    public IList<IList<int>> ThreeSum(int[] nums) {
        ans = new List<IList<int>>();
        Array.Sort(nums);
        // foreach (var v in nums)
        //    Console.WriteLine(v);
        int[] last = new int[3]{-1, -1, -1};
        for (int k = 0; k < nums.Length; k++) {
            if (k != 0 && nums[k] == nums[k - 1])
                continue;
            TwoSum(ref nums, k);
        }

        return ans;
    }
}