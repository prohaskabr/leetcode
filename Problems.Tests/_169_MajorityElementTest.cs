namespace Problems.Tests;

///<summary>
/// Given an array nums of size n, return the majority element.
/// The majority element is the element that appears more than ⌊n / 2⌋ times.You may assume that the majority element always exists in the array.
/// 
/// Example 1:
///     Input: nums = [3, 2, 3]
///     Output: 3
/// 
/// Example 2:
///     Input: nums = [2, 2, 1, 1, 1, 2, 2]
///     Output: 2
///</summary>
public class _169_MajorityElementTest
{
    [Theory]
    [InlineData(1, 1, 2, 1, 2, 1, 1)]
    [InlineData(3, 3, 2, 3)]
    [InlineData(2, 2, 2, 1, 1, 1, 2, 2)]
    public void Test(int expected, params int[] numbers)
    {
        var stu = new MajorityElement();

        var result = stu.Get(numbers);

        Assert.Equal(expected, result);
    }
}