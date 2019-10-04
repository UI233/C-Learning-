#include <cstring>

class Solution {
private:
    bool vis[1000][1000];
    void dfs(int x, int y, const vector<vector<char>>& grid) {
        int xbound = grid.size(), ybound = grid[0].size();
        if (x < 0 || x >= xbound || y < 0 || y >= ybound)
            return ;
        if (vis[x][y] || grid[x][y] == '0')
            return ;
        vis[x][y] = true;
        for (int i = -1; i <= 1; i += 2) {
                dfs(x + i, y, grid);
                dfs(x, y + i, grid);
        }
    }
public:
    int numIslands(vector<vector<char>>& grid) {
        if (grid.size() == 0)
            return 0;
        int xbound = grid.size(), ybound = grid[0].size();
        for(int i = 0; i < xbound; ++i) {
            for (int j = 0; j < ybound; ++j)
                vis[i][j] = false;
        }
        
        int ans = 0;
        for (int i = 0; i < xbound; ++i)
            for (int j = 0; j < ybound; ++j) 
                if (!vis[i][j] && grid[i][j] == '1') {
                    ++ans;
                    dfs(i,j, grid);
                }
        return ans;
    }
};