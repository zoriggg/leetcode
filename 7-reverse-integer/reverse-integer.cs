public class Solution {
    public int Reverse(int x) {
        int y = 0;
        if(x >= 0)
        {
            y = x;
        } 
        else 
        {
            y = x * -1;
        }
        int r = 0;
        while (y > 0)
        {
            r = r*10 + y % 10;
            y = y / 10;
            if((r > 214748364)&&(y>0)) return 0;
        }
        if(x >= 0)
        {
            if (x > 2147483648) return 0; else return r;
        } 
        else 
        {
            if (x < -2147483648) return 0; else return r * -1;
        }
    }
}