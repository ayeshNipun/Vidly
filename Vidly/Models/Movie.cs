using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Released Date")]
        public DateTime ReleasedDate { get; set; }

        [Display(Name = "Number is stock")]
        [Range(1, 20, ErrorMessage = "Amount should be between 1 and 20")]
        public int NumberInStock { get; set; }
    }
}