using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
       
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        [Display(Name = "Released Date")]
        [Required]
        public DateTime? ReleasedDate { get; set; }

        [Display(Name = "Number is stock")]
        [Range(1, 20, ErrorMessage = "Amount should be between 1 and 20")]
        [Required]
        public int? NumberInStock { get; set; }

        //for new movie
        public MovieFormViewModel()
        {
            Id = 0;
        }

        //for edit movie
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleasedDate = movie.ReleasedDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}