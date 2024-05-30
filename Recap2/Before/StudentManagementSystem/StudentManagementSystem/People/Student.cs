namespace StudentManagementSystem.People
{
    // Student class inheriting from Person
    public class Student : Person
    {
        public int Grade { get; set; }
        public string Address { get; set; }

        public Student(string name, int age, int grade, string address)
            : base(name, age)
        {
            Grade = grade;
            Address = address;
        }

        public override string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}, Grade: {Grade}, Address: {Address}";
        }
    }
}