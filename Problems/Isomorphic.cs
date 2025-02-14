namespace Problems;
public class Isomorphic
{
    public bool IsIsomorphic(string s, string t)
    {
        var map = new Dictionary<char, char>();

        if (s.Length != t.Length)
            return false;

        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))
            {
                if (map[s[i]] != t[i])
                    return false;
            }
            else
            {
                if (map.ContainsValue(t[i]))
                    return false;

                map.Add(s[i], t[i]);
            }
        }

        return true;
    }
}