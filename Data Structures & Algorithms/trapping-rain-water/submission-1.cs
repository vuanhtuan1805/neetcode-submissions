public class Solution {
    public int Trap(int[] height) {
        int l = 0;
        int r = height.Length - 1;

        int leftMax = height[l];
        int rightMax = height[r];

        int result = 0;
        while (l < r){
            if (leftMax < rightMax){
                l++;
                leftMax = Math.Max(height[l], leftMax);
                result += leftMax - height[l];
            }else {
                r--;
                rightMax = Math.Max(height[r], rightMax);
                result += rightMax - height[r];
            }
        }

        return result;
    }
}
