namespace Problems.Tests;

public class _191_NumberOf1Bits
{
    [Theory]
    [InlineData(3, 11)]
    [InlineData(1, 128)]
    [InlineData(30, 2147483645)]
    public void Test(int expected, int number)
    {
        var stu = new NumberOfBits();

        var result = stu.HammingWeight(number);

        Assert.Equal(expected, result);
    }
}