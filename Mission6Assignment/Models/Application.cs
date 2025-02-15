using System.ComponentModel.DataAnnotations;

namespace Mission6Assignment.Models
{
    public class Application
    {
        [Key]
        public int ApplicationID { get; set; }

        [Required]
        public required string Title { get; set; }

        [Required]
        public required string Category { get; set; }

        [Required]
        public required string Director { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public required string Rating { get; set; } 

        public bool? Edited { get; set; } 

        public string? LentTo { get; set; } 

        [MaxLength(25)]
        public string? Notes { get; set; } 
    }
}
