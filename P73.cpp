class Solution {
public:
    void setZeroes(vector<vector<int>>& matrix) {
        const int mark = -32323232;
        if (matrix.size() == 0)
            return ;
        for (int i = 0; i < matrix.size(); ++i)
            for (int j = 0; j < matrix[0].size(); ++j)
                if (matrix[i][j] == 0)
                {
                    for (int j = 0; j < matrix[0].size(); ++j) 
                        matrix[i][j] = (matrix[i][j] == 0 ? 0 : mark);
                    for (int i = 0; i < matrix.size(); ++i) 
                        matrix[i][j] = (matrix[i][j] == 0 ? 0 : mark);
                    // cout << i << " " << j << endl;
                }
        for (int i = 0; i < matrix.size(); ++i)
            for (int j = 0; j < matrix[0].size(); ++j)
                if (matrix[i][j] == mark)
                    matrix[i][j] = 0;
    }
};