namespace Handout2
{
    internal class Program
    {
        static void Main()
        {
            Rabbit myRabbit = new Rabbit(
                EyeColor.Blue,
                FurColor.White, 
                Gender.Female, 
                new DateTime(2022, 3, 15));

            Console.WriteLine($"The rabbit's age in years: {myRabbit.GetAgeInYears()}");
        }
    }
}
