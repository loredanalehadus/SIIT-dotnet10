namespace Dependencies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            BankAccount account = new BankAccount();
            Customer myClient = new Customer(account);

            Guid myGuid = Guid.NewGuid();
            Console.WriteLine(myGuid);
        }
    }
}
