using System;
using System.ComponentModel.DataAnnotations;

namespace Server.Models {
    public class Movie {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int Rating { get; set; }
        public DateTime Created { get; set; }
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
    }
}