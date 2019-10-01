public class Solution {
    public string  LargestNumber(int[] nums) {
        List<string> temp = new List<string>();
        foreach (var i in nums)  
            temp.Add(i.ToString());
        
        temp.Sort((x,y) => {
             long a = long.Parse(x + y);
            long b = long.Parse(y + x);
            if (a < b)
                return 1;
            else if (a > b)
                return -1;
            else return 0;
        });
        string ans = new string("");
        foreach (var s in temp) {
            // Console.WriteLine(s);
            ans = ans + s;
        }

        if (ans[0] == '0')
            return "0";
        return ans;
    }
}