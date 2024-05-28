namespace Lambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lambdas

            // count odd numbers
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // classic
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    count++;
                }
            }
            Console.WriteLine($"Classic: Odd number count: {count}");

            // lambda
            var oddNumbersCount = numbers.Count(n => n % 2 == 1);
            Console.WriteLine($"Lambda: Odd number count: {oddNumbersCount}");

            // extract odd numbers
            var oddNumbers = numbers.Where(x => x % 2 == 1).ToArray();

            List<Person> people = new List<Person>()
            {
                new Person { FirstName = "John", LastName = "Doe", City = "New York", Country = "USA" },
                new Person { FirstName = "Jane", LastName = "Smith", City = "Los Angeles", Country = "USA" },
                new Person { FirstName = "David", LastName = "Brown", City = "London", Country = "UK" },
                new Person { FirstName = "Emily", LastName = "Johnson", City = "Toronto", Country = "Canada" },
                new Person { FirstName = "Michael", LastName = "Lee", City = "Sydney", Country = "Australia" }
            };

            // count all people in USA
            var peopleInUsa = people.Count(x => x.Country == "USA");

            // order people by country and then by city desc
            var orderedByCountry = people.OrderByDescending(x => x.City).OrderBy(x => x.Country).ToList();

            #endregion

            #region Extention methods 

            string sentence = "My awesome students";
            // static method call
            int wordCount = Extensions.WordCount(sentence);

            // extention method call
            sentence.WordCountExtension();

            var peopleInUsa2 = people.Filter1("USA");

            var a = 10;
            var b = 5;
            
            if(a.GreaterThan(b))
            {
                Console.WriteLine("A is greater then B");
            }

            var peopleInUsa3 = people.Filter(GroupType.Country, "USA").ToList();
            var peopleInIasi = people.Filter(GroupType.City, "Iasi");
            

            #endregion

        }
    }
}
