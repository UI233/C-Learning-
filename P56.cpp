class Solution {
public:
    vector<vector<int>> merge(vector<vector<int>>& intervals) {
        auto cmp = [](vector<int> a, vector<int> b) {
            return a[0] == b[0] ? a[1] < b[1] : a[0] < b[0];
        };
        sort(intervals.begin(), intervals.end(), cmp);
        vector<vector<int>> res;
        for (int i = 0; i < intervals.size();) {
            int init = i;
            vector<int> temp;
            temp.resize(2);
            temp[0] = intervals[i][0];
            temp[1] = intervals[i][1];
            for (; i < intervals.size() && intervals[i][0] <= temp[1]; ++i) {
                temp[1] = max(temp[1], intervals[i][1]);
            }
            res.push_back(temp);
        }

        return res;
    }
};