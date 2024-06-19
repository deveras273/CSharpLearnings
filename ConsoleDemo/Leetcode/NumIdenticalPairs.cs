public class Solution6
{
    public int NumIdenticalPairs(int[] nums)
    {
        int n = nums.Length;
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (nums[i] == nums[j])
                {
                    count += 1;
                }
            }
        }
        return count;
    }
}