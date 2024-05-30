using StudentManagementSystem.People;

namespace StudentManagementSystem
{
    // Extension Methods
    public static class StudentExtensions
    {
        public static IEnumerable<Student> FilterByGrade(this List<Student> students, int grade)
        {
            return students.Where(s => s.Grade > grade);
        }

        public static IEnumerable<Student> FilterByAge(this List<Student> students, int age)
        {
            return students.Where(s => s.Age > age);
        }

        public static Student? FindByName(this List<Student> students, string name)
        {
            return students.FirstOrDefault(s => s.Name == name);
        }
    }
}
