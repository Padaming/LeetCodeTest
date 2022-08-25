using System;

public class Solution_62UniqePath
{
    public int UniquePaths(int m, int n)
    {
        int[,] grid = new int[m,n]; 


        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if (i == 0 || j == 0)
                    grid[i, j] = 1;
                else
                    grid[i, j] = grid[i - 1,j] + grid[i, j - 1];
            }
        }

        return grid[m - 1, n - 1];
    }

    public void TestCase(int m, int n)
    {
        Console.WriteLine(UniquePaths(m,n));
    }

    public void Test()
    {
        TestCase(3,2);
        TestCase(3,7);
    }
}