using StudentManagementSystem.People;

namespace StudentManagementSystem
{

    // Course class
    public class Course : IEnrollable
    {
        public int CourseID { get; set; }
        public Subject Name { get; set; }
        public int Duration { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> EnrolledStudents { get; set; }

        public Course(int courseId, Subject name, int duration, Teacher teacher)
        {
            CourseID = courseId;
            Name = name;
            Duration = duration;
            Teacher = teacher;
            EnrolledStudents = new List<Student>();
        }

        public void Enroll(Student student)
        {
            EnrolledStudents.Add(student);
        }
    }
}