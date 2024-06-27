using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace FirstAppi.Models
{
    // model class
    public class Movie
    {
        public int Id { get; set; }

        //[Required]
        [StringLength(50, ErrorMessage = "Title cannot exceed 50 alphanumeric characters" )]
        public string Title { get; set; } = string.Empty;

        public DateTime ReleaseDate { get; set; }
        public double Rating { get; set; }

        [Range(30, 250, ErrorMessage = "Movie should have at least 30 min duration.")]
        public ushort Duration { get; set; }
    }
}
