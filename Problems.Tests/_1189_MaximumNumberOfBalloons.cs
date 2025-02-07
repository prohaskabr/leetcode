namespace Problems.Tests;

/// <summary>
/// Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.
// You can use each character in text at most once.Return the maximum number of instances that can be formed.
/// </summary>
public class _1189_MaximumNumberOfBalloons
{
    [Theory]
    [InlineData(1, "nlaebolko")]
    [InlineData(2, "loonbalxballpoon")]
    [InlineData(0, "leetcode")]
    [InlineData(0, "xyz")]
    public void Test(int expected, string word)
    {
        var stu = new MaxNumberOf();

        var result = stu.MaxNumberOfBalloons(word);

        Assert.Equal(expected, result);
    }
}
