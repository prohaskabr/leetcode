namespace Problems;

public class Subsequence
{
    public bool IsSubsequence(string s, string t)
    {
        if(string.IsNullOrEmpty(s))
            return true;

        int x = 0;

        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == s[x])
            {
                x++;

                if (x == s.Length)
                    return true;
            }
        }
        return false;
    }
}
