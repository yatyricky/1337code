public class Solution {
    private static readonly string[] results = new string[]{"Fizz","Buzz","FizzBuzz"};
    
    public IList<string> FizzBuzz(int n) {
        string[] ret = new string[n];
        for(int i=1;i<=n;i++){
            int i_ = i-1;
            if(i%15==0){
                ret[i_]=results[2];
            }else if (i%5==0){
                ret[i_]=results[1];
            }else if (i%3==0){
                ret[i_]=results[0];
            }else{
                ret[i_] = i.ToString();
            }
        }
        return ret;
        
    }
}