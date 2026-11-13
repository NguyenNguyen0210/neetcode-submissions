public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // 1. Đảo ngược danh sách lần 1
        ListNode firstReverse = ReverseList(head);

        // 2. Gắn dummy node đứng trước firstReverse để xử lý gọn cả trường hợp n == 1
        ListNode dummy = new ListNode(0, firstReverse);
        ListNode curr = dummy;

        // Đi tới node đứng NGAY TRƯỚC node thứ n (bước n - 1 lần từ firstReverse, tức n - 1 bước từ dummy)
        for (int i = 1; i < n; i++) {
            curr = curr.next;
        }

        // 3. Bắc cầu xóa node thứ n
        curr.next = curr.next.next;

        // 4. Đảo ngược lại danh sách (bắt đầu từ dummy.next) và trả về
        return ReverseList(dummy.next);
    }

    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;
        while (curr != null) {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        return prev;
    }
}