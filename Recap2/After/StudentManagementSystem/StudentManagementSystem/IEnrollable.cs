using StudentManagementSystem.People;

namespace StudentManagementSystem
{
    // Interface for enrollable entities
    public interface IEnrollable
    {
        void Enroll(Student student);
    }
}