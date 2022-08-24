public class Solution_22GenerateParentheses
{
    List<string> result;

    public IList<string> GenerateParenthesis(int n)
    {
        result = new List<string>();

        if(n == 1)
        {
            result.Add("()");
            return result;
        }

        Run(n, "", 0, 0, '(');

        return result;
    }

    public void Run(int n, string prefix, int numOfLeft, int numOfRight, char next)
    {
        if (next == ')' && (numOfLeft + numOfRight) == (n * 2))
        {
            result.Add(prefix);
            return;
        }

        if(numOfLeft < n)
            Run(n, prefix + '('.ToString(), numOfLeft + 1, numOfRight, '(');
        if(numOfLeft > numOfRight && numOfRight < n)
            Run(n, prefix + ')'.ToString(), numOfLeft, numOfRight + 1, ')');
    }

    public void TestCase(int n)
    {
        Console.WriteLine($"Case : [{n}]");
        GenerateParenthesis(n);
        foreach (string s in result)
            Console.WriteLine(s);
    }

    public void Test()
    {
        TestCase(1);
        TestCase(3);
        TestCase(4);
        TestCase(5);
    }
}