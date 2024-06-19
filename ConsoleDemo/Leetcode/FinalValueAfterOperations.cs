public class Solution5
{
    public int FinalValueAfterOperations(string[] operations)
    {
        int value = 0;
        foreach (string operation in operations)
        {
            if (operation == "X++" || operation == "++X")
            {
                value += 1;
            }
            else
            {
                value -= 1;
            }
        }
        return value;
    }
}