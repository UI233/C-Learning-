public class Solution {
	public int HIndex(int[] citations) {
		Array.Sort(citations);
		Array.Reverse(citations);
		int count = 0;
		int h = 0;
		int last = -1;
							            
		foreach (var v in citations)
		{
			count++;
			if (count >= v)
				h = (h > v ? h : v); 
			else {
				h = (h > count ? h : count);
			}
			last = v;
		}
			
		return h;
	}
}
