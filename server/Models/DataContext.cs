using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Server.Helpers;

namespace Server.Models {
    public class DataContext : DbContext {

        public DataContext (
            DbContextOptions<DataContext> options
        ) : base (options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieList> MovieLists { get; set; }

        protected override void OnModelCreating (ModelBuilder builder) {
            byte[] passwordHash, passwordSalt;
            GeneralHelpers.CreatePasswordHash ("password", out passwordHash, out passwordSalt);

            builder.Entity<User> ().HasData (
                new User { Id = 1, Email = "a@gmail.com", Salt = passwordSalt, PasswordHash = passwordHash }
            );

            var listNames = new List<string> {
                "Horror",
                "Sci Fi",
                "2018",
                "2017",
                "Action",
                "Drama",
                "The Best",
                "Movie Ever",
                "Comedy",
                "Romance"
            };
            var movieLists = listNames.Select ((name, index) =>
                new {
                    Id = index + 1,
                        Name = name,
                        Slug = GeneralHelpers.Slugify (name, index + 1),
                        UserId = 1,
                        Privacy = (index % 2 == 0),
                        Created = DateTime.Now,
                        DefaultImageUrl= "/assets/movie-poster-default.png"
                });

            builder.Entity<MovieList> ().HasData (
                movieLists
            );
        }
    }
}