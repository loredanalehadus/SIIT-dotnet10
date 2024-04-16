﻿using System.Text;

namespace Team3
{
    /*
     You will get a text from where you will need to clean the text because it contains a lot of strange characters that don’t belong there `^<,>&+@%$`

    ```
    Input:
    Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks. @Hate ^me^ %now% and %thank% me &later.
    Output:
    Hi there I’m telling you, you need to do your homeworks. Hate me now and thank me later.
    ```
     */

    class Program
    {
        static void Main()
        {
            string input = "Th^i<s i>s a @t&ext wi%th sp$ecial <charact>ers.";

            string cleanedText = CleanText(input);

            Console.WriteLine(cleanedText);
        }

        static string CleanText(string input)
        {
            StringBuilder cleanedText = new StringBuilder();

            // Define the set of unwanted characters
            char[] unwantedCharacters = { '^', '<', '>', ',', '[', ']', '@', '%', '$', '&', '+', '_' };

            string unwantedChars = "^<,>&+@%$";


            // Iterate through each character of the input string
            foreach (char c in input)
            {
                if (!unwantedChars.Contains(c))
                {
                    cleanedText.Append(c);
                }

                // Check if the character is not in the set of unwanted characters
                //if (Array.IndexOf(unwantedCharacters, c) == -1)
                //{
                //    // Append the character to the cleaned text
                //    cleanedText.Append(c);
                //}
            }

            return cleanedText.ToString();
        }
    }
}