namespace Problems.Tests;

/// <summary>
/// Given an integer x, return true if x is a palindrome, and false otherwise.
/// 
/// Example 1:
///     Input: x = 121
///     Output: true
///     Explanation: 121 reads as 121 from left to right and from right to left.
///     
/// Example 2:
///     Input: x = -121
///     Output: false
///     Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
///     
/// Example 3:
///     Input: x = 10
///     Output: false
///     Explanation: Reads 01 from right to left.Therefore it is not a palindrome.
/// </summary>
public class _009_PalindromeNumberTest
{
    [Theory]
    [InlineData(true, 121)]
    [InlineData(false, -121)]
    [InlineData(false, 10)]
    [InlineData(true, 0)]
    [InlineData(false, 1000021)]
    
    public void Test(bool expected, int number)
    {
        var stu = new Palindrome();

        var result = stu.IsPalindrome(number);

        Assert.Equal(expected, result);
    }
}
