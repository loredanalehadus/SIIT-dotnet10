namespace MethodHiding
{

    /*

    Method hiding is a concept where a derived class defines a new method with the same name as a method in the base class, effectively hiding the base class method.
    Method hiding is achieved by using the new keyword in the derived class method.
    The base class method should be marked as virtual to be hidden by the derived class method.
    The derived class method must have the same name as the base class method, but it can have a different return type or method signature.

     */

    internal class Program
    {
        static void Main(string[] args)
        {
            // Method Hiding
            Animal animal1 = new Animal();
            Animal cat1 = new Cat();
            // Cat animal2 = new Animal(); // Compilation error - cannot implicitly convert Animal to Cat
            Cat cat2 = new Cat();

            animal1.MakeSound(); // Output: "Animal makes a sound."
            cat1.MakeSound();    // Output: "Animal makes a sound." (hiding)
            cat2.MakeSound();    // Output: "Cat makes a sound."
        }
    }
}