namespace Problems;

public class RemoveElement
{
    public int Remove(int[] nums, int val)
    {
        var position = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[position] = nums[i];
                position++;
            }
        }

        return position;
    }

    public int RemoveDuplicates(int[] nums)
    {
        int position = 1;

        for (var i = 1; i < nums.Length; i++)
        {

            if (nums[i] != nums[position - 1])
            {
                nums[position] = nums[i];
                position++;
            }
        }

        return position;

    }
}
