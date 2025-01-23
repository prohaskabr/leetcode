namespace Problems.Tests;

public class _136_SingleNumber
{
    [Theory]
    [InlineData(1, new[] { 2, 2, 1 })]
    [InlineData(4, new[] { 4, 1, 2, 1, 2 })]
    [InlineData(1, new[] { 1 })]
    public void Test(int expected, int[] numbers)
    {
        var stu = new SingleNumber();

        var result = stu.GetSingleNumber(numbers);

        Assert.Equal(expected, result);
    }
}
