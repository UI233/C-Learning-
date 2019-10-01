public class Solution {
    private bool Intersect (int[] a, int[] b) {
        return (a[0] <= b[1] && a[0] >= b[0])|| (b[0] >= a[0] && b[0] <= a[1]);
    }
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> lres = new List<int[]>();

        for (int i = 0; i < intervals.Length; ++i) {
            if (Intersect(intervals[i], newInterval)) {
               int[] merged = newInterval;
                while (i < intervals.Length && Intersect(intervals[i], newInterval)) {
                    merged[0] = Math.Min(intervals[i][0], merged[0]);
                    merged[1] = Math.Max(intervals[i][1], merged[1]);
                    ++i;
                }
                lres.Add(merged);
                --i; 
            }
            else if (i == 0){
                if (newInterval[1] < intervals[i][0])
                    lres.Add(newInterval);
                lres.Add(intervals[i]);
                if(i == intervals.Length - 1 && intervals[i][1] < newInterval[0])
                    lres.Add(newInterval);
            }
            else if(i == intervals.Length - 1 && intervals[i][1] < newInterval[0]) {
                lres.Add(intervals[i]);
                lres.Add(newInterval);
            }
            else if (intervals[i-1][1] < newInterval[0] && newInterval[1] < intervals[i][0]) {
                lres.Add(newInterval);
                lres.Add(intervals[i]);
            }
            else {
                lres.Add(intervals[i]);
            }
        }

        if (intervals.Length == 0)
            lres.Add(newInterval);
        return lres.ToArray();
    }
}