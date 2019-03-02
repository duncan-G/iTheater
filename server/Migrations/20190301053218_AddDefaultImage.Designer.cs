﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Models;

namespace Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190301053218_AddDefaultImage")]
    partial class AddDefaultImage
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

                    b.Property<int>("MovieId");

                    b.Property<int?>("MovieListId");

                    b.Property<int>("Rating");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MovieListId");

                    b.HasIndex("UserId");

                    b.ToTable("Movies");
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
                            Created = new DateTime(2019, 2, 28, 21, 32, 18, 90, DateTimeKind.Local).AddTicks(6991),
                            DefaultImageUrl = "/assets/movie-poster-default.png",
                            Name = "Horror",
                            Privacy = true,
                            Slug = "horror-1",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2019, 2, 28, 21, 32, 18, 93, DateTimeKind.Local).AddTicks(7943),
                            DefaultImageUrl = "/assets/movie-poster-default.png",
                            Name = "Sci Fi",
                            Privacy = false,
                            Slug = "sci-fi-2",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2019, 2, 28, 21, 32, 18, 93, DateTimeKind.Local).AddTicks(8062),
                            DefaultImageUrl = "/assets/movie-poster-default.png",
                            Name = "2018",
                            Privacy = true,
                            Slug = "2018-3",
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2019, 2, 28, 21, 32, 18, 93, DateTimeKind.Local).AddTicks(8093),
                            DefaultImageUrl = "/assets/movie-poster-default.png",
                            Name = "2017",
                            Privacy = false,
                            Slug = "2017-4",
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2019, 2, 28, 21, 32, 18, 93, DateTimeKind.Local).AddTicks(8121),
                            DefaultImageUrl = "/assets/movie-poster-default.png",
                            Name = "Action",
                            Privacy = true,
                            Slug = "action-5",
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(2019, 2, 28, 21, 32, 18, 93, DateTimeKind.Local).AddTicks(8152),
                            DefaultImageUrl = "/assets/movie-poster-default.png",
                            Name = "Drama",
                            Privacy = false,
                            Slug = "drama-6",
                            UserId = 1
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2019, 2, 28, 21, 32, 18, 93, DateTimeKind.Local).AddTicks(8216),
                            DefaultImageUrl = "/assets/movie-poster-default.png",
                            Name = "The Best",
                            Privacy = true,
                            Slug = "the-best-7",
                            UserId = 1
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2019, 2, 28, 21, 32, 18, 93, DateTimeKind.Local).AddTicks(8314),
                            DefaultImageUrl = "/assets/movie-poster-default.png",
                            Name = "Movie Ever",
                            Privacy = false,
                            Slug = "movie-ever-8",
                            UserId = 1
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2019, 2, 28, 21, 32, 18, 93, DateTimeKind.Local).AddTicks(8346),
                            DefaultImageUrl = "/assets/movie-poster-default.png",
                            Name = "Comedy",
                            Privacy = true,
                            Slug = "comedy-9",
                            UserId = 1
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(2019, 2, 28, 21, 32, 18, 93, DateTimeKind.Local).AddTicks(8373),
                            DefaultImageUrl = "/assets/movie-poster-default.png",
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
                            PasswordHash = new byte[] { 97, 178, 148, 43, 207, 15, 116, 160, 235, 24, 161, 6, 193, 183, 109, 223, 204, 151, 206, 148, 186, 251, 52, 87, 3, 235, 231, 93, 129, 104, 61, 79, 96, 105, 42, 121, 251, 216, 189, 141, 58, 94, 241, 175, 66, 242, 140, 51, 245, 52, 77, 111, 156, 82, 99, 31, 74, 122, 133, 231, 249, 105, 78, 178 },
                            Salt = new byte[] { 222, 131, 249, 248, 251, 31, 22, 226, 148, 103, 168, 99, 168, 101, 243, 205, 171, 251, 180, 204, 55, 236, 23, 217, 151, 205, 100, 227, 27, 173, 84, 133, 26, 16, 83, 69, 229, 160, 202, 48, 251, 96, 191, 70, 122, 7, 90, 63, 156, 148, 172, 8, 248, 178, 71, 26, 65, 122, 27, 161, 96, 146, 65, 112, 246, 208, 230, 61, 228, 150, 202, 0, 102, 147, 2, 168, 216, 216, 180, 160, 239, 30, 245, 19, 109, 6, 251, 86, 113, 172, 175, 67, 56, 210, 120, 247, 93, 152, 139, 228, 204, 239, 120, 65, 92, 206, 2, 0, 178, 121, 181, 75, 89, 231, 100, 67, 7, 47, 142, 124, 208, 110, 194, 194, 25, 2, 134, 84 }
                        });
                });

            modelBuilder.Entity("Server.Models.Movie", b =>
                {
                    b.HasOne("Server.Models.MovieList", "MovieList")
                        .WithMany()
                        .HasForeignKey("MovieListId");

                    b.HasOne("Server.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
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
