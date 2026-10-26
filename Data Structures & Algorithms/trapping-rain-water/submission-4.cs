public class Solution
{
    public int Trap(int[] height)
    {
        int l = 0;
        int r = height.Length - 1;

        int lmax = 0;
        int rmax = 0;
        int sum = 0;

        while (l < r)
        {
            lmax = Math.Max(lmax, height[l]);
            rmax = Math.Max(rmax, height[r]);

            if (lmax <= rmax)
            {
                sum += lmax - height[l];
                l++;
            }
            else
            {
                sum += rmax - height[r];
                r--;
            }
        }

        return sum;
    }
}
