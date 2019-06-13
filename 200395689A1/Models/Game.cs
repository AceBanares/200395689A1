using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200395689A1.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public double Price { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Display(Name = "Minimum Requirements")]
        public string Minimum_Requirements { get; set; }
        public string Publisher { get; set; }
        public string Developer { get; set; }
        [Display(Name = "Genre(s) (one or more)")]
        public string Genre { get; set; }
        [Display(Name = "Review(s) (zero or more)")]
        public string Review { get; set; }
    }
}