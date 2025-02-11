using System;

public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        if (word == word.ToUpper())
        {
            return true;
        }
        if (word == word.ToLower())
        {
            return true;
        }

        if (word[0] == char.ToUpper(word[0]) && word.Substring(1) == word.Substring(1).ToLower())
        {
            return true;
        }

        return false;
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        
        // Testes
        Console.WriteLine(solution.DetectCapitalUse("USA"));   //  true
        Console.WriteLine(solution.DetectCapitalUse("FlaG"));  //  false
    }
}
