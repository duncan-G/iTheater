using System.ComponentModel.DataAnnotations;

namespace Server.Models {
    public class Movies {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int Rating { get; set; }
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
    }
}