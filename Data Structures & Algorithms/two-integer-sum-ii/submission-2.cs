public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var left = 0;
        var right = numbers.Length - 1;

        while(left < right)
        {
            if(numbers[left] + numbers[right] == target)
            {
                return new int[] { left + 1, right + 1 };
            }

            if(numbers[left] + numbers[right] > target)
            {
                right--;
            }

            if(numbers[left] + numbers[right] < target)
            {
                left++;
            }
        }
        return new int[] { 0, 0 };
    }
}
