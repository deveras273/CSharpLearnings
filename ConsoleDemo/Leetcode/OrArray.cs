public class Solution3
{
    public int[] OrArray(int[] nums)
    {
        int n = nums.Length;
        int[] ans = new int[n - 1];
        for (int i = 0; i < n - 1; i++)
        {
            ans[i] = nums[i] | nums[i + 1];
        }

        return ans;
    }
}