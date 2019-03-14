using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Show
    {
        public int Id { get; set; }
        //[Key]
        //[Column(Order =1)]
        public int MovieId { get; set; }

        //[Key]
        //[Column(Order = 2)]
        public int TheatreId { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Theatre Theatre { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ShowTime { get; set; }
        public string Status { get; set; }
    }
}
