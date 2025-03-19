using Problems.Common;

namespace Problems;

public class AddTwoNumbers
{
    public ListNode Add(ListNode l1, ListNode l2)
    {
        ListNode head = null;
        ListNode current = null;
        var firstNumbers = l1;
        var secondNumbers = l2;
        var rest = 0;

        while (firstNumbers != null || secondNumbers != null || rest > 0)
        {
            var term01 = firstNumbers?.val ?? 0;
            var term02 = secondNumbers?.val ?? 0;

            var result = term01 + term02 + rest;

            if (result > 9)
            {
                rest = result / 10;
                result %= 10;
            }
            else
            {
                rest = 0;
            }

            if (current == null)
            {
                head = new ListNode(result);
                current = head;
            }
            else
            {
                current.next = new ListNode(result);
                current = current.next;
            }

            firstNumbers = firstNumbers?.next;
            secondNumbers = secondNumbers?.next;
        }

        return head;
    }
}