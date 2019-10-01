public class Solution {
    private List<IList<int>> res;
    private int[] temp;
    private void Dfs(int now, int depth, int n, int k) {
        temp[depth] = now;
        if (depth == k - 1) {
            res.Add(temp.ToList());
            return ;
        }
        for (int i = now + 1; i <= n; ++i) {
            Dfs(i, depth + 1, n, k);
        }
    }

    public IList<IList<int>> Combine(int n, int k) {
        res = new List<IList<int>>();
        if (k == 0 || n == 0)
            return res;
        temp = new int[k];
        for (int i = 1; i <= n; ++i)
            Dfs(i, 0, n, k);
        return res;
    }
}