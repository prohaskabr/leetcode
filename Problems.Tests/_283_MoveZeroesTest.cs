namespace Problems.Tests;

public class _283_MoveZeroesTest
{
    [Theory]
    [InlineData(new[] { 1, 3, 12, 0, 0 }, new[] { 0, 1, 0, 3, 12 })]
    [InlineData(new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { -1, 0 }, new[] { 0, -1 })]
    public void Test(int[] expected, int[] nums)
    {
        var stu = new MoveZeroes();

        stu.Move(nums);

        Assert.Equal(expected, nums);
    }
}
