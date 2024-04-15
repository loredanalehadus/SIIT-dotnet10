namespace Team6
{
    class Program
    {
        static void Main()
        {
            string input1 = "abc";
            string input2 = "string";

            string output1 = AddSuffix(input1);
            string output2 = AddSuffix(input2);

            Console.WriteLine($"Input: '{input1}', Output: '{output1}'");
            Console.WriteLine($"Input: '{input2}', Output: '{output2}'");
        }

        static string AddSuffix(string input)
        {
            // If the string length is less than 3, leave it unchanged
            if (input.Length < 3)
            {
                return input;
            }

            // If the string already ends with 'ing', add 'ly' instead
            if (input.EndsWith("ing"))
            {
                return input + "ly";
            }

            // Otherwise, add 'ing' at the end
            return input + "ing";
        }
    }
}
