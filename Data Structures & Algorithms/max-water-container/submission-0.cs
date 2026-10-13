public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0, r = heights.Length - 1;
        int square = 0; 
        while (l < r){
            int width = r - l;
            int height = Math.Min(heights[l], heights[r]);
            int curArea = height * width;

            square = Math.Max(square, curArea);

            if(heights[l] <= heights[r]) l++; 
            else r--; 
        }
        return square;
    }
}
