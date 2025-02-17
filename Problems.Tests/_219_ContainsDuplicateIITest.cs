namespace Problems.Tests;

/// <summary>
/// Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.
/// 
/// Example 1:
///     Input: nums = [1,2,3,1], k = 3
///     Output: true
///     
/// Example 2:
///     Input: nums = [1,0,1,1], k = 1
///     Output: true
///     
/// Example 3:
///     Input: nums = [1,2,3,1,2,3], k = 2
///     Output: false
/// </summary>
public class _219_ContainsDuplicateIITest
{
    [Theory]
    [InlineData(true, 3, new[] { 1, 2, 3, 1 })]
    [InlineData(true, 1, new[] { 1, 0, 1, 1 })]
    [InlineData(false, 2, new[] { 1, 2, 3, 1, 2, 3 })]
    public void Test(bool expected, int window, int[] nums)
    {
        var stu = new ContainsDuplicate();

        var result = stu.ContainsNearbyDuplicate(nums, window);

        Assert.Equal(expected, result);
    }
}
