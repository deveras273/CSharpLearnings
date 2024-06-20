using System.Collections.Generic;
using System;

public class Solution9
{
    public bool IsPalindrome(string s)
    {
        var result = true;
        var stringLength = s.Length;
        var listResult = new List<char>();
        for (int i = 0; i < stringLength; i++)
        {
            if (char.IsLetterOrDigit(s[i]))
            {
                listResult.Add(Char.ToLower(s[i]));
            }

        }
        var processedString = String.Join("", listResult);
        var start = 0;
        var end = processedString.Length - 1;
        while (start < end)
        {
            if (processedString[start] == processedString[end])
            {
                start = start + 1;
                end = end - 1;
            }
            else
            {
                return false;
            }
        }
        return result;
    }
}