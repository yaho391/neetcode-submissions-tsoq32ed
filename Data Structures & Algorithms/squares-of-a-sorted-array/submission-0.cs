public class Solution {
    public int[] SortedSquares(int[] nums) {
        var squares = new int[nums.Length];
        var left = 0;
        var right = nums.Length-1;
        var pos = nums.Length-1;

        while(left<=right)
        {
            if(Math.Abs(nums[left]) > Math.Abs(nums[right]))
            {
                squares[pos] = nums[left] * nums[left];
                pos--;
                left++;
            }
            else
            {
                squares[pos] = nums[right] * nums[right];
                pos--;
                right--;
            }
        }
        return squares;
    }
}