using StudentManagementSystem.Enums;

namespace StudentManagementSystem.Extensions
{
    // Extension Methods
    public static class CourseExtensions
    {
        public static Course? FindByName(this List<Course> courses, Subject name)
        {
            return courses.FirstOrDefault(s => s.Name == name);
        }
    }
}
