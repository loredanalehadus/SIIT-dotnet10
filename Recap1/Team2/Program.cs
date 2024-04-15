using System.Text;

namespace Team2
{

    class Program
    {
        static void Main()
        {
            string input = "hello world, how are you?";
            
            string capitalized = SplitSentenceIntoWords(input);
            Console.WriteLine(capitalized);
        }

        static string SplitSentenceIntoWords(string sentence)
        {
            string[] words = sentence.Split(" ");

            StringBuilder sb = new StringBuilder();

            foreach (string word in words)
            {
                var capitalizedWord = CapitalizeFirstAndLastLetters(word);
                sb.Append(capitalizedWord);
                sb.Append(" ");
            }

            return sb.ToString();
        }

        static string CapitalizeFirstAndLastLetters(string word)
        {
            string firstLetter = word.Substring(0, 1).ToUpper();
            string lastLetter = word.Substring(word.Length - 1).ToUpper();

            var formattedWord = firstLetter + word.Substring(1, word.Length - 2) + lastLetter;
            //Console.WriteLine(formattedWord);
            return formattedWord;
        }

        static string CapitalizeFirstAndLastLetters1(string input)
        {
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1, words[i].Length - 2) + char.ToUpper(words[i][words[i].Length - 1]);
                }
                else
                {
                    words[i] = char.ToUpper(words[i][0]).ToString();
                }
            }

            return string.Join(" ", words);
        }

    }
}
