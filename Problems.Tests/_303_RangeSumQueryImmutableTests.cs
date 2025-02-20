using System.Xml.Linq;

namespace Problems.Tests;

/// <summary>
/// Given an integer array nums, handle multiple queries of the following type:
/// Calculate the sum of the elements of nums between indices left and right inclusive where left <= right.
/// Implement the NumArray class:
/// NumArray(int[] nums) Initializes the object with the integer array nums.
/// int sumRange(int left, int right) Returns the sum of the elements of nums between indices left and right inclusive (i.e.nums[left] + nums[left + 1] + ... + nums[right]).
/// 
/// Example 1:
///     Input
///     ["NumArray", "sumRange", "sumRange", "sumRange"]
///     [[[-2, 0, 3, -5, 2, -1]], [0, 2], [2, 5], [0, 5]]
///     Output
///     [1, -1, -3]
/// </summary>
public class _303_RangeSumQueryImmutableTests
{
    [Theory]
    [InlineData(1, new[] { 0, 2 })]
    [InlineData(-1, new[] { 2, 5 })]
    [InlineData(-3, new[] { 0, 5 })]
    public void Test(int expected, int[] nums)
    {
        var stu = new NumArray([-2, 0, 3, -5, 2, -1]);

        var result = stu.SumRange(nums[0], nums[1]);

        Assert.Equal(expected, result);
    }
}
