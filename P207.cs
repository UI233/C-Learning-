public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Queue q = new Queue();
        int[] ind = new int[numCourses];
        List<int>[] edges = new List<int>[numCourses];
        
        
        for (var i = 0; i < numCourses; ++i) {
            ind[i] = 0;
            edges[i] = new List<int>();
        }
        
        for (int i = 0; i < prerequisites.Length; ++i) {
            int v0 = prerequisites[i][0];
            int v1 = prerequisites[i][1];
            
            edges[v1].Add(v0);
            ind[v0]++;
        }
        
        int sz = 0;
        for (int i = 0; i < numCourses; ++i)
            if (ind[i] == 0) {
                q.Enqueue(i);
                sz++;
            }
        
        int count = 0;
        while (sz != 0) {
            int v = (int)q.Dequeue();
            sz--;
            count++;
            foreach (var u in edges[v]) {
                ind[u]--;
                if (ind[u] == 0) {
                    q.Enqueue(u);
                    sz++;
                }
            } 
        }
        return count == numCourses;
    }
}