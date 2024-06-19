public class Solution4
{
    public int[] BuildArray(int[] nums)
    {
        int arrLength = nums.Length;
        int[] res = new int[nums.Length];
        for (int i = 0; i < arrLength; i++)
        {
            res[i] = nums[nums[i]];
        }
        return res;
    }
}