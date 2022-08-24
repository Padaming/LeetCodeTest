public class Solution_17LetterCombination
{
    List<string> result;
    Dictionary<char, string> map = new Dictionary<char, string>{
        {'2', "abc"},
        {'3', "def"},
        {'4', "ghi"},
        {'5', "jkl"},
        {'6', "mno"},
        {'7', "pqrs"},
        {'8', "tuv"},
        {'9', "wxyz"},
    };

    public IList<string> LetterCombinations(string digits)
    {
        result = new List<string>();

        if (digits.Length == 0)
            return result;

        Queue<string> temp = new Queue<string>();
        Queue<string> prev = new Queue<string>();
        foreach (char c in digits)
        {
            if (prev.Count == 0)
            {
                Console.WriteLine($@"Enqueue {c}:{map[c]}");
                foreach (char i in map[c])
                    temp.Enqueue(i.ToString());
            }
            else
            {
                Console.WriteLine($@">1 {c}:{map[c]}");
                while (prev.Count > 0)
                {
                    string s = prev.Dequeue();
                    foreach (char i in map[c])
                        temp.Enqueue(s + i.ToString());
                }
            }

            while (temp.Count > 0)
                prev.Enqueue(temp.Dequeue());
            Console.WriteLine($@"prev [{string.Join(' ', prev)}]");
        }

        for (int t = 0; t < prev.Count; t++)
            result.Add(prev.Dequeue());

        return result;
    }
}
