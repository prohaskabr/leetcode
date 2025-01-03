namespace Problems.Tests;

/// <summary>
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// 
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// You can return the answer in any order.
///
/// Example 1:
/// Input: nums = [2, 7, 11, 15], target = 9
/// Output: [0, 1]
/// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
///
/// Example 2:
/// Input: nums = [3, 2, 4], target = 6
/// Output: [1, 2]
/// 
/// Example 3:
/// Input: nums = [3, 3], target = 6
/// Output: [0, 1]
/// </summary>
public class _001_TwoSumTest
{

    [Fact]
    public void TwoNumbersArray()
    {
        var target = 6;
        var input = new[] { 3, 3 };
        var expected = new[] { 0, 1 };

        var stu = new TwoSum();

        var result = stu.Get(input, target);

        Assert.Equivalent(result, expected);
        Assert.Equal(target, input[result[0]] + input[result[1]]);
    }

    [Fact]
    public void MultipleNumbersArray()
    {
        var target = 10;
        var input = new[] { 2, 5, 5, 11 };
        var expected = new[] { 1,2 };

        var stu = new TwoSum();

        var result = stu.Get(input, target);

        Assert.Equivalent(result, expected);
        Assert.Equal(target, input[result[0]] + input[result[1]]);
    }

    [Fact]
    public void MultipleNumbersArray_Expected_FirstTwo()
    {
        var target = 9;
        var input = new[] { 2, 7, 11, 15 };
        var expected = new[] { 0, 1 };

        var stu = new TwoSum();

        var result = stu.Get(input, target);

        Assert.Equivalent(result, expected);
        Assert.Equal(target, input[result[0]] + input[result[1]]);
    }

    [Fact]
    public void MultipleNumbersArray_Expected_LastTwo()
    {
        var target = 6;
        var input = new[] { 3, 2, 4 };
        var expected = new[] { 1, 2 };

        var stu = new TwoSum();

        var result = stu.Get(input, target);

        Assert.Equivalent(result, expected);
        Assert.Equal(target, input[result[0]] + input[result[1]]);
    }

    [Fact]
    public void MultipleNumbersArray_Expected_FirstAndLast()
    {
        var target = 6;
        var input = new[] { 3, 2, 3 };
        var expected = new[] {0,2};

        var stu = new TwoSum();

        var result = stu.Get(input, target);

        Assert.Equivalent(result, expected);
        Assert.Equal(target, input[result[0]] + input[result[1]]);
    }

}
