class Solution {
public:
    vector<int> productExceptSelf(vector<int>& nums) {
        vector<int> ans;
        ans.resize(nums.size());
        ans[0] = 1;
        for (int i = 1; i < nums.size(); ++i)
            ans[i] = ans[i - 1] * nums[i - 1];
        int temp = 1;
        for (int i = nums.size() - 1; i >= 0; --i) {
            ans[i] *= temp;
            temp *= nums[i];
        }
        return std::move(ans);
    }
};