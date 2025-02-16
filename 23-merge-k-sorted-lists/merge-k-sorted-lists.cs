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

    public ListNode MergeKLists(ListNode[] lists) {
        ListNode list = null;
        bool check = true;
        for(int i = 0; i < lists.Length; i++)
        {
            if(check)
            {
                if(lists[i]!=null)
                {
                    list = lists[i];
                    check = false;
                }
                
            }
            else
            {
                if(lists[i] != null)
                {
                    ListNode first = null;
                    ListNode second = null;
                    if(list.val < lists[i].val)
                    {
                        first = list;
                        second = lists[i];
                    }
                    else
                    {
                        first = lists[i];
                        second = list;
                    }
                    list = first;
                    ListNode prev = first;
                    first = first.next;
                    while((first!=null)&&(second!=null))
                    {
                        if(first.val <= second.val)
                        {
                            prev = first;
                            first = first.next;
                        }
                        else
                        {
                            prev.next = second;
                            second = first;
                            first = prev.next;
                        }
                    }
                    if((first==null)&&(second!=null))
                    {
                        prev.next = second;
                    }
                }
            }
        }
        return list;
    }
}