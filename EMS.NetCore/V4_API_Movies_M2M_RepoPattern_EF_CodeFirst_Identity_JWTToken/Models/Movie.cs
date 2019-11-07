using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace V4_API_Movies_M2M_RepoPattern_EF_CodeFirst_Identity_JWTToken.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [DisplayName("Release Date")]
        [DataType(DataType.Date)]
        [DateValidator]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public Genre Genre { get; set; }
        [Required]
        [Range(1, 10, ErrorMessage = "Rating should be between 1 and 10")]
        public decimal Rating { get; set; }
        public ICollection<MovieActor> MovieActors { get; set; }

    }
}
