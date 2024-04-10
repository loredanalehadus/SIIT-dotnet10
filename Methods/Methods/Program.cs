static class Program
{
    static void Main(string[] args)
    {
        // call the method;
        PrintName();

        Add(2, 3);
        Add(6543, 2131);
        Add(-50, 12);

        Console.WriteLine("Please input the first number");
        var firstNumber = ReadFromConsole();

        Console.WriteLine("Please input the second number");
        var secondNumber = ReadFromConsole();

        Add(firstNumber, secondNumber);

        var result = ReadFromConsole();
        Console.WriteLine($"The result from console is {result}");

        DisplayNumbers();
        DisplayNumbers(4, 7);
        DisplayNumbers(50);
        DisplayNumbers(end: 110, start: 100);

        Console.WriteLine(ComputeSum());
        var sum = ComputeSum(1, 45, -8, 12);
        Console.WriteLine(sum);

        Add(3, 4);
        Add(4.6m, 2.0m);
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

    // overload method Add
    static void Add(int? a, int? b)
    {
        if (a == null || b == null)
        {
            Console.WriteLine("Either one of the input or both are not numeric values. Please try again.");
            return;
        }

        Console.WriteLine(a + b);
    }

    static void Add(float a, float b)
    {
        Console.WriteLine(a + b);
    }

    static void Add(decimal a, decimal b)
    {
        Console.WriteLine(a + b);
    }

    // Optional Parameters

    static void DisplayNumbers(int start = 0, int end = 100)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write($"{i}, ");
        }

        Console.WriteLine("<<<");
    }

    // Variable number of parameters
    static long ComputeSum(params int[] numbers)
    {
        long sum = 0;

        foreach (int numar in numbers)
        {
            sum += numar;

            //sum = sum + numar;
        }

        return sum;
    }
}









