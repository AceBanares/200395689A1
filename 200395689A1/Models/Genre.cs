﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200395689A1.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}