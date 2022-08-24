public class Solution_7ReverseInteger
{
    public int Reverse(int x)
    {
        int result = 0;
        int baseNum;
        int digit;
        bool isLeadingZero = true;
        bool isPositiveNumber = true;

        if(x == 0)
            return 0;

        if(x < 0)
        {
            isPositiveNumber = false;
            x = x * -1;
        }

        while(x > 0)
        {
            digit = x % 10;
            if(digit == 0 && isLeadingZero)
            {

            }
            else
            {
                isLeadingZero = false;
                baseNum = result;

                for(int i = 0; i < 9 && baseNum > 0; i++)
                {
                    /* Overflow */
                    if (int.MaxValue - result < baseNum)
                        return 0;
                    result += baseNum;
                }

                /* Overflow */
                if (isPositiveNumber == false && (result * -1 - int.MinValue < digit) && result > 0)
                    return 0;
                else if (isPositiveNumber == true && (int.MaxValue - result < digit))
                    return 0;

                /* 10 * baseNum + digit */
                result += digit;
            }

            x = x / 10;
        }

        if (isPositiveNumber == false)
            result *= -1;

        return result;
    }

    public void TestCase(int x)
    {
        Console.WriteLine($"Input:{x}   Output:{Reverse(x)}");
    }

    public void Test()
    {
        TestCase(1230099);
        TestCase(2147438639);
        TestCase(0);
        TestCase(-2147438639);
        TestCase(-1);
        TestCase(-128500000);
    }
}