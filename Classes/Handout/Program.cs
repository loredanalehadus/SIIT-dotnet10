namespace Handout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PersonHandout();

            BeerCounterHandout();
        }

        static void BeerCounterHandout()
        {
            string command = Console.ReadLine();
            while (!command.Equals("End"))
            {
                string[] values = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                BeerCounter.BuyBeer(int.Parse(values[0]));
                BeerCounter.DrinkBeer(int.Parse(values[1]));

                command = Console.ReadLine();
            }

            Console.WriteLine($"{BeerCounter.beerInStock} {BeerCounter.beersDrankCount}");
        }

        static void PersonHandout()
        {
            Person person1 = new Person();
            person1.Name = "John";
            person1.Age = 20;

            Person person2 = new Person
            {
                Name = "Mary",
                Age = 18
            };

            Person person3 = new Person("Nick", 43);
        }
    }
}
