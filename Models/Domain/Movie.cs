 using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NerdFlix.Models.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? ReleaseYear { get; set; }

        public string? MovieVideo { get; set; }  // stores movie video name with extension (eg, video0001.mp4)
        [Required]
        public string? Cast { get; set; }
        [Required]
        public string? Director { get; set; }

        [NotMapped]
        // Use this property to handle video file uploads
        public IFormFile? VideoFile { get; set; }
        [NotMapped]
        [Required]
        public List<int>? Genres { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem>? GenreList { get; set; }
        [NotMapped]
        public string? GenreNames { get; set; }

        [NotMapped]
        public MultiSelectList? MultiGenreList { get; set; }

    }
}
