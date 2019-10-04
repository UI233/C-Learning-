public class Solution {
    public int NumberOfArithmeticSlices(int[] A) {
        if (A.Length == 0)
            return 0;
        int[] diff = new int[A.Length - 1];
        int cnt = 0;
        for (int i = 1; i < A.Length; ++i)
            diff[i - 1] = A[i] - A[i - 1];
        
        int ans = 0;
        for (int i = 0; i < diff.Length;)
        {
            int j = 0;
            for (j = i + 1; j < diff.Length && diff[j] == diff[i]; ++j);
            int count = j - i;
            // Console.WriteLine(count);
            if (count >= 2)
                ans += (count - 1) * count / 2;
            i = j;
        }

        return ans;
    }
}