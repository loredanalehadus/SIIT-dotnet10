using MethodOverriding;

public class Dog : Animal {
    public override void MakeSound()
    {
        Console.WriteLine("Dog makes a sound");
    }
}
