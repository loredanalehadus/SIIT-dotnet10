namespace Handout
{
    internal class Program
    {
        static void Main(string[] args)
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
