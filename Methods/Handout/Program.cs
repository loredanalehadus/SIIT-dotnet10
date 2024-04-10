// ⚠️ Overloading not working without the predefined Main() method
//static int GetMin(int a, int b)
//{
//    if (a < b)
//    {
//        return a;
//    }
//    return b;
//}

//static float GetMin(float a, float b)
//{
//    if (a < b)
//    {
//        return a;
//    }
//    return b;
//}


Handout1();
Handout2();

// another line of code
//Handout 1
// Write a method that prints if a number read from the console is positive or nagative
static void Handout1()
{
    bool isNumber = int.TryParse(Console.ReadLine(), out int value);

    if (isNumber)
    {
        PrintSign(value);
    }
    else
    {
        Console.WriteLine("This is not a number");
    }

    static void PrintSign(int number)
    {
        if (number > 0)
            Console.WriteLine("Positive");
        else if (number < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Zero");
    }

}

//Handout 2
//Write a method GetMin() with two parameters that returns the smallest of two integers. Write a
//method that reads 2 integers from the console and prints the smalles of them using the
//method GetMin().

static void Handout2()
{
    PrintMinFloat();

    static int GetMin(int a, int b)
    {
        if (a < b)
        {
            return a;
        }
        return b;
    }

    static void PrintMinFloat()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int min = GetMin(a, b);
        Console.WriteLine($"Min between {a} and {b} is {min}");
        //Console.WriteLine($"Min between {a} and {b} is {GetMin(a, b)}");
    }
}