using System;

public class Solution_63UniqePathII
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        int m = obstacleGrid.Length;
        int n = obstacleGrid[0].Length;
        int[,] grid = new int[m,n];

        if (obstacleGrid[0][0] == 1)
            return 0;

        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if (obstacleGrid[i][j] == 1)
                    grid[i, j] = 0;
                else if (i == 0 && j == 0)
                    grid[i, j] = 1;
                else if (i == 0)
                    grid[i, j] = grid[i, j - 1] > 0 ? 1 : 0;
                else if (j == 0)
                    grid[i, j] = grid[i - 1, j] > 0 ? 1 : 0;
                else
                    grid[i, j] = grid[i - 1, j] + grid[i, j - 1];
            }
        }

        return grid[m - 1, n - 1];
    }

    public void TestCase(int[][] obstacleGrid)
    {
        Console.WriteLine(UniquePathsWithObstacles(obstacleGrid));
    }

    public void Test()
    {
        TestCase(new int[][] { new int[] { 0, 1 }, new int[] { 0, 0 } });
        TestCase(new int[][] { new int[] { 0, 0 }, new int[] { 1, 1 }, new int[] { 0, 0 } });
        TestCase(new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 0, 0, 0 } });
    }
}