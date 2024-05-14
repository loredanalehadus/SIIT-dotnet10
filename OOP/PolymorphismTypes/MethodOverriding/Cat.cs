using MethodOverriding;

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat makes a sound");
    }
}
