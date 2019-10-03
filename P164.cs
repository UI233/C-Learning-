// Bucket
public class Solution {
    public int MaximumGap(int[] nums) {
        if (nums.Length < 2)
            return 0;
        int minv = int.MaxValue;
        int maxv = int.MinValue;

        foreach (var v in nums) {
            minv = Math.Min(v, minv);
            maxv = Math.Max(v, maxv);
        }

        int size = Math.Max(1, (maxv - minv) / (nums.Length - 1));
        int bnum = Math.Max(1, (maxv - minv) / size + 1);



        int[][] bucket = new int[bnum][];
        for (int i = 0; i < bnum; ++i)
            bucket[i] = new int[2] {int.MaxValue - 5, 0};
        
        int ans = 0;
        foreach (var v in nums) {
            int idx = (v - minv) / size;
            bucket[idx][0] = Math.Min(bucket[idx][0], v);
            bucket[idx][1] = Math.Max(bucket[idx][1], v);
        }

        for (int i = 0; i < bnum - 1;) {
            int next = i + 1;
            while (next < bnum && bucket[next][0] == int.MaxValue - 5)
                ++next;
            if (next != bnum)
                ans = Math.Max(ans, bucket[next][0] - bucket[i][1]);
            i = next;
        }

        return ans;
    }
}