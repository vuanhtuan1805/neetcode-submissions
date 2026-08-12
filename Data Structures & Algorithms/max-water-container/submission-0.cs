public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0;
        int r = heights.Length - 1;

        int result = 0;
        while(l < r){
            int tmp = (r - l) * Math.Min(heights[r], heights[l]);

            if (tmp > result){
                result = tmp;
            }

            if (heights[l] < heights[r]){
                l++;
            }else{
                r--;
            }
        }

        return result;
    }
}
