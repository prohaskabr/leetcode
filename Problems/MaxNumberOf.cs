namespace Problems;

public class MaxNumberOf
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
}
