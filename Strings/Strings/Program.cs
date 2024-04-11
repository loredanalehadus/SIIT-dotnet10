using System.Diagnostics;
using System.Text;

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

        #region Extract substring
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
        #endregion

        #region Comparing strings
        string str1 = "oradea";
        string str2 = "Oradea";

        int result = string.Compare(str1, str2, true); //casing matters

        if (result == 0)
        {
            Console.WriteLine("str1 equals str2");
        }

        if (str1 == str2)
        {
            //
        }

        if (str1.Equals(str2))
        {
            //
        }
        #endregion


        #region Splitting
        string listOfCities = "Londra, Paris, Iasi, Cluj, Bucuresti.";
        string[] cities = listOfCities.Split(',', ' ', '.');

        foreach (string city in cities)
        {
            if (!string.IsNullOrWhiteSpace(city))
            {
                Console.WriteLine(city.ToUpper());
                //Console.WriteLine(city.ToLower());
            }
        }
        #endregion

        // Trim

        string mySpacedString = "      this is a string     ";

        Console.WriteLine(mySpacedString.TrimStart());
        Console.WriteLine(mySpacedString.TrimEnd());
        mySpacedString.Trim();

        string myFunnyString = "-++++++this is a ++++ string ++++++ ------";
        Console.WriteLine(myFunnyString.Trim('+', ' ', '-'));
        Console.WriteLine(myFunnyString.Replace("+", ""));

        // with classic concatenation

        //var stopWacth = new Stopwatch();
        //string myCoolString = "Counting bottle: ";

        //stopWacth.Start();

        //for (int i = 0; i < 10000; i++)
        //{
        //    myCoolString += i.ToString();
        //    Console.WriteLine(myCoolString);
        //}

        //stopWacth.Stop();
        //Console.WriteLine(stopWacth.Elapsed.TotalSeconds.ToString());
        //64.2847839

        // with string builder

        StringBuilder stringBuilder = new StringBuilder();

        var stopWacth2 = new Stopwatch();
        string myCoolString = "Counting bottle: ";

        stopWacth2.Start();

        stringBuilder.Append(myCoolString);

        for (int i = 0; i < 10000; i++)
        {
            //myCoolString += i.ToString();
            stringBuilder.Append(i.ToString());
            Console.WriteLine(i);
        }

        Console.WriteLine(stringBuilder.ToString());

        stopWacth2.Stop();
        Console.WriteLine(stopWacth2.Elapsed.TotalSeconds.ToString());
        //1.1255619
    }
}