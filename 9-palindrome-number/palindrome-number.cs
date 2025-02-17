public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0)
        {
            return false;
        }
        else
        {
            int y = x;
            int r = 0;
            while(y > 0)
            {
                r = r*10 + y%10;
                y = y/10;
            }
            if(r==x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}