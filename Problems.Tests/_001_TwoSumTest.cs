﻿namespace Problems.Tests;

/// <summary>
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// 
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// You can return the answer in any order.
///
/// Example 1:
///     Input: nums = [2, 7, 11, 15], target = 9
///     Output: [0, 1]
///     Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
///
/// Example 2:
///     Input: nums = [3, 2, 4], target = 6
///     Output: [1, 2]
/// 
/// Example 3:
///     Input: nums = [3, 3], target = 6
///     Output: [0, 1]
/// </summary>
public class _001_TwoSumTest
{

    [Theory]
    [InlineData(new[] { 0, 1 }, 6, new[] { 3, 3 })]
    [InlineData(new[] { 1, 2 }, 10, new[] { 2, 5, 5, 11 })]
    [InlineData(new[] { 0, 1 }, 9, new[] { 2, 7, 11, 15 })]
    [InlineData(new[] { 1, 2 }, 6, new[] { 3, 2, 4 })]
    [InlineData(new[] { 0, 2 }, 6, new[] { 3, 2, 3 })]
    public void Test(int[] expected, int target, int[] input)
    {
        var stu = new TwoSum();

        var result = stu.Get(input, target);

        Assert.Equivalent(result, expected);
        Assert.Equal(target, input[result[0]] + input[result[1]]);
    }
}
