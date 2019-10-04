#include <deque>

class Solution {
public:
    int largestRectangleArea(vector<int>& heights) {
        int ans = 0;
        deque<int> temp;
        vector<int> pos, posl;
        pos.resize(heights.size());
        posl.resize(heights.size());
        // from left 2 right
        for (int i = 0; i < heights.size(); ++i) {
            pos[i] = i;
            if (temp.empty() || heights[temp.back()] < heights[i])
                temp.push_back(i);
            else {
                int st = i;
                while (!temp.empty() && heights[i] < heights[temp.back()]) {
                    st = temp.back();
                    temp.pop_back();
                }

                if (!temp.empty() && heights[i] == heights[temp.back()])
                    st = temp.back();
                else temp.push_back(i);
                pos[i] = std::min(pos[i], pos[st]);
            }
        }

        temp.clear();
        // from right 2 left
        for (int i = heights.size() - 1; i >= 0; --i) {
            posl[i] = i;
            int st;
            if (temp.empty() || heights[temp.back()] < heights[i])
                temp.push_back(i);
            else {
                while (!temp.empty() && heights[i] < heights[temp.back()]) {
                    st = temp.back();
                    temp.pop_back();
                }
                if (!temp.empty() && heights[i] == heights[temp.back()])
                    st = temp.back();
                else temp.push_back(i);
                posl[i] = std::max(posl[i], posl[st]);
            }
            ans = std::max(ans, heights[i] * (posl[i] - pos[i] + 1));
        }

        return ans;
    }
};