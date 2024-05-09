namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("51545874854454", "Gigi", "Popescu");

            //person.Cnp = "1245245";
            //person.Salary = 600;

            Console.WriteLine(person.Salary);

            person.IncreaseSalary();
            Console.WriteLine(person.Salary);

            person.GetMerried("Ionescu");

            Console.WriteLine(person.Salary);
        }
    }
}
