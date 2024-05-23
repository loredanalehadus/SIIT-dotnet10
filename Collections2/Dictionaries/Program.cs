namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare
            Dictionary<string, double> studentGrades = new Dictionary<string, double>();

            // add items
            studentGrades.Add("Maria", 7.5);
            studentGrades.Add("Barbu", 8);
            studentGrades.Add("Ion", 5.6);
            studentGrades.Add("Greta", 9.2);
            //studentGrades.Add("Greta", 10); // keys in dict are unique

            // print
            foreach (var student in studentGrades)
            {
                Console.WriteLine($"{student.Key} --> {student.Value}");
            }

            Console.WriteLine();

            // print only keys
            var keys = studentGrades.Keys;
            foreach (var student in keys)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            // print only values
            var values = studentGrades.Values;
            foreach (var grade in values)
            {
                Console.WriteLine(grade);
            }

            //v1 change the value in a dictionary
            // check if value exists
            if (studentGrades.ContainsKey("Barbu"))
            {
                // change the grade
                studentGrades["Barbu"] = 10; // Prints: Barbu, 10
            }

            //v2
            double tempValue = 0;
            bool barbuExists = studentGrades.TryGetValue("Barbu", out tempValue);
            Console.WriteLine("Is Barbu in the dictionary?" + barbuExists);

            // Complex dictionary
            //inline initialization
            Dictionary<string, List<int>> complexDict = new Dictionary<string, List<int>>
            {
                { "Maria", new List<int>{ 8, 9, 7 } },
                { "Harry", new List<int>{ 10, 9, 7} }
            };

            //print the list of grades
            foreach(var key in complexDict.Keys)
            {
                var currentValues = complexDict[key];
                Console.Write($"{key} grades are: ");
                foreach(var value in currentValues)
                {
                    Console.Write(value);
                    Console.Write(", ");
                }
                Console.WriteLine();    
            }


            // dict of students and course with grades 
            Dictionary<string, Dictionary<string, List<double>>> studentsWithGradesPerCourse =
                new Dictionary<string, Dictionary<string, List<double>>>
            {
                { "Maria",
                    new Dictionary<string, List<double>> {
                        { "Math", new List<double> { 8, 9, 7 } },
                        { "Music", new List<double> { 6, 9.7, 7.5 } },
                    }
                },
                { "Victor",
                    new Dictionary<string, List<double>> {
                        { "Informatics", new List<double> { 8, 9, 7 } },
                        { "Phisics", new List<double> { 6, 9.7, 7.5 } },
                    }
                },
            };
        }
    }
}
