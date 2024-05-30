using StudentManagementSystem.People;

// extension method class

public static class StudentExtensions
{
    public static Student? FindByName(this List<Student> students, string name)
    {
        throw new NotImplementedException();
    }

    public static Student? FilterByAge(this List<Student> students, int age)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Student> FilterByGrade(this List<Student> students, int grade)
    {
        var filteredStudents = students.Where(s => s.Grade >= grade);
        return filteredStudents;
    }
}