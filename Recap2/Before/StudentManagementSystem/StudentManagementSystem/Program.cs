using StudentManagementSystem.Enums;

namespace StudentManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of StudentManagementSystem
            var sms = new StudentManagement();

            // Add teachers
            sms.AddTeacher("John Doe", 35, "johndoe@scoalainformala.ro", "+50123456789");
            sms.AddTeacher("Jane Smith", 40, "janesmith@gmail.com", "+40740123456");
            sms.AddTeacher("Alex Johnson", 30, "alex@devuniversity.com", "+40712145487");

            // Add courses
            sms.AddCourse(1, Subject.Mathematics, 10, sms.FindTeachersWithEmailEndingWith("scoalainformala.ro").First());
            sms.AddCourse(2, Subject.Science, 8, sms.FindTeachersWithEmailEndingWith("gmail.com").First());
            sms.AddCourse(3, Subject.Informatics, 8, sms.FindTeachersWithEmailEndingWith("devuniversity.com").First());
            sms.AddCourse(4, Subject.Arts, 2, sms.FindTeachersWithPhoneNumberStartingWith("+40").First());

            // Add students
            sms.AddStudent("Alice", 20, 9, "123 Main St");
            sms.AddStudent("Bob", 22, 11, "456 Elm St");


            // Enroll students in a course
            sms.EnrollStudentInCourse("Alice", Subject.Mathematics);
            sms.EnrollStudentInCourse("Alice", Subject.Informatics);
            sms.EnrollStudentInCourse("Alice", Subject.Arts);
            sms.EnrollStudentInCourse("Bob", Subject.Informatics);

            // Display students in a course
            sms.DisplayStudentsInCourse(Subject.Mathematics);
            sms.DisplayStudentsInCourse(Subject.Informatics);

            Console.WriteLine("--------------------------");

            // Display courses for a student
            sms.DisplayCoursesForStudent("Alice");
            sms.DisplayCoursesForStudent("Bob");

            Console.WriteLine("--------------------------");

            // Find students with grade above a certain value
            var highGradeStudents = sms.FindStudentsWithGradeAbove(9);
            Console.WriteLine("Students with grade above 9:");
            foreach (var student in highGradeStudents)
            {
                Console.WriteLine(student.GetDetails());
            }

            Console.WriteLine("--------------------------");

            // Find courses with duration longer than a certain value
            var longCourses = sms.FindCoursesWithDurationLongerThan(5);
            Console.WriteLine("Courses with duration longer than 5:");
            foreach (var course in longCourses)
            {
                Console.WriteLine(course.Name);
            }

            Console.WriteLine("--------------------------");

            // Find teachers with email ending with a specific domain
            var specificDomainTeachers = sms.FindTeachersWithEmailEndingWith("scoalainformala.ro");
            Console.WriteLine("Teachers with email ending with 'scoalainformala.ro':");
            foreach (var teacher in specificDomainTeachers)
            {
                Console.WriteLine(teacher.GetDetails());
            }

            Console.WriteLine("--------------------------");

            // Find teachers with phone number starting with a certain prefix
            var phoneTeachers = sms.FindTeachersWithPhoneNumberStartingWith("+40");
            Console.WriteLine("Teachers with phone number starting with +40:");
            foreach (var teacher in phoneTeachers)
            {
                Console.WriteLine(teacher.GetDetails());
            }

            Console.WriteLine("--------------------------");

            // Create an anonymous type report of students with their course names
            sms.DisplayStudentsInCoursesReport();

            Console.ReadLine();
        }
    }
}