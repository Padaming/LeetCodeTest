public class Solution_38CountAndSay
{
    static List<string> s = new List<string>();
    public string CountAndSay(int n)
    {
        if (n == 1)
            return "1";

        char prev = ' ';
        int count = 0;
        string result = string.Empty;

        if(s.Count < n - 1)
            

        foreach(char c in CountAndSay(n - 1))
        {
            if(c == prev && prev != ' ')
            {
                count++;
            }
            else if (c != prev && prev != ' ')
            {
                result += count.ToString() + prev.ToString();
                count = 1;
                prev = c;
            }
            else
            {
                count = 1;
                prev = c;
            }
        }
        result += count.ToString() + prev.ToString();

        return result;

    }

    public void TestCase(int n)
    {
        Console.WriteLine(CountAndSay(n));
    }

    public void Test()
    {
        TestCase(3);
        TestCase(4);
        TestCase(5);
        TestCase(30);
    }
}
