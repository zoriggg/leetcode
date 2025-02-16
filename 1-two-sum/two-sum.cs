public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        int len = nums.Length;
        int[] rez = {0,0};
        for(int i=0; i<len; i++)
        {
            for(int j=0; j<len; j++)
            {
                if ((nums[i] + nums[j] == target) && (i!=j))
                {
                    rez[0] = i;
                    rez[1] = j;
                    return rez;
                }
            }
        }
        return rez;
    }
}