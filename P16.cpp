#include <algorithm>
#define abs(x) ((x) < 0 ? -(x) : (x))

class Solution {
public:
    int threeSumClosest(vector<int>& nums, int target) {
        std::sort(nums.begin(), nums.end());
        int ans = -64564566;
        for (int i = 1; i < nums.size() - 1; ++i) {
            int j = 0, k = nums.size() - 1;
            while (j < i && i < k) {
                int losses = nums[i] + nums[j] + nums[k] - target;
                if (abs(losses) < abs(ans - target))
                    ans = nums[i] + nums[j] + nums[k];
                if (losses < 0)
                    j++;
                else if (losses > 0)
                    k--;
                else return target; 
            }
        }    

        return ans;
    }
};