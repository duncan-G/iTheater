using System;

namespace Server.Models {
    public class MovieList {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public bool Privacy { get; set; }
        public string DefaultImageUrl { get; set; }
        public DateTime Created { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}