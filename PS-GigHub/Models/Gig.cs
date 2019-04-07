using System;
using System.ComponentModel.DataAnnotations;

namespace PS_GigHub.Models
{
    public class Gig
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser Author { get; set; }

        [Required]
        public Genre Genre { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }
    }
}