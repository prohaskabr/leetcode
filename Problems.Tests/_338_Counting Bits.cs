namespace Problems.Tests;

public class _338_Counting_Bits
{
    [Theory]
    [InlineData(new[] { 0, 1, 1 }, 2)]    
    [InlineData(new[] { 0, 1, 1, 2, 1, 2 }, 5)]    
    public void Test(int[] expected, int number)
    {
        var stu = new NumberOfBits();

        var result = stu.CountBits(number);

        Assert.Equal(expected, result);
    }
}
