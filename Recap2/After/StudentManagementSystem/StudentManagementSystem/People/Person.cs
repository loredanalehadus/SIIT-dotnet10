namespace StudentManagementSystem.People
{
    // Define abstract Person class
    public abstract class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty or null.");
                }

                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18 || value > 99)
                    throw new ArgumentException("Age should be between 18 and 99.");

                age = value;
            }
        }

        public abstract string GetDetails();
    }
}