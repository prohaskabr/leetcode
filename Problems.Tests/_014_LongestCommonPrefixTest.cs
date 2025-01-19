namespace Problems.Tests;

/// <summary>
/// Write a function to find the longest common prefix string amongst an array of strings.
/// If there is no common prefix, return an empty string "".
/// 
/// Example 1:
///     Input: strs = ["flower", "flow", "flight"]
///     Output: "fl"
///     
/// Example 2:
///     Input: strs = ["dog", "racecar", "car"]
///     Output: ""
///     Explanation: There is no common prefix among the input strings.
/// </summary>
public class _014_LongestCommonPrefixTest
{

    [Theory]
    [InlineData("fl", new[] { "flower", "flow", "flight" })]
    [InlineData("", new[] { "dog", "racecar", "car" })]
    [InlineData("", new[] { "abab", "aba", "" })]
    [InlineData("", new[] { "baab", "bacb", "b", "cbc" })]    
    public void Test(string expectedPrefix, string[] strs)
    {
        var sut = new CommonPrefix();

        var result = sut.LongestCommonPrefix(strs);

        Assert.Equal(expectedPrefix, result);
    }
}
