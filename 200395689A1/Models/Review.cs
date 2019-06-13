using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200395689A1.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Reviews { get; set; }
        [Display(Name = "Number of stars (1-5)")] [Range(1,5)]
        public byte Stars { get; set; }
    }
}