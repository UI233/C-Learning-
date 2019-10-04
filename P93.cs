public class Solution {
    private bool judge(int num, string s) {
        if (num.ToString() != s)
            return false;
        return num >= 0 && num <= 255;
    }
    public IList<string> RestoreIpAddresses(string s) {
        List<string> res = new List<string>();
        for (int st0 = 0; st0 <= 0; st0++)                                                                                                                                                                                                          
            for (int st1 = st0 + 1; st1 < s.Length && st1 < st0 + 4; st1++)                                                                                                                                                                                                          
                for (int st2 = st1 + 1; st2 < s.Length && st2 < st1 + 4; st2++)                                                                                                                                                                                                          
                    for (int st3 = st2 + 1; st3 < s.Length && st3 < st2 + 4; st3++) {
                        int len0 = st1 - st0, len1 = st2 - st1,  len2 = st3 - st2, len3 = s.Length - st3;
                        if (len3 >= 4)
                            continue;
                        string s0 = s.Substring(st0, len0);
                        string s1 = s.Substring(st1, len1);
                        string s2 = s.Substring(st2, len2);
                        string s3 = s.Substring(st3, len3);

                        int num0 = int.Parse(s0);
                        int num1 = int.Parse(s1);
                        int num2 = int.Parse(s2);
                        int num3 = int.Parse(s3);

                        if (judge(num0, s0) && judge(num1, s1) && judge(num2, s2) && judge(num3, s3))
                            res.Add(num0.ToString() + "." + num1.ToString() + "." + num2.ToString() + "." + num3.ToString());
                    }
        return res;
    }
}