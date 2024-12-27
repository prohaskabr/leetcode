namespace Problems;

public class MajorityElement
{
    public int Get(int[] numbers)
    {
        var quantity = 0;
        var majorityItem = 0;

        foreach (var number in numbers)
        {
            if (quantity == 0)
            {
                majorityItem = number;
                quantity = 1;
            }
            else
            {
                quantity += majorityItem == number ? 1 : -1;
            }
        }
        return majorityItem;
    }
}
