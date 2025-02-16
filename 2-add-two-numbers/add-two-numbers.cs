/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int u = 0;
        int x;
        ListNode rez = l1;
        ListNode last = l1;
        while(l1!=null && l2!=null)
        {
            x = l1.val + l2.val + u;
            u = x/10;
            l1.val = x % 10;
            last = l1;
            l1 = l1.next;
            l2 = l2.next;
        }
        if (l1 == null && l2 != null)
        {
            last.next = l2;
            l1=last.next;
        } 
        while (l1 != null)
        {
            x = l1.val + u;
            u = x / 10;
            l1.val = x % 10;
            last = l1;
            l1 = l1.next;
        }
        if (u == 1)
        {
            ListNode newnode = new ListNode(1);
            last.next = newnode;
        }
        return rez;
    }
}