using System;

public class Solution_3LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {
        string result = string.Empty;
        string temp = string.Empty;

        if (s.Length == 0)
            return 0;

        foreach(char c in s)
        {
            if (temp == string.Empty)
            {
                temp += c.ToString();
                continue;
            }

            if (temp.Contains(c))
            {
                if(temp.Length > result.Length)
                    result = temp;

                /* string contains c, its length maybe 1 or > 1 */
                if (temp.Last() == c)
                    temp = c.ToString();
                /* string length at least > 1 */
                else
                    temp = string.Concat(temp.AsSpan(temp.IndexOf(c) + 1), c.ToString());
            }
            else
            {
                temp += c.ToString();
            }
        }

        if (temp.Length > result.Length)
            result = temp;

        return result.Length;
    }

    public void TestCase(string s)
    {
        Console.WriteLine(LengthOfLongestSubstring(s));
    }

    public void Test()
    {
        TestCase("dvdf");
        TestCase("");
        TestCase(" ");
        TestCase("au");
        TestCase("abcabcbb");
        TestCase("bbbbb");
        TestCase("pwwkew");
    }
}