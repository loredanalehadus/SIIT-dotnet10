using StudentManagementSystem.Enums;
using StudentManagementSystem.People;

namespace StudentManagementSystem.Extensions
{
    // Extension Methods
    public static class CourseExtensions
    {
        public static Course FindByName(this List<Course> courses, Subject name)
        {
            var course = courses.Where(c => c.Name == name).First();
            return course;
        }
    }
}