namespace Handout
{
    /*
     Create a class Animal, which hold two fields:
    name: string
    favouriteFood: string
    Animal has one virtual method ExplainSelf(): string.
    You should add two new classes Cat and Dog. There override ExplainSelf() method by adding concrete animal sound on new line. (Look at examples below)
    You should be able to use the class like this:
    Animal cat = new Cat("Suzy", "Whiskas");
    Animal dog = new Dog("Toto", "Meat");

    Console.WriteLine(cat.ExplainSelf());
    Console.WriteLine(dog.ExplainSelf());

    Output
    I am Suzy and my fovourite food is Whiskas MEEOW
    I am Toto and my fovourite food is Meat WOOF

     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Suzy", "Whiskas");
            Animal dog = new Dog("Toto", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
