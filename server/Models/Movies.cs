using System;
using System.ComponentModel.DataAnnotations;

namespace Server.Models {
    public class Movie {
        public int Id { get; set; }
        public string Title { get; set;}
        public int MoviesDbId { get; set; }
        public string ReleaseDate { get; set; }
        public string PosterPath { get; set; }
        public int Rating { get; set; }
        public DateTime Created { get; set; }
        public int MovieListId { get; set; }
        public virtual MovieList MovieList { get; set; }
    }
}