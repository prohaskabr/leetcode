namespace Problems;

public class RansomNote
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        if (ransomNote.Length > magazine.Length)
            return false;

        var lFounded = 0;
        var map = new Dictionary<char, int>();


        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (map.ContainsKey(ransomNote[i]))
                map[ransomNote[i]]++;
            else
                map.Add(ransomNote[i], 1);
        }

        for (int i = 0; i < magazine.Length; i++)
        {
            if (map.ContainsKey(magazine[i]) && map[magazine[i]] > 0)
            {
                map[magazine[i]]--;
                lFounded++;
            }

            if (lFounded == ransomNote.Length)
                return true;
        }

        return false;
    }   
}
