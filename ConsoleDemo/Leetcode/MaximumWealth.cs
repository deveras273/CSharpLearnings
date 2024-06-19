using System;

public class Solution7
{
    public int MaximumWealth(int[][] accounts)
    {
        var result = int.MinValue;
        var ans = 0;
        var rows = accounts.Length;
        var cols = accounts[0].Length;
        for (int i = 0; i < rows; i++)
        {
            ans = 0;
            for (int j = 0; j < cols; j++)
            {
                ans = ans + accounts[i][j];
            }
            result = Math.Max(result, ans);
        }
        return result;


    }
}
