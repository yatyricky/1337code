public class Solution {
    public int[] RunningSum(int[] nums) {
        var len = nums.Length;
        if (len < 2) {
            return nums;
        }
        var sums = new int[len];
        var prev = nums[0];
        sums[0] = prev;
        for(int i = 1; i< len;i++)
        {
            prev += nums[i];
            sums[i] = prev;
        }
        return sums;
    }
}