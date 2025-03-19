using Problems.Common;

namespace Problems.Tests;
public class _160_IntersectionOfTwoLinkedListsTest
{
    [Theory]    
    [InlineData(2, new[] { 1, 9, 1, 2, 4 }, new[] { 3, 2, 4 })]
    [InlineData(null, new[] { 2, 6, 4 }, new[] { 1, 5 })]
    public void Test(int? expected, int[] listA, int[] listB)
    {
        var stu = new IntersectionLinkedLists();

        var result = stu.GetIntersectionNode(createLinkedList(listA), createLinkedList(listB));

        Assert.Equal(expected, result?.val);
    }

    private ListNode createLinkedList(int[] nums)
    {
        ListNode head = new ListNode(nums[0]);

        ListNode next = head;
        for (int i = 1; i < nums.Length; i++)
        {
            next.next = new ListNode(nums[i]);
            next = next.next;
        }

        return head;
    }
}
