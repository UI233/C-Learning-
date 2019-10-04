public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> res = new List<string>();
        for (int i = 0; i < nums.Length; ++i) {
            int st = i;
            int end = st;
            int j;
            for (j = i + 1; j < nums.Length && nums[j] - nums[j - 1] == 1; j++);
            end = j - 1;
            i = end;
            if (st == end)
                res.Add($"{nums[st]}");
            else res.Add($"{nums[st]}->{nums[end]}");
        }

        return res;
    }
}