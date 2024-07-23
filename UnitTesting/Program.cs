namespace UnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Sum(10, 20));
        }
    }
}
