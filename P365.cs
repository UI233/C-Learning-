public class Solution {
    private int GetGcd(int a, int b)
    {
        if (b == 0)
            return a;
        else if (a == 0)
            return b;
        if (a > b)
            return GetGcd(b, a % b);
        else return GetGcd(a, b % a);
    }

    public bool CanMeasureWater(int x, int y, int z) {
        if (x == z || y == z || x + y == z)
            return true;
        if (x + y < z)
            return false;
        else return (z % GetGcd(x,y)) == 0;
    }
}