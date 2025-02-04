namespace Problems.Tests;

/// <summary>
/// Given two strings s and t, return true if t is an 
/// anagram of s, and false otherwise.
/// 
/// Example 1:
///     Input: s = "anagram", t = "nagaram"
///     Output: true
/// 
/// Example 2:
///     Input: s = "rat", t = "car"
///     Output: false
/// </summary>
public class _242_ValidAnagramTest
{
    [Theory]
    [InlineData(true,"anagram", "nagaram")]
    [InlineData(false, "rat", "car")]
    [InlineData(false, "zlap", "kcqx")]
    public void Test(bool expected, string first, string second)
    {
        var stu = new Anagram();

        var result = stu.IsAnagram(first, second);

        Assert.Equal(expected, result);
    }
}
