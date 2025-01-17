using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.Diagnostics.Metrics;

namespace Problems.Tests;

/// <summary>
/// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
/// Given a string s, return true if it is a palindrome, or false otherwise.
/// 
/// Example 1:
///     Input: s = "A man, a plan, a canal: Panama"
///     Output: true
///     Explanation: "amanaplanacanalpanama" is a palindrome.
///     
/// Example 2:
///     Input: s = "race a car"
///     Output: false
///     Explanation: "raceacar" is not a palindrome.
///     
/// Example 3:
///     Input: s = " "
///     Output: true
///     Explanation: s is an empty string "" after removing non-alphanumeric characters.
///     Since an empty string reads the same forward and backward, it is a palindrome.
/// </summary>
public class _125_ValidPalindromeTest
{
    [Theory]
    [InlineData(true, "AmanaplanacanalPanama")]
    [InlineData(true, "A man, a plan, a canal: Panama")]
    [InlineData(false, "race a car")]
    [InlineData(true, " ")]
    [InlineData(true, ".,")]
    [InlineData(false, "0P")]
    public void Test(bool expected, string phrase) {

        var stu = new Palindrome();

        var result = stu.IsPalindrome(phrase);

        Assert.Equal(expected, result);
    }
}
