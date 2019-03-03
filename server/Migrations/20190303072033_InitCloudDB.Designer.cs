﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Models;

namespace server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190303072033_InitCloudDB")]
    partial class InitCloudDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Server.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<int>("MovieListId");

                    b.Property<int>("MoviesDbId");

                    b.Property<string>("PosterPath");

                    b.Property<int>("Rating");

                    b.Property<string>("ReleaseDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("MovieListId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9878),
                            MovieListId = 1,
                            MoviesDbId = 443055,
                            PosterPath = "/7b19Sh0Aef5vGa0OFtvJxLe2SK9.jpg",
                            Rating = 5,
                            ReleaseDate = "2017-02-17",
                            Title = "Love of My Life"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2019, 3, 2, 23, 20, 33, 112, DateTimeKind.Local).AddTicks(1260),
                            MovieListId = 1,
                            MoviesDbId = 454294,
                            PosterPath = "/kBuvLX6zynQP0sjyqbXV4jNaZ4E.jpg",
                            Rating = 3,
                            ReleaseDate = "2019-01-16",
                            Title = "The Kid Who Would Be King"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2019, 3, 2, 23, 20, 33, 112, DateTimeKind.Local).AddTicks(1284),
                            MovieListId = 1,
                            MoviesDbId = 33125,
                            PosterPath = "/mmGwawOiUaP4Nkr2b1k0xsVhuY5.jpg",
                            Rating = 2,
                            ReleaseDate = "1997-07-13",
                            Title = "Border"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2019, 3, 2, 23, 20, 33, 112, DateTimeKind.Local).AddTicks(1288),
                            MovieListId = 1,
                            MoviesDbId = 424783,
                            PosterPath = "/fw02ONlDhrYjTSZV8XO6hhU3ds3.jpg",
                            Rating = 0,
                            ReleaseDate = "2018-12-15",
                            Title = "Bumblebee"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2019, 3, 2, 23, 20, 33, 112, DateTimeKind.Local).AddTicks(1292),
                            MovieListId = 1,
                            MoviesDbId = 543103,
                            PosterPath = "/6sOFQDlkY6El1B2P5gklzJfVdsT.jpg",
                            Rating = 0,
                            ReleaseDate = "2018-12-22",
                            Title = "Kamen Rider Heisei Generations FOREVER"
                        });
                });

            modelBuilder.Entity("Server.Models.MovieList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("DefaultImageUrl");

                    b.Property<string>("Name");

                    b.Property<bool>("Privacy");

                    b.Property<string>("Slug");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("MovieLists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2019, 3, 2, 23, 20, 33, 109, DateTimeKind.Local).AddTicks(2916),
                            Name = "Horror",
                            Privacy = true,
                            Slug = "horror-1",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9116),
                            Name = "Sci Fi",
                            Privacy = false,
                            Slug = "sci-fi-2",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9298),
                            Name = "2018",
                            Privacy = true,
                            Slug = "2018-3",
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9322),
                            Name = "2017",
                            Privacy = false,
                            Slug = "2017-4",
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9349),
                            Name = "Action",
                            Privacy = true,
                            Slug = "action-5",
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9373),
                            Name = "Drama",
                            Privacy = false,
                            Slug = "drama-6",
                            UserId = 1
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9440),
                            Name = "The Best",
                            Privacy = true,
                            Slug = "the-best-7",
                            UserId = 1
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9480),
                            Name = "Movie Ever",
                            Privacy = false,
                            Slug = "movie-ever-8",
                            UserId = 1
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9503),
                            Name = "Comedy",
                            Privacy = true,
                            Slug = "comedy-9",
                            UserId = 1
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9531),
                            Name = "Romance",
                            Privacy = false,
                            Slug = "romance-10",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Server.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("Salt");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "a@gmail.com",
                            PasswordHash = new byte[] { 214, 170, 170, 219, 70, 12, 233, 137, 168, 40, 128, 239, 145, 82, 137, 99, 150, 213, 59, 151, 222, 235, 223, 188, 69, 48, 167, 203, 32, 31, 13, 88, 95, 80, 0, 44, 251, 206, 228, 251, 52, 72, 218, 99, 183, 52, 45, 6, 83, 220, 24, 174, 224, 96, 81, 19, 12, 220, 43, 141, 67, 81, 62, 206 },
                            Salt = new byte[] { 79, 17, 131, 170, 94, 199, 192, 206, 186, 114, 241, 181, 234, 217, 35, 166, 105, 51, 128, 171, 161, 63, 158, 10, 4, 113, 88, 48, 70, 144, 202, 185, 97, 131, 26, 214, 249, 3, 8, 58, 56, 122, 140, 236, 163, 204, 21, 129, 162, 52, 38, 36, 236, 100, 0, 38, 197, 230, 221, 55, 229, 195, 6, 44, 26, 57, 164, 179, 231, 20, 59, 172, 94, 57, 59, 10, 104, 131, 42, 217, 184, 111, 223, 233, 206, 156, 154, 249, 160, 241, 212, 18, 182, 111, 90, 183, 33, 127, 199, 244, 169, 240, 159, 79, 32, 22, 12, 54, 176, 32, 92, 30, 123, 181, 220, 92, 30, 35, 114, 115, 84, 82, 31, 190, 41, 115, 209, 129 }
                        });
                });

            modelBuilder.Entity("Server.Models.Movie", b =>
                {
                    b.HasOne("Server.Models.MovieList", "MovieList")
                        .WithMany("Movies")
                        .HasForeignKey("MovieListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Server.Models.MovieList", b =>
                {
                    b.HasOne("Server.Models.User", "User")
                        .WithMany("MovieLists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
