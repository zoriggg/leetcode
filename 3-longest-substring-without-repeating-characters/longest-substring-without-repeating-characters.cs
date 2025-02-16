public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length == 1) return 1;
        else
        {
            int x = 0;
            int maxx = 0;
            string l = "";
            int j = 0;
            for(var i = 0; i < s.Length; i++)
            {
                if(l.Contains(s[i]))
                {
                    if(x > maxx) maxx = x;
                    l = "";
                    x = 0;
                    i = ++j;
                }
                x++;
                l = l + s[i];
            }
            if(x > maxx) return x; else return maxx;
        }
    }
}