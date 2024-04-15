﻿using System.Text;

namespace Team4
{
    internal class Program
    {
        static void Main()
        {
            string input = "restart";

            string modifiedString = ChangeFirstCharOccurrences(input);

            Console.WriteLine(modifiedString);
        }

        static string ChangeFirstCharOccurrences(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char firstLetter = input[0]; //input.Substring(0, 1);
            var sb = new StringBuilder();
            sb.Append(firstLetter);

            // Start iterating from index 1
            for (int i = 1; i < input.Length; i++)
            {
                // Replace occurrences of firstChar with '$'
                if (input[i] == firstLetter)
                {
                    //input = input.Substring(0, i) + '$' + input.Substring(i + 1);
                    sb.Append('$');
                }
                else
                {
                    sb.Append(input[i]);
                }
            }

            //return input;
            return sb.ToString();
        }
    }
}
