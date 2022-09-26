
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        int c = 1;
        ListNode ret = head;
        head = head.next;
        while(head!=null){
            c++;
            if(c%2==0) ret=ret.next;
            head = head.next;
        }
        return ret;
    }
}