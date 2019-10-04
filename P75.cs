public class Solution {
    public void SortColors(int[] nums) {
        int st0 = 0, end2 = nums.Length - 1;

        for (int i = 0; i <= end2; ++i) {
            while (nums[i] != 1)
            {
                if (nums[i] == 0) {
                    while (st0 < i && nums[st0] == 0)
                        st0++;
                    if (st0 == i)
                        break;
                    nums[i] = nums[st0];
                    nums[st0] = 0;
                }
                else if (nums[i] == 2){
                    while (end2 > i && nums[end2] == 2)
                        end2--;
                    if (end2 == i)
                        break;
                    nums[i] = nums[end2];
                    nums[end2] = 2;
                }
            }
        }
    }
}