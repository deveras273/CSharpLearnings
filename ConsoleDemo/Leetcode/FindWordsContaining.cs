using System.Collections.Generic;

public class Solution6
{
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        var result = new List<int>();
        var arrLength = words.Length;
        for (int i = 0; i < arrLength; i++)
        {
            var wordToTraverse = words[i];
            var wordToLength = wordToTraverse.Length;
            for (int j = 0; j < wordToLength; j++)
            {
                if (wordToTraverse[j] == x)
                {
                    result.Add(i);
                    break;
                }
            }
        }
        return result;
    }
}