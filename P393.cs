public class Solution {
    private bool ValidFollow(int data) {
        if ((data & (3 << 6)) != 128)
            return false;
        else return true;
    }

    private int GetNum(int data) {
        int t = 7;
        while (t > 0 && (data & (1 << t)) != 0)
            t--;
        t = 7 - t;
        return t;
    }

    public bool ValidUtf8(int[] data) {
        int next;
        for (int i = 0; i < data.Length; i = next) {
            int count = GetNum(data[i]);
            //  Console.WriteLine(count);
            if (count > 4)
                return false;
            if (count == 0)
                next = i + 1;
            else if (count != 1){
                if (i + count - 1 >= data.Length)
                    return false;
                for (int j = i + 1; j <= i + count - 1; ++j)
                     if (!ValidFollow(data[j]))
                        return false;
                next = i + count;
            }
            else return false;
        }

        return true;
    }
}