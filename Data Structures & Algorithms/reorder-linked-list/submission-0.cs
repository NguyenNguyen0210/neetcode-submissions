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
    public void ReorderList(ListNode head) {
        if (head == null) return;
        List<ListNode> stored = new();
        ListNode tail = head;
        int l = 0;
        while(tail != null){
            stored.Add(tail);
            tail = tail.next;
        }
        int r = stored.Count - 1;

        while(l<r){
            stored[l].next = stored[r];
            l++;
            if(r == l) break;
            stored[r].next = stored[l];
            r--;
        }
        stored[l].next = null;
    }
}
