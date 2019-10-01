// Double Pointers

public class Solution {
    public int MaxArea(int[] height) {
        int ans = 0, l = 0, r = height.Length - 1;

        while (l < r) {
            ans = Math.Max(ans, (r - l) * Math.Min(height[l], height[r]));
            if (height[l] < height[r])
                l++;
            else r--;
        }

        return ans;
    }
}