using Problems.Common;

namespace Problems;
/// <summary>
/// Given the heads of two singly linked-lists headA and headB, return the node at which the two lists intersect.
/// If the two linked lists have no intersection at all, return null.
/// </summary>
public class IntersectionLinkedLists
{
    public ListNode? GetIntersectionNode(ListNode headA, ListNode headB)
    {     
        ListNode nodeA = headA;
        ListNode nodeB = headB;
        
        while (nodeA != nodeB)
        {                     
            
            nodeA = (nodeA  is null) ? headB : nodeA.next;
            nodeB = (nodeB is null) ? headA : nodeB.next;
        }

        return nodeA;
    }
}

