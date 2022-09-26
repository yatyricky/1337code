public class Solution {
    public int[] RunningSum(int[] nums) {
        var len = nums.Length;
        var sums = new int[len];
        for(int i = 0; i< len;i++)
        {
            if (i==0){
                sums[i] = nums[i];
            }else{
                sums[i] = nums[i]+sums[i-1];
            }
            
        }
        return sums;
    }
}