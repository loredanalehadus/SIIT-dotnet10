namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare stack
            Stack<string> cities = new Stack<string>();

            //add elements
            cities.Push("1. Iasi");
            cities.Push("2. Cluj");
            cities.Push("3. Brasov");
            cities.Push("4. Bucuresti");

            //check the last element without removing it
            Console.WriteLine($"Last element is: {cities.Peek()}");

            //removes the last element
            cities.Pop();
            Console.WriteLine($"Last element is: {cities.Peek()}");

            while (cities.Count > 0)
            {
                Console.WriteLine(cities.Pop());
            }

            PrintReversedIntegers();
        }

        static void PrintReversedIntegers()
        {
            //reading from relative path
            var myStack = ReadFromFile("input.txt");

            //reading from absolute path
            //var myStack = ReadFromFile("C:/Users/catal/Desktop/sample.txt");

            Console.WriteLine("Reversed integers:");
            while (myStack.Count > 0)
            {
                int number = myStack.Pop();
                Console.WriteLine(number);
            }
        }

        static Stack<int> ReadFromFile(string fileName)
        {
            var intStack = new Stack<int>();

            // check if file exists
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"File {fileName} is not found");
                return intStack;
            }

            var reader = new StreamReader(fileName);
            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (int.TryParse(line, out int value))
                    {
                        intStack.Push(value);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid integer in input: {line}");
                    }
                }
            }

            return intStack;
        }

    }
}
