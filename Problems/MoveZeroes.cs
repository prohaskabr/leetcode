namespace Problems;

public class MoveZeroes
{
    public void Move(int[] nums)
    {
        var insertPosition = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[insertPosition] = nums[i];
                insertPosition++;
            }
        }

        for (int i = insertPosition; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}
