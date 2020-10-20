using System;

namespace Reverse_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            ReverseList(head);
            ReverseList_Recur(head, null);
        }

        public class ListNode
        {
            public int val { get; set; }
            public ListNode next { get; set; }

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        static ListNode ReverseList(ListNode head)
        {
            ListNode cur = head;
            ListNode prev = null;
            while (cur != null)
            {
                ListNode next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
            }
            return prev;
        }

        static ListNode ReverseList_Recur(ListNode head, ListNode prev)
        {
            if (head == null) return prev;
            ListNode next = head.next;
            head.next = prev;
            return ReverseList_Recur(next, head);
        }
    }
}
