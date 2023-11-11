using MovieApp.Models;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.ApiModels
{
    public class MoviesApiModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public DateTimeOffset DateReleased { get; set; }

        public DateTimeOffset DateUploaded { get; set; }

        public int GenreId { get; set; }

        [Required]
        [Range(0, 10)]
        public double Rating { get; set; }
    }
}
