namespace Problems;

public class NumberOf
{
    public int MaxNumberOfBalloons(string text)
    {
        const int BalloonLetters = 7;
        var result = text.Length / BalloonLetters;

        if (result == 0)
            return result;

        var map = new Dictionary<char, int>()
        {
            ['b'] = 0,
            ['a'] = 0,
            ['l'] = 0,
            ['o'] = 0,
            ['n'] = 0,
        };


        foreach (var letter in text)
        {
            if (map.ContainsKey(letter))
                map[letter]++;
        }

        //adjust letter with multiple use

        map['l'] /= 2;
        map['o'] /= 2;

        foreach (var qtd in map.Values)
        {
            if (qtd < result)
            {
                result = qtd;
            }
        }

        return result;
    }

    public int NumIdenticalPairs(int[] nums)
    {
        var result = 0;

        var map = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            if (map.ContainsKey(n))
                map[n]++;
            else
                map.Add(n, 1);
        }

        foreach (var item in map)
        {
            result += (item.Value * (item.Value - 1)) / 2;
        }

        return result;
    }
}
