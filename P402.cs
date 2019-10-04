public class Solution {
    public string RemoveKdigits(string num, int k) {
        if (num.Length == k)
            return "0";
        int choose = num.Length - k;
        int st = 0;
        string ans = "";

        for (int i = choose; i > 0; --i)
        {
           var min = st;
           if (st + i == num.Length)
           {
                ans = ans + num.Substring(st);
                break;
           }
           for (int j = st; num.Length - j >= i; ++j) 
           {
               if (num[j] < num[min])
                    min = j;
           }
           st = min + 1;
           ans = ans + num[min];
        }

        int first_zero = 0;
        for (; first_zero < ans.Length && ans[first_zero] == '0'; first_zero++);

        if (first_zero == ans.Length)
            return "0";
        else return ans.Substring(first_zero);
    }
}