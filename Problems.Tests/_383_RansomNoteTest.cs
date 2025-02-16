namespace Problems.Tests;

/// <summary>
/// Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
/// Each letter in magazine can only be used once in ransomNote.
/// 
/// Example 1:
///     Input: ransomNote = "a", magazine = "b"
///     Output: false
/// 
/// Example 2:
///     Input: ransomNote = "aa", magazine = "ab"
///     Output: false
/// 
/// Example 3:
///     Input: ransomNote = "aa", magazine = "aab"
///     Output: true
/// </summary>
public class _383_RansomNoteTest
{
    [Theory]
    [InlineData(false, "a", "b")]
    [InlineData(false, "aa", "ab")]
    [InlineData(true, "aa", "aab")]
    public void Test(bool expected, string first, string second)
    {
        var stu = new RansomNote();

        var result = stu.CanConstruct(first, second);

        Assert.Equal(expected, result);
    }
}
