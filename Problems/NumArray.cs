namespace Problems;
public class NumArray
{

    private int[] _nums;
    public NumArray(int[] nums)
    {
        _nums = new int[nums.Length];
        _nums[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            _nums[i] = _nums[i - 1] + nums[i];
        }

    }

    public int SumRange(int left, int right)
    {
        return left > 0 ? _nums[right] - _nums[left - 1] : _nums[right];
    }
}
