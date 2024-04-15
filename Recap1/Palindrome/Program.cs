using System.Text;

namespace Palindrome
{
    class Program
    {
        static void Main()
        {
            string input = "alabala";

            bool isPalindrome = IsPalindrome(input);

            if (isPalindrome)
            {
                Console.WriteLine($"{input} -> True");
            }
            else
            {
                Console.WriteLine($"{input} -> False");
            }
        }

        static bool IsPalindrome(string input)
        {
            var firstHalf = input.Substring(0, input.Length / 2);
            var secondHalf = input.Substring(input.Length / 2 + 1);

            return firstHalf == ReverseString(secondHalf);
        }

        static string ReverseString(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
                sb.Append(s[i]);
            return sb.ToString();
        }

        static bool IsPalindrome1(string input)
        {
            // Convert the input string to a character array
            char[] charArray = input.ToCharArray();

            // Get the length of the character array
            int length = charArray.Length;

            // Compare each character from the start with its corresponding character from the end
            // If any characters don't match, return false
            for (int i = 0; i < length / 2; i++)
            {
                if (charArray[i] != charArray[length - i - 1])
                {
                    return false;
                }
            }

            // If all characters match, return true
            return true;
        }
    }
}
