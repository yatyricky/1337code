public class Solution {
    public int NumberOfSteps(int num) {
        if (num == 0) return 0;
        int len = (int)(Math.Log(num, 2));
        int count=0;
        while(num!=0){
          num = num&(num-1);
          count++;
        }
        return len+count;
    }
}