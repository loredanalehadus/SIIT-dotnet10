namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // create an instance of class Dog
            Dog dog = new Dog(); // default ctor initialization
            dog.Name = "Max";
            dog.Breed = Breed.Dalmatian;
            dog.SecurityNumber = 13213417463;

            dog.Bark();

            //Dog.OWNER = "Vasile"; //not possible
            //dog.OwnerName = "Vasile";

            Console.WriteLine(dog.Name);
            Console.WriteLine(Dog.OWNER);
            Console.WriteLine(dog.OwnerName);
            //Console.WriteLine(dog.SecurityNumber); //write only prop

            Dog beagle = new Dog("Spot", Breed.Beagle); // inline initialization
            beagle.Name = "Bella";
            Console.WriteLine($"{beagle.Name} - {beagle.Breed}");

            beagle.Bark();

            var dalmatian = new Dog();
            dalmatian.Bark();

            var myLevel = Level.Begginer;

            if (myLevel == Level.Begginer)
            {
                //
            }
            else if (myLevel == Level.Intermediate)
            {
                //
            }

            var whatLevel = (int) myLevel;
            Console.WriteLine(whatLevel);

            Console.WriteLine(Breed.NotKnown);


            Dog husky = new Dog
            {
                Name = "Paw",
                Breed = Breed.Husky
            };
        }
    }
}
