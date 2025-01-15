using System.Diagnostics.CodeAnalysis;

namespace Problems.Tests;

/// <summary>
/// Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
/// A subsequence of a string is a new string that is formed from the original string by deleting some(can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
///
/// Example 1:
///     Input: s = "abc", t = "ahbgdc"
///     Output: true
///
/// Example 2:
///     Input: s = "axc", t = "ahbgdc"
///     Output: false
/// </summary>
public class _392_IsSubsequenceTest
{
    [Theory]
    [InlineData(true, "abc", "ahbgdc")]
    [InlineData(false, "axc", "ahbgdc")]
    public void Test(bool expected, string subsequence, string content)
    {
        var stu = new Subsequence();

        var result = stu.IsSubsequence(subsequence, content);

        Assert.Equal(expected, result);
    }
}
