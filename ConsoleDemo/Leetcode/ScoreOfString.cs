using System;

public class Solution8
{
    public int ScoreOfString(string s)
    {
        var stringLength = s.Length;
        var result = 0;
        for (int i = 1; i < stringLength; i++)
        {
            result = result + Math.Abs((int)(s[i] - s[i - 1]));
        }
        return result;
    }
}