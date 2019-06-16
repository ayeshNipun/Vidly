﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }

        public DateTime DateAdded { get; set; }
        
        public DateTime ReleasedDate { get; set; }
        
        [Range(1, 20, ErrorMessage = "Amount should be between 1 and 20")]
        public int NumberInStock { get; set; }
    }
}