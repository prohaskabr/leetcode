namespace Problems.Tests;

/// <summary>
/// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
/// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
///
/// Example 1:
/// Input: l1 = [2,4,3], l2 = [5, 6, 4]
/// Output: [7, 0, 8]
/// Explanation: 342 + 465 = 807.
///
/// Example 2: 
/// Input: l1 = [0], l2 = [0]
/// Output: [0]
/// 
/// Example 3: 
/// Input: l1 = [9, 9, 9, 9, 9, 9, 9], l2 = [9, 9, 9, 9]
/// Output: [8, 9, 9, 9, 0, 0, 0, 1]
/// </summary>
public class _002_AddTwoNumbersTest
{
    private AddTwoNumbers stu = new();

[Fact]
public void Add_243_to_564_should_be_708()
{
    var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
    var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

    var result = stu.Add(l1, l2);

    AssertValue(result, 7, 0, 8);
}

[Fact]
public void Add_0_to_0_should_be_0()
{
    var l1 = new ListNode(0);
    var l2 = new ListNode(0);

    var result = stu.Add(l1, l2);

    AssertValue(result, 0);
}

[Fact]
public void Add_9999999_to_9999_should_be_89990001()
{
    var l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
    var l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));

    var result = stu.Add(l1, l2);

    AssertValue(result, 8, 9, 9, 9, 0, 0, 0, 1);
}

private void AssertValue(ListNode result, params int[] values)
{
    var node = result;
    foreach (var value in values)
    {
        Assert.Equal(value, node.val);
        node = node.next;
    }
}
}
