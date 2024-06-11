using System.ComponentModel.DataAnnotations;

namespace FirstAppi.Models
{
    public class Student
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Range(18, 21)]
        public int Age { get; set; }
        public int Id { get; set; }

        public double Grade { get; set; }
    }
}
