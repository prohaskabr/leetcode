namespace Problems;

public class ContainsDuplicate
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var map = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (map.Contains(nums[i]))
                return true;
            else
                map.Add(nums[i]);

            if(i >= k)
                map.Remove(nums[i - k]);
        }

        return false;
    }
}
