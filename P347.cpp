class Solution {
public:
    class cmp{
        public:
            bool operator()(const pair<int, int>& a,const pair<int,int>& b) {
                return a.second < b.second;
            }
    };
    vector<int> topKFrequent(vector<int>& nums, int k) {
        unordered_map<int, int> counter;
        for (auto v: nums) {
            if (counter.find(v) == counter.end())
                counter.insert(make_pair(v, 1));
            else counter[v]++;
        }

        priority_queue<pair<int,int>, vector<pair<int,int>>, cmp> pq;

        for (auto pv: counter)
            pq.push(pv);
        vector<int> res;

        for (int i = 0; i < k; ++i) {
            res.push_back(pq.top().first);
            pq.pop();
        }

        return res;
    }
};