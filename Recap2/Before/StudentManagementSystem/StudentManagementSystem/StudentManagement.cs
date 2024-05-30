using StudentManagementSystem.Enums;
using StudentManagementSystem.People;

namespace StudentManagementSystem
{
    // Define StudentManagementSystem class
    public class StudentManagement
    {
        private Repository<Student> studentRepository = new Repository<Student>();
        private Repository<Course> courseRepository = new Repository<Course>();
        private Repository<Teacher> teacherRepository = new Repository<Teacher>();

        // TODO: add methods to add new teachers and courses following the example above

        // Method to add a new student to the system
        public void AddStudent(string name, int age, int grade, string address)
        {
            throw new NotImplementedException();
        }

        public void AddCourse(int courseId, Subject name, int duration, Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public void AddTeacher(string name, int age, string email, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public void EnrollStudentInCourse(string studentName, Subject courseName)
        {
            var student = studentRepository.GetAll().FindByName(studentName);

            if (student == null)
            {
                Console.WriteLine($"Unable to enroll student {studentName} to course {courseName} because student does not exist.");
                return;
            }

            var course = courseRepository.GetAll().FindByName(courseName);
            if (course == null)
            {
                Console.WriteLine($"Unable to enroll student {studentName} to course {courseName} because course does not exist.");
                return;
            }

            course.Enroll(student);
        }

        public void DisplayStudentsInCourse(Subject courseName)
        {
            throw new NotImplementedException();
        }

        public void DisplayCoursesForStudent(string studentName)
        {
            var student = studentRepository.GetAll().FindByName(studentName);

            Console.WriteLine($"Courses enrolled by {student?.Name}:");
            foreach (var course in courseRepository.GetAll().Where(c => c.EnrolledStudents.Contains(student)))
            {
                Console.WriteLine(course.Name);
            }
        }

        // Method to find all students with a grade above a certain value
        public IEnumerable<Student> FindStudentsWithGradeAbove(int grade)
        {
            throw new NotImplementedException();
        }

        // Method to find all courses with a duration longer than a certain duration
        public IEnumerable<Course> FindCoursesWithDurationLongerThan(int duration)
        {
            throw new NotImplementedException();
        }

        // Method to find all teachers with an email address ending with a specific domain
        public IEnumerable<Teacher> FindTeachersWithEmailEndingWith(string domain)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Teacher> FindTeachersWithPhoneNumberStartingWith(string prefix)
        {
            throw new NotImplementedException();
        }

        public void DisplayStudentsInCoursesReport()
        {
            // Create an anonymous type report of students with their course names
            throw new NotImplementedException();
        }
    }
}