public class Solution_33SearchInRotatedSortedArray
{
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int index;

        if(nums.Length == 1)
        {
            return nums[0] == target ? 0 : -1;
        }
        else if(nums.Length == 2)
        {
            if (nums[0] == target) return 0;
            else if(nums[1] == target) return 1;
            else return -1;
        }

        while (left <= right)
        {
            index = (left + right) / 2;

            if (nums[index] == target)
            {
                return index;
            }

            if(nums[index] >= nums[left])
            {
                if (target >= nums[left] && target < nums[index])
                    right = index - 1;
                else
                    left = index + 1;
            }
            else
            {
                if (target > nums[index] && target <= nums[right])
                    left = index + 1;
                else
                    right = index - 1;
            }
        }

        return -1;
    }

    public void TestCase(int[] nums, int target)
    {
        Console.WriteLine(Search(nums, target));
    }

    public void Test()
    {
        TestCase(new int[] { 5,1,2,3,4 }, 1);
        TestCase(new int[] { 3, 1 }, 1);
        TestCase(new int[] { 3, 1, 2 }, 1);
        TestCase(new int[] { 5, 6, 7, 0, 1, 2, 3, 4 }, 8);
        TestCase(new int[] { 5, 6, 7, 0, 1, 2, 3, 4 }, 7);
        TestCase(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0);
        TestCase(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3);
        TestCase(new int[] { 1 }, 0);
    }
}
