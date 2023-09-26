using System;

public class PalindromeChecker
{
    public static bool IsPalindrome(string text)
    {
        text = text.Replace(" ", "").ToLower();

        int left = 0;
        int right = text.Length - 1;

        while (left < right)
        {
            if (text[left] != text[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    public static void Main(string[] args)
    {
        string input = "ai ra mzis sizmaria";
        bool isPalindrome = IsPalindrome(input);

        if (isPalindrome)
        {
            Console.WriteLine($"{input} - is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{input} - is not a palindrome.");
        }
    }
}
