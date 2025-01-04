namespace Problems;

public class RemoveDuplicatesfromSortedArrayII
{
    public int Remove(int[] nums)
    {
        var position = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (position - 2 >= 0 && nums[position - 2] == nums[i])
            {
                continue;
            }
            nums[position] = nums[i];
            position++;
        }
        return position;
    }

    public int RemoveOld(int[] nums)
    {
        var lastNumber = -1;
        var sameNumCount = 0;
        var position = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == lastNumber)
                sameNumCount++;
            else
            {
                sameNumCount = 0;
                lastNumber = nums[i];
            }

            if (sameNumCount < 2)
            {
                nums[position] = nums[i];
                position++;
            }
        }

        return position;
    }
}
