static class Program
{
    static void Main(string[] args)
    {
        // call the method;
        PrintName();

        //Add(2, 3);
        //Add(6543, 2131);
        //Add(-50, 12);

        Console.WriteLine("Please input the first number");
        var firstNumber = ReadFromConsole();

        Console.WriteLine("Please input the second number");
        var secondNumber = ReadFromConsole();

        Add(firstNumber, secondNumber);

        //var result = ReadFromConsole();
        //Console.WriteLine($"The result from console is {result}");
    }

    static int? ReadFromConsole()
    {
        var line = Console.ReadLine();

        bool success = int.TryParse(line, out int result);

        if (success)
        {
            return result;
        }
        else
        {
            Console.WriteLine("Sorry, the input cannot be tranformed to a number.");
        }

        return null;
    }

    // declare new method
    static void PrintName()
    {
        Console.WriteLine("My name is Simon");
    }

    static void Add(int a, int b)
    {
        //int a = 2;
        //int b = 3;

        Console.WriteLine(a + b);
    }

    static void Add(int? a, int? b)
    {
        if (a == null || b == null)
        {
            Console.WriteLine("Either one of the input or both are not numeric values. Please try again.");
            return;
        }

        Console.WriteLine(a + b);
    }
}









