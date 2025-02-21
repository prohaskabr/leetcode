namespace Problems;
public class AverageSubarray
{
    public double FindMaxAverage(int[] nums, int k)
    {
        var result =  0.0;

        for (int i = 0; i < k; i++)
        {
            result += nums[i];
        }

        var current = result;

        for (int i = k; i < nums.Length ; i++) {
            current = current + nums[i] - nums[i -k];

            if(current > result)
                result = current;
        }

        return double.Round(result / k,5);
    }
}
