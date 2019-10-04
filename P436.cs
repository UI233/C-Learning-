class Solution {
public:
    vector<int> findRightInterval(vector<vector<int>>& intervals) {
        vector<int> ans;
        vector<int> l1, l2;
        l1.resize(intervals.size());
        l2.resize(intervals.size());
        ans.resize(intervals.size());

        for (int i = 0; i < intervals.size(); ++i) {
            l1[i] = i;
            l2[i] = i;
        }

        auto cmp1 = [&intervals](const int &a, const int &b) {
            return intervals[a][1] < intervals[b][1];
        };
        auto cmp2 = [&intervals](const int &a, const int &b) {
            return intervals[a][0] < intervals[b][0];
        };

        sort(l1.begin(), l1.end(), cmp1);
        sort(l2.begin(), l2.end(), cmp2);
        int ptr = 0;
        for (int i = 0; i < intervals.size(); ++i) {
            if (ptr >= intervals.size())
                ans[l1[i]] = -1;
            else {
                while (ptr < intervals.size() && intervals[l1[i]][1] > intervals[l2[ptr]][0])
                    ++ptr;
                if (ptr >= intervals.size())
                    ans[l1[i]] = -1;
                else ans[l1[i]] = l2[ptr];
            }
        }

        return ans;
    }
};