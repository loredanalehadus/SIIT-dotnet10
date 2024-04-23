namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // create an instance of class Dog
            Dog dog = new Dog(); // default ctor initialization
            dog.Name = "Max";
            dog.Breed = "Dalmatian";

            Console.WriteLine(dog.Name);

            Dog beagle = new Dog("Spot", "Beagle"); // inline initialization
            beagle.Name = "Bella";
            Console.WriteLine($"{beagle.Name} - {beagle.Breed}");
        }
    }
}
