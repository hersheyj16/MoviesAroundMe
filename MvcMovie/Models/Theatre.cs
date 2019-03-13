using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Theatre
    {
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        public string address { get; set; }
        public string phone { get; set; }
        public double? lat { get; set; }
        public double? lon { get; set; }
    }
}
