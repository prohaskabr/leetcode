namespace Problems.Tests;

/// <summary>
/// Given an integer array nums, find the  subarray with the largest sum, and return its sum.
///
/// Example 1:
///
/// Input: nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4]
/// Output: 6
/// Explanation: The subarray [4, -1, 2, 1] has the largest sum 6.
/// Example 2:
///
/// Input: nums = [1]
/// Output: 1
/// Explanation: The subarray [1] has the largest sum 1.
/// Example 3:
///
/// Input: nums = [5, 4, -1, 7, 8]
/// Output: 23
/// Explanation: The subarray [5, 4, -1, 7, 8] has the largest sum 23.
/// </summary>
public class _053_MaximumSubArrayTest
{
    [Theory]
    [InlineData(6, -2, 1, -3, 4, -1, 2, 1, -5, 4)]
    [InlineData(1,1)]
    [InlineData(12, 5,1,3,2,1)]
    [InlineData(23, 5, 4, -1, 7, 8)]
    [InlineData(-1, -1)]
    [InlineData(-1, -2,-1)]
    public void Test(int expected, params int[] numbers)
    {
        var stu = new MaximumSubArray();

        var result = stu.MaxSubArray(numbers);

        Assert.Equal(expected, result);
    }
}