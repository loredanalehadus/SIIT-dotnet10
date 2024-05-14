namespace MethodOverriding
{

    /*
Method overriding is a concept where a derived class provides a new implementation of a base class method, and the new implementation is used when calling the method on an object of the derived class.
Method overriding is achieved by using the override keyword in the derived class method.
The base class method should be marked as virtual and the derived class method must have the same name, return type, and method signature.
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            // situation where the variable is declared as the base class, not the child class
            Animal cat1 = GetAnimal("miau");

            //Cat cat2 = new Animal();  // Compilation error - cannot implicitly convert Animal to Cat

            cat1.MakeSound();

            Cat cat2 = new Cat();
            cat2.MakeSound();

            Animal animal1 = new Animal();

            animal1.MakeSound(); // Output: "Animal makes a sound."
            cat1.MakeSound();    // Output: "Cat makes a sound." (overriding)
            cat2.MakeSound();    // Output: "Cat makes a sound."
        }

        public static Animal GetAnimal(string sound)
        {
            switch (sound)
            {
                case "ham":
                    return new Dog();
                case "miau":
                    return new Cat();
                default: return new Animal();
            }
        }
    }
}
