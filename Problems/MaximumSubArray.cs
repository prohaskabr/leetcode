namespace Problems;

public class MaximumSubArray
{
    public int MaxSubArray(int[] numbers)
    {
        var currentSum = 0;
        var partialSum = numbers[0];

        foreach (var number in numbers)
        {
            if (currentSum < 0)
                currentSum = 0;

            currentSum += number;

            partialSum = Math.Max(currentSum, partialSum);
        }

        return partialSum;
    }
}
