public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        var output = new int[n];
        for(int i = 0; i < n; i++)
        {
            int multiplyNum = 1;
            for(int j = 0; j < n; j++)
            {
                if(i != j)
                {
                    multiplyNum *= nums[j];
                }
            }
            output[i] = multiplyNum;
        }
        return output;
    }
}
