// E https://leetcode.com/problems/linked-list-cycle

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if (head == null)
            return false;
        
        var fast = head;
        var slow = head;
        
        while (true) {
            if (fast.next == null)
                return false;
            fast = fast.next.next;
            if (fast == null)
                return false;
            slow = slow.next;
            if (fast == slow)
                return true;
        }
        return false;
    }
}