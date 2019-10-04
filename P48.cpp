class Solution {
public:
    void rotate(vector<vector<int>>& matrix) {
        for (int i = 0; i < matrix.size(); ++i) {
            int n = matrix[i].size();
            for (int j = 0; j <= i && j < n - i - 1; ++j) {
                int a = matrix[i][j];
                int b = matrix[j][n - 1 -i];
                int c = matrix[n - 1 - i][n - 1 - j];
                int d = matrix[n - 1 - j][i];
                matrix[i][j] = d;
                matrix[j][n-1-i] = a;
                matrix[n-1-i][n-1-j] = b;
                matrix[n-1-j][i] = c;
            }
        }
    }
};