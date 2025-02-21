using Microsoft.VisualStudio.TestPlatform.Utilities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Tests;
/// <summary>
/// You are given an integer array nums consisting of n elements, and an integer k.
/// Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value.Any answer with a calculation error less than 10-5 will be accepted.
/// 
/// Example 1:
///     Input: nums = [1, 12, -5, -6, 50, 3], k = 4
///     Output: 12.75000
///     Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75
///     
/// Example 2:
///     Input: nums = [5], k = 1
///     Output: 5.00000
/// </summary>
public class _643_MaximumAverageSubarrayITest
{
    [Theory]
    [InlineData(12.75, new[] { 1, 12, -5, -6, 50, 3 },4)]
    [InlineData(5, new[] { 5 },1)]
    [InlineData(4, new[] { 0, 4, 0, 3, 2 }, 1)]
    public void Test(double expected, int[] nums, int window)
    {
        var stu = new AverageSubarray();

        var result = stu.FindMaxAverage(nums, window);

        Assert.Equal(expected, result);
    }
}
