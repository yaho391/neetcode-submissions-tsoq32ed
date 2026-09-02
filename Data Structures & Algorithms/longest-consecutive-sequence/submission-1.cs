public class Solution {
    public int LongestConsecutive(int[] nums)
{
    if (nums.Length == 0)
        return 0;
    HashSet<int> numbers = new HashSet<int>(nums);

    var max = int.MinValue;

    foreach (int num in nums)
    {
        if(numbers.Contains(num - 1))
            continue;
        
        int currentLength = 1;
        int currentNum = num;

        while(numbers.Contains(currentNum + 1))
        {
            currentLength++;
            currentNum++;
        }

        max = Math.Max(max, currentLength);
    }

    return max;
}
}