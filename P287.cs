public class Solution {
    public int FindDuplicate(int[] nums) {
        if (nums.Length == 2)
            return nums[0];
        int ptr1 = nums[0], ptr2 = nums[0];
        do {
            ptr1 = nums[ptr1];
            ptr2 = nums[nums[ptr2]];
        } while(ptr1 != ptr2);

        int temp = ptr1, temp1 = ptr2;
        ptr1 = nums[0];
        ptr2 = temp;
        while(ptr1 != ptr2) {
            ptr1 = nums[ptr1];
            ptr2 = nums[ptr2];
        }

        return ptr1;
    }
}