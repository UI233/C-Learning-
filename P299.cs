public class Solution {
    public string GetHint(string secret, string guess) {
        int[] cntg = new int[10]{0,0,0,0,0,0,0,0,0,0};
        int[] cnts = new int[10]{0,0,0,0,0,0,0,0,0,0};
        int A = 0, B = 0;
        for (int i = 0; i < secret.Length; ++i) 
        {
            if (secret[i] == guess[i])
                A++;
            else {
                cnts[int.Parse(secret[i].ToString())]++;
                cntg[int.Parse(guess[i].ToString())]++;
            }
        }
        
        for (int i = 0; i < 10; ++i)
            B = B + (cnts[i] >  cntg[i] ? cntg[i] : cnts[i]);

        
        return string.Format("{0}A{1}B",A,B);
    }
}