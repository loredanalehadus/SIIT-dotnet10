namespace MethodHiding
{

    /*
     Method Shadowing:
    Method shadowing is similar to method hiding, where a derived class defines a new method with the same name as a method in the base class.
    However, in method shadowing, the base class method is not marked as virtual, and the derived class method does not use the new keyword.
    This can lead to unexpected behavior as the base class method may still be invoked when calling the method on an object of the derived class.
     */

    public class Program
    {
        static void Main()
        {
            // Method Shadowing
            Animal animal1 = new Animal();
            Animal cat1 = new Cat();
            //Cat animal2 = new Animal(); // Compilation error - cannot implicitly convert Animal to Cat
            Cat cat2 = new Cat();

            animal1.MakeSound(); // Output: "Animal makes a sound."
            cat1.MakeSound();    // Output: "Animal makes a sound." (shadowing)
            cat2.MakeSound();    // Output: "Cat makes a sound."  
        }
    }
}