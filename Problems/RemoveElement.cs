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
}
