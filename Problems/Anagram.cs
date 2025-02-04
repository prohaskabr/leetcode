namespace Problems;

public class Anagram
{
    const int AsciiStartNumber = 97;
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var letters = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            letters[s[i] - AsciiStartNumber]++;
            letters[t[i] - AsciiStartNumber]--;
        }

        for (int i = 0; i < letters.Length; i++)
        {

            if (letters[i] != 0)
                return false;
        }

        return true;
    }
}
