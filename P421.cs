public class Solution {
    public int FindMaximumXOR(int[] nums) {
        Hashtable tb = new Hashtable();
        int res = 0;
        int mask = 0;
        for (int i = 30; i >= 0; --i)
        {
            mask |= 1 << i;
            tb.Clear();

            foreach (var num in nums)
                if (!tb.ContainsKey(num & mask))
                    tb.Add(num & mask, 0);
            
            foreach (var num in nums)
            {
                if (tb.ContainsKey((num & mask) ^ (res | (1 << i))))
                {
                    res |= 1 << i;
                    break;
                }
            }
        }

        return res;
    }
}