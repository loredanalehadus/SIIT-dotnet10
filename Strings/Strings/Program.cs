public static class Program 
{
    public static void Main()
    {
        // Declare strings
        string myFirstString = "Hello world!";
        //same declarations
        //System.String myFirstString;
        //String myFirstString;

        Console.WriteLine(myFirstString);

        int myNumber = 42;
        Console.WriteLine(myNumber);

        string myNumberAsString = myNumber.ToString();

        // Manipulating strings;
        // Concatenation
        string firstName = "Ionel";
        string lastName = "Popescu";
        string fullName = firstName + " " + lastName;


        string fullNameWithConcat = string.Concat(firstName, " ", lastName);
        Console.WriteLine(fullName);
        Console.WriteLine(fullNameWithConcat);
        Console.WriteLine($"{firstName} {lastName}"); //string interpolation
    }
}