using System.Numerics;

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

    public uint ReverseBits(uint n)
    {
        uint result = 0;

        for (int i = 0; i < 32; i++)
        {
            result = result << 1;
            result = result | (n & 1);
            n = n >> 1;
        }

        return result;
    }
}
