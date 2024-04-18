using System.Text;

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
            //string input = "Th^i<s i>s a @t&ext wi%th sp$ecial <charact>ers.";
            string input = "Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks. @Hate ^me^ %now% and %thank% me &later.";

            string cleanedText = CleanTextWithCharArray(input);

            Console.WriteLine(cleanedText);

            Console.WriteLine(CleanTextIncludingSpaces(input));
        }

        static string CleanTextIncludingSpaces(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if ((('a' <= ch) && (ch <= 'z')) || (('A' <= ch) && (ch <= 'Z')) || (ch == 39) || (ch == '.'))
                //nu stiu cum scrie caracterul apostrof altfel decat prin codul unicode ' == 39
                {
                    sb.Append(ch);
                }
                else
                {
                    sb.Append(' ');
                }
            }

            string rezultat = sb.ToString();
            
            while (rezultat.IndexOf("  ") > 0)
            {
                rezultat = rezultat.Replace("  ", " ");
            }

            return rezultat;
        }

        static string CleanText(string input)
        {
            StringBuilder cleanedText = new StringBuilder();

            // Define the set of unwanted characters
            string unwantedChars = "^<,>&+@%$";

            // Iterate through each character of the input string
            foreach (char c in input)
            {
                if (!unwantedChars.Contains(c) || c.Equals(' '))
                {
                    cleanedText.Append(c);
                }
            }

            return cleanedText.ToString();
        }

        static string CleanTextWithCharArray(string input)
        {
            StringBuilder cleanedText = new StringBuilder();

            // Define the set of unwanted characters
            char[] unwantedCharacters = { '^', '<', '>', ',', '[', ']', '@', '%', '$', '&', '+', '_' };


            // Iterate through each character of the input string
            foreach (char c in input)
            {
                //Check if the character is not in the set of unwanted characters
                if (Array.IndexOf(unwantedCharacters, c) == -1)
                {
                    // Append the character to the cleaned text
                    cleanedText.Append(c);
                }
            }

            return cleanedText.ToString();
        }
    }
}
