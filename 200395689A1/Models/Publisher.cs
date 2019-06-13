﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200395689A1.Models
{
    public class Publisher
    {
        public int PublisherID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Website { get; set; }
    }
}