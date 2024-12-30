namespace Problems;

public class TwoSum
{

    public int[] Get(int[] numbers, int target)
    {
        var numbersToTry = new Dictionary<int,int>(numbers.Length);
        
        for (var i = 0; i < numbers.Length; i++)
        {
            var minuend = target - numbers[i];

            if (numbersToTry.TryGetValue(minuend, out var value))
                return [value, i];

            numbersToTry.TryAdd(numbers[i], i);

        }

        throw new Exception("Sum not found");
    }

    //public int[] Get(int[] numbers, int target)
    //{
    //    for (int i = 0; i < numbers.Length - 1; i++)
    //    {
    //        for (int j = i + 1; j < numbers.Length; j++)
    //        {
    //            if (numbers[i] + numbers[j] == target)
    //                return [i, j];
    //        }
    //    }
    //    return [0, 1];
    //}
}
