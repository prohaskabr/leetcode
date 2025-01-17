
namespace Problems;

public class Palindrome
{
    public bool IsPalindrome(string s)
    {
        var r = 0;
        var l = s.Length - 1;

        while (r < l)
        {
            while (!char.IsAsciiLetterOrDigit(s[r]))
            {
                r++;            
                
                if(r>= s.Length)
                    return true;
            }

            while (!char.IsAsciiLetterOrDigit(s[l]))
            {
                l--;

                if (l < 0)
                    return true;
            }
                        

            if (char.ToUpperInvariant(s[r]) != char.ToUpperInvariant(s[l]))            
                return false;

            r++;
            l--;            
        }

        

        return true;
    }

    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;

        if (x == 0)
            return true;

        if (x % 10 == 0)
            return false;

        var originalX = x;
        var reversedX = 0;

        while (x > 0)
        {

            var lastDigit = x % 10;
            reversedX = reversedX * 10 + lastDigit;
            x = x / 10;
        }

        return originalX == reversedX;
    }
}
