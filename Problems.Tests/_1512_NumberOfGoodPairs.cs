namespace Problems.Tests;
public class _1512_NumberOfGoodPairs
{
    [Theory]
    [InlineData(4, new[] { 1, 2, 3, 1, 1, 3 })]
    [InlineData(6, new[] { 1, 1, 1, 1 })]
    [InlineData(0, new[] { 1, 2, 3 })]

    public void Test(int expected, int[] numbers)
    {
        var stu = new NumberOf();

        var result = stu.NumIdenticalPairs(numbers);

        Assert.Equal(expected, result);
    }
}
