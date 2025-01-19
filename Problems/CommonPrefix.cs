namespace Problems;

public class CommonPrefix
{
    public string LongestCommonPrefix(string[] strs)
    {
        int n = strs.Length;
        for (int i = 0; i < strs[0].Length; ++i)
        {
            for (int j = 1; j < n; ++j)
            {
                if (i >= strs[j].Length || strs[j][i] != strs[0][i])
                {
                    return strs[0].Substring(0, i);
                }
            }
        }
        return strs[0];
    }

    public string LongestCommonPrefixV1(string[] strs)
    {
        var shortest = strs[0];
        var size = 0;

        foreach (var str in strs)
        {

            if (str.Length < shortest.Length)
                shortest = str;
        }

        size = shortest.Length;

        foreach (var str in strs)
        {
            for (var i = 0; i < Math.Min(str.Length, size); i++)
            {
                if (str[i] != shortest[i])
                {
                    if (i < size)
                        size = i;

                    break;
                }

            }

            if (size == 0)
                return string.Empty;

        }

        return strs[0][0..size];
    }
}
