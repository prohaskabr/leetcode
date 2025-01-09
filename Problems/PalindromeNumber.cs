namespace Problems;

public class PalindromeNumber
{
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

        while (x > 0) {

            var lastDigit = x % 10;
            reversedX = reversedX * 10 + lastDigit;
            x = x / 10;
        }

        return originalX == reversedX;
    }
}
