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
                });

            builder.Entity<MovieList> ().HasData (
                movieLists
            );

            builder.Entity<Movie> ().HasData (
                new {
                    Id = 1,
                        MoviesDbId = 443055,
                        Title = "Love of My Life",
                        PosterPath = "/7b19Sh0Aef5vGa0OFtvJxLe2SK9.jpg",
                        ReleaseDate = "2017-02-17",
                        Rating = 5,
                        Created = DateTime.Now,
                        MovieListId = 1,
                        UserId = 1
                },
                new {
                    Id = 2,
                        MoviesDbId = 454294,
                        Title = "The Kid Who Would Be King",
                        PosterPath = "/kBuvLX6zynQP0sjyqbXV4jNaZ4E.jpg",
                        ReleaseDate = "2019-01-16",
                        Rating = 3,
                        Created = DateTime.Now,
                        MovieListId = 1,
                        UserId = 1
                },
                new {
                    Id = 3,
                        MoviesDbId = 33125,
                        Title = "Border",
                        PosterPath = "/mmGwawOiUaP4Nkr2b1k0xsVhuY5.jpg",
                        ReleaseDate = "1997-07-13",
                        Rating = 2,
                        Created = DateTime.Now,
                        MovieListId = 1,
                        UserId = 1
                },
                new {
                    Id = 4,
                        MoviesDbId = 424783,
                        Title = "Bumblebee",
                        PosterPath = "/fw02ONlDhrYjTSZV8XO6hhU3ds3.jpg",
                        ReleaseDate = "2018-12-15",
                        Rating = 0,
                        Created = DateTime.Now,
                        MovieListId = 1,
                        UserId = 1
                },
                new {
                    Id = 5,
                        MoviesDbId = 543103,
                        Title = "Kamen Rider Heisei Generations FOREVER",
                        PosterPath = "/6sOFQDlkY6El1B2P5gklzJfVdsT.jpg",
                        ReleaseDate = "2018-12-22",
                        Rating = 0,
                        Created = DateTime.Now,
                        MovieListId = 1,
                        UserId = 1
                }
            );
        }
    }
}