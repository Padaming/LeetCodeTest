using System;

public class Solution_5LongestPalindromicSubstring
{
    public string LongestPalindrome(string s)
    {
        int indexStart = 0, indexEnd = 0;
        bool find = false;

        if (s.Length == 1)
            return s;

        for(int i = 0; i < s.Length; i++)
        {
            for(int j = i + 1; j < s.Length; j++)
            {
                if(IsPalindrome(s, i, j) && (j - i) > (indexEnd - indexStart))
                {
                    indexStart = i;
                    indexEnd = j;
                    find = true;
                }
            }
        }

        /* No palindrome */
        if (find == false)
            return s[0].ToString();

        return s.Substring(indexStart, indexEnd - indexStart + 1);
    }

    public bool IsPalindrome(string s, int start, int end)
    {
        for(int i = start, j = end; i <= j; i++, j--)
        {
            if (s[i] != s[j])
                return false;
        }
        return true;
    }

    public void TestCase(string s)
    {
        Console.WriteLine(LongestPalindrome(s));
    }

    public void Test()
    {
        TestCase("babad");
        TestCase("cbbd");
    }
}