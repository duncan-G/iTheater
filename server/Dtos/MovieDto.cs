using System;

namespace Server.Dtos {
    public class MovieDto {
        public int id { get; set; }
        public int moviesDbId { get; set; }
        public string title { get; set;}
        public int rating { get; set; }
        public string posterPath { get; set; }
        public DateTime created { get; set; }
        public int movieListId { get; set;}
    }
}