namespace Problems;
public class NumberOfBits
{
    public int HammingWeight(int n)
    {
        int bitCount = 0;
        while (n > 0)
        {
            if (n % 2 != 0)
                bitCount++;

            n /= 2;
        }

        return bitCount;
    }

    public int[] CountBits(int n)
    {
        var result = new int[n + 1];
        
        for (int i = 1; i <= n; i++)
        {
            result[i] = result[i >> 1] + i % 2;
        }

        return result;
    }

    /*public int[] CountBits(int n)
    {
        var result = new int[n+1];
        result[0] = 0;

        for (int i = 1; i <= n; i++) {
            var num = i;
            result[i] = 0;
            while (num > 0)
            {
                if (num % 2 != 0)
                    result[i] ++;

                num /= 2;
            }
        }

        return result;
    }*/
}
