namespace Anonymous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ref -  pass by reference
            int a = 5;

            // method invocation
            Example1(ref a);
            Console.WriteLine(a);

            // out
            int b;
            Example2(out b);
            Console.WriteLine(b);


            int x;
            bool isNumber = int.TryParse(/*Console.ReadLine()*/ "5", out x);
            Console.WriteLine(x);

            // in 
            int y = 20;
            Example3(in y);

            Console.WriteLine();

            char c = 'k';
            char d = 'm';
            Swap(ref c, ref d);


            Console.WriteLine(c);
            Console.WriteLine(d);



            Console.WriteLine();

            //Anonymous
            var point = new { X = 10, Y = 5 };

            var student = new
            {
                Name = "Student 1",
                Course = ".Net",
                Grade = 9.4
            };

            Console.WriteLine(student.Name, student.Course, student.Grade);

            var studentConcrete = new Student { Name = "Student 2", Course = ".Net" };

            // 
            var myCar = new
            {
                Make = new
                {
                    Model = "Fabia",
                    LaunchedYear = 2024
                },
                Color = "red"
            };

            Console.WriteLine(myCar.Make.Model);
            Console.WriteLine(myCar.Color);


            var people = new List<Person>();

            people.Add(new Person
            {
                Age = 30,
                HairColor = "red",
                Profession = "Teacher",
                ShoeSize = 38
            });

            people.Add(new Person
            {
                Age = 30,
                HairColor = "black",
                Profession = "IT",
                ShoeSize = 42
            });

            var ageProfession = people.Select(pers => new
            {
                Age = pers.Age / 2,
                Profession = "Dr. " + pers.Profession 
            }).ToList();
        }

        class Student
        {
            public string Name { get; set; }
            public string Course { get; set; }
            public double Grade { get; set; }
        }


        //method declaration
        static void Example1(ref int value)
        {
            value = 10;
        }

        static void Example2(out int value)
        {
            value = 10;
        }

        static void Example3(in int value)
        {
            // value = 10; // cannot change the value
            Console.WriteLine(value);
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
