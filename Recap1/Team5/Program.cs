namespace Team5
{
    /*
     Write a method to check whether a string starts with specified characters.
    ```
    input: awesome string
           a
    output : Yes, starts with a
    ```
     */
    class Program
    {
        static void Main()
        {
            string input = "awesome string";
            char specifiedChar = 'b';

            bool startsWithSpecifiedChar = StartsWithCharacter(input, specifiedChar);

            if (startsWithSpecifiedChar)
            {
                Console.WriteLine($"Yes, starts with {specifiedChar}");
            }
            else
            {
                Console.WriteLine($"No, doesn't start with {specifiedChar}");
            }
        }

        static bool StartsWithCharacter(string input, char specifiedChar)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            // Check if the first character of the input string matches the specified character
            return input[0] == specifiedChar;
        }
    }
}
