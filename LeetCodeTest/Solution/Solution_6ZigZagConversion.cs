public class Solution_6ZigZagConversion
{
    public string Convert(string s, int numRows)
    {
        string result = string.Empty;

        if (s.Length <= numRows || numRows == 1)
            return s;

        int nexthop = 0;
        int middleRowHop = 0;
        result += s[0].ToString();
        for (int i = 0; i < numRows; i++)
        {
            while(nexthop < s.Length)
            {
                /* Fist row and Last row */
                if(i == 0 || i == numRows - 1)
                {
                    nexthop = nexthop + 2 * (numRows - 1);
                    if(nexthop < s.Length)
                    {
                        result += s[nexthop].ToString();
                    }
                }
                /* Middle rows */
                else
                {
                    /* 1st type hop */
                    if (middleRowHop == 0)
                    {
                        nexthop = nexthop + (numRows - i - 1) * 2;
                        middleRowHop = 1;
                    }
                    /* 2nd type hop, it jus after 1st type hop */
                    else
                    {
                        nexthop = nexthop + i * 2;
                        middleRowHop = 0;
                    }

                    if (nexthop < s.Length)
                    {
                        result += s[nexthop].ToString();
                    }
                }
            }

            if (i != numRows - 1)
            {
                nexthop = i + 1;
                result += s[nexthop].ToString();
                middleRowHop = 0;
            }
        }

        return result;
    }

    public void TestCase(string s, int numRows)
    {
        Console.WriteLine(Convert(s, numRows));
    }

    public void Test()
    {
        TestCase("PAYPALISHIRING", 3);
        TestCase("PAYPALISHIRING", 4);
    }
}
