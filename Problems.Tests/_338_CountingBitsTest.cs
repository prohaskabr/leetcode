namespace Problems.Tests;

/// <summary>
/// Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.
/// 
/// Example 1:
///     Input: n = 2
///     Output: [0, 1, 1]
///     Explanation:
///     0 --> 0
///     1 --> 1
///     2 --> 10
///     
/// Example 2:
///     Input: n = 5
///     Output: [0, 1, 1, 2, 1, 2]
///     Explanation:
///     0 --> 0
///     1 --> 1
///     2 --> 10
///     3 --> 11
///     4 --> 100
///     5 --> 101
/// </summary>
public class _338_Counting_Bits
{
    [Theory]
    [InlineData(new[] { 0, 1, 1 }, 2)]    
    [InlineData(new[] { 0, 1, 1, 2, 1, 2 }, 5)]    
    public void Test(int[] expected, int number)
    {
        var stu = new NumberOfBits();

        var result = stu.CountBits(number);

        Assert.Equal(expected, result);
    }
}
