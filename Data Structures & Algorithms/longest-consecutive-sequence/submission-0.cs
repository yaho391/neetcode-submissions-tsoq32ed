public class Solution {
    public int LongestConsecutive(int[] nums)
{
    if (nums.Length == 0)
        return 0;

    Array.Sort(nums);

    int current = 1;
    int max = 1;

    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] == nums[i - 1])
        {
            continue;
        }
        else if (nums[i]-1 == nums[i - 1])
        {
            current++;
        }
        else
        {
            current = 1;
        }

        if (current > max)
        {
            max = current;
        }
    }

    return max;
}
}
