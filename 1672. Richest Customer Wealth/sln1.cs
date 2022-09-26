public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int max = 0;
        for(int i=0;i<accounts.Length;i++)
        {
            int sum = 0;
            int[] arr=accounts[i];
            for(int j=0;j<arr.Length;j++)
            {
                sum+=arr[j];
            }
            if (sum > max)
            {
                max = sum;
            }
        }
        
        return max;
    }
}