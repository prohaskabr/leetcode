namespace Problems.Tests;

/// <summary>
/// Given two strings s and t, determine if they are isomorphic.
/// Two strings s and t are isomorphic if the characters in s can be replaced to get t.
/// All occurrences of a character must be replaced with another character while preserving the order of characters.
/// No two characters may map to the same character, but a character may map to itself.
/// </summary>
public class _205_IsomorphicStringsTest
{
    [Theory]
    [InlineData(true, "egg", "add")]
    [InlineData(false, "foo", "bar")]
    [InlineData(true, "paper", "title")]
    [InlineData(false, "bbbaaaba", "aaabbbba")]
    public void Test(bool expected, string first, string second)
    {
        var stu = new Isomorphic();

        var result = stu.IsIsomorphic(first, second);

        Assert.Equal(expected, result);
    }
}
