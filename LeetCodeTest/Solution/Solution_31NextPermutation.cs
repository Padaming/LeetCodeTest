public class Solution_31NextPermutation
{
    public void NextPermutation(int[] nums)
    {
        int temp;
        int index = nums.Length - 1;
        bool IsReverse = false;

        if(nums.Length == 1)
        {
            return;
        }

        if(nums.Length == 2)
        {
            temp = nums[1];
            nums[1] = nums[0];
            nums[0] = temp;
            return;
        }

        /* Find largest from right until its next is smaller*/
        for(int i = nums.Length - 1; i > 0; i--)
        {
            // find larger
            if (nums[i] <= nums[i - 1])
            {
                IsReverse = true;
                continue;
            }
            // find next is smaller
            else if (nums[i] > nums[i - 1])
            {
                index = i;
                IsReverse = false;
                break;
            }
        }

        /* Special case: current array have no next permutation, jus reverse array */
        if(IsReverse)
        {
            Array.Reverse(nums);
            return;
        }

        /* Find the element which is just smaller than nums[index-1] from index + 1 ~ n - 1 */
        int bigger = index;
        for(int i = index + 1; i <= nums.Length - 1; i++)
        {
            if(nums[i] > nums[index - 1])
            {
                if (bigger == index)
                    bigger = i;
                /* Find any index that just bigger than nums[index -1] */
                else if (nums[bigger] > nums[i])
                    bigger = i;
            }
        }

        /* If we does not find any bigger value, we will swap the nums[index -1] and nums[bigger](nums[index]) */
        /* Now we need to swap num[index] and num[bigger] */
        temp = nums[index - 1];
        nums[index - 1] = nums[bigger];
        nums[bigger] = temp;

        /* Sort from index ~ n -1 in ascending order */
        Array.Sort(nums, index, nums.Length - index);
    }

    public void TestCase(int[] nums)
    {
        NextPermutation(nums);
        foreach (int i in nums)
            Console.Write($"{i} ");
        Console.WriteLine();
    }

    public void Test()
    {
        TestCase(new int[] { 3, 2, 1 });
        TestCase(new int[] { 1, 2, 3 });
        TestCase(new int[] { 1, 3, 2 });
        TestCase(new int[] {1, 2, 3, 4});
        TestCase(new int[] { 1, 2, 3, 5, 8, 7, 4, 2, 1 });
        TestCase(new int[] { 1, 2, 5, 3, 8, 7, 4, 2, 1 });
    }
}