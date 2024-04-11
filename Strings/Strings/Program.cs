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
        string fullName = firstName + " " + lastName; // Ionel Popescu


        string fullNameWithConcat = string.Concat(firstName, " ", lastName);
        Console.WriteLine(fullName);
        Console.WriteLine(fullNameWithConcat);
        Console.WriteLine($"{firstName} {lastName}"); //string interpolation

        // Searching in strings
        int index = fullName.IndexOf("Io"); // 0
        index = fullName.IndexOf("Popescu"); //6
        index = fullName.IndexOf("POPESCU"); // -1 not found due to casing
        index = fullName.IndexOf("o", 1); // 1
        index = fullName.IndexOf("o", 3); // 7

        Console.WriteLine(index);

        // Extract substring
        // C:/Holiday/2025/1/nice_pic.png

        string path = "C:/Holiday/2025.03/1/nice_pic.png";

        // search the dot in string
        // int indexOfDot = path.IndexOf(".");
        int indexOfLastDot = path.LastIndexOf(".");

        //take the file extention
        string extention = path.Substring(indexOfLastDot + 1);

        //extract the file name
        int lastIndexOfSlash = path.LastIndexOf("/");
        int substringLength = indexOfLastDot - lastIndexOfSlash - 1;

        string fileName = path.Substring(lastIndexOfSlash + 1, substringLength);

        Console.WriteLine($"{fileName}.{extention}");
    }
}