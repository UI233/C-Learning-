public class Solution {
	public IList<int> MajorityElement(int[] nums) {
		int? cand1 = null, cand2 = null;
		int count1 = 0, count2 = 0;
		foreach (var v in nums) {
			if (count1 == 0 && cand2 != v) {
				cand1 = v;
				count1++;
			}
			else if (count2 == 0 && cand1 != v) {
				cand2 = v;
				count2++;
			}
			else {
				if (v == cand2)
					count2++;
			else if (v != cand1)
					count2--;

			if (v == cand1)
				count1++;
			else if (v != cand2) 
				count1--;
			}
		} 

		count1 = 0;
		count2 = 0;
		foreach (var v in nums) {
			if (v == cand1)
				count1++;
			if (v == cand2)
				count2++;
		}

		IList<int> ans = new List<int>();
		if (count1 > nums.Length / 3)
			ans.Add(cand1 ?? 0);
		if (count2 > nums.Length / 3)
			ans.Add(cand2 ?? 0);
		return ans;
	}
}
