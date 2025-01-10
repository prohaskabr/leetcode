namespace Problems;

public class RomanNumber
{
    private readonly Dictionary<char, int> Values = new Dictionary<char, int>()
    {
        ['I'] = 1,
        ['V'] = 5,
        ['X'] = 10,
        ['L'] = 50,
        ['C'] = 100,
        ['D'] = 500,
        ['M'] = 1000
    };

    public int RomanToInt(string s)
    {        
        var lastValue = 0;
        var result = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            var n = Values[s[i]];

            if (n < lastValue)
            {
                result -= n;
                continue;
            }

            lastValue = n;
            result += n;
        }

        return result;
    }
}
