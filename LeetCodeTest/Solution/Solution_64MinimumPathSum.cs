﻿using System;

public class Solution_64MinimumPathSum
{
    public int MinPathSum(int[][] grid)
    {
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if (i == 0 && j == 0)
                    continue;

                if (i == 0)
                    grid[i][j] += grid[i][j - 1];
                else if (j == 0)
                    grid[i][j] += grid[i - 1][j];
                else
                    grid[i][j] += grid[i - 1][j] < grid[i][j - 1] ? grid[i - 1][j] : grid[i][j - 1];
            }
        }

        return grid[grid.Length - 1][grid[0].Length - 1];
    }

    public void TestCase(int[][] grid)
    {
        Console.WriteLine(MinPathSum(grid));
    }

    public void Test()
    {
        TestCase(new int[][] { new int[] { 1, 2, 5 }, new int[] { 3, 2, 1 } });
        TestCase(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } });
        TestCase(new int[][] { new int[] { 1, 3, 1 }, new int[] { 1, 5, 1 }, new int[] { 4, 2, 1 } });
        TestCase(new int[][] {
            new int[]{ 3, 8, 6, 0, 5, 9, 9, 6, 3, 4, 0, 5, 7, 3, 9, 3 },
            new int[]{ 8,2,2,3,3,3,1,6,9,1,1,6,6,2,1,9 },
            new int[]{ 1,3,6,9,9,5,0,3,4,9,1,0,9,6,2,7 },
            new int[]{8,6,2,2,1,3,0,0,7,2,7,5,4,8,4,8 },
            new int[]{ 4,1,9,5,8,9,9,2,0,2,5,1,8,7,0,9 },
            new int[]{ 6,2,1,7,8,1,8,5,5,7,0,2,5,7,2,1 },
            new int[]{ 8,1,7,6,2,8,1,2,2,6,4,0,5,4,1,3 },
            new int[]{ 9,2,1,7,6,1,4,3,8,6,5,5,3,9,7,3 },
            new int[]{ 0,6,0,2,4,3,7,6,1,3,8,6,9,0,0,8 },
            new int[]{ 4,3,7,2,4,3,6,4,0,3,9,5,3,6,9,3 },
            new int[]{ 2,1,8,8,4,5,6,5,8,7,3,7,7,5,8,3 },
            new int[]{ 0,7,6,6,1,2,0,3,5,0,8,0,8,7,4,3 },
            new int[]{ 0,4,3,4,9,0,1,9,7,7,8,6,4,6,9,5 },
            new int[]{ 6,5,1,9,9,2,2,7,4,2,7,2,2,3,7,2 },
            new int[]{ 7,1,9,6,1,2,7,0,9,6,6,4,4,5,1,0 },
            new int[]{ 3,4,9,2,8,3,1,2,6,9,7,0,2,4,2,0 },
            new int[]{ 5,1,8,8,4,6,8,5,2,4,1,6,2,2,9,7 },
        });
    }
}