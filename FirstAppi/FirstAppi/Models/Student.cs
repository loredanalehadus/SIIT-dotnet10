using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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

        [EmailAddress]
        public string Email { get; set; }

        public List<string>? Teachers { get; set; }
    }
}
