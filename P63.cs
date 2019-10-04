public class Solution {
    private int[,] ans;
    public int Dp(int i, int j, ref int[][] grid) {
        if (i < 0 || j < 0 || grid[i][j] == 1)
            return 0;
        if (ans[i,j] == -1)
            ans[i,j] = Dp(i - 1, j,  ref grid) + Dp(i, j - 1, ref grid);
        return ans[i,j];
    }

    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        if (obstacleGrid.Length == 0)
            return 0;
        ans = new int[obstacleGrid.Length, obstacleGrid[0].Length];
        for(int i = 0; i < obstacleGrid.Length; ++i)
            for (int j = 0; j < obstacleGrid[i].Length; ++j)
                ans[i,j] = -1;
        ans[0,0] = 1;
        return Dp(obstacleGrid.Length - 1, obstacleGrid[0].Length - 1, ref obstacleGrid);
    }
}