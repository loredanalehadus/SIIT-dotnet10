namespace StudentManagementSystem.People
{
    // Teacher class inheriting from Person
    public class Teacher : Person
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Teacher(string name, int age, string email, string phoneNumber)
            : base(name, age)
        {
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public override string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}, Email: {Email}, Phone Number: {PhoneNumber}";
        }
    }
}