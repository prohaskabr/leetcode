namespace Problems;

public class RotateArray
{
    public void Rotate(int[] nums, int k)
    {
        var rotate =  k % nums.Length;
        reverse(nums, 0, nums.Length - 1);
        reverse(nums, 0, rotate - 1);
        reverse(nums, rotate, nums.Length - 1);
    }

    private void reverse(int[] nums, int start, int end)
    {

        while (start < end)
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}
