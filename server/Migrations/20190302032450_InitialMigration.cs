using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Salt = table.Column<byte[]>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Slug = table.Column<string>(nullable: true),
                    Privacy = table.Column<bool>(nullable: false),
                    DefaultImageUrl = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieLists_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MoviesDbId = table.Column<int>(nullable: false),
                    ReleaseDate = table.Column<string>(nullable: true),
                    PosterPath = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    MovieListId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_MovieLists_MovieListId",
                        column: x => x.MovieListId,
                        principalTable: "MovieLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "PasswordHash", "Salt" },
                values: new object[] { 1, "a@gmail.com", new byte[] { 193, 140, 159, 157, 95, 80, 73, 103, 191, 210, 209, 16, 129, 168, 139, 65, 78, 58, 25, 7, 154, 220, 112, 217, 174, 95, 21, 201, 175, 231, 51, 9, 128, 121, 149, 14, 49, 199, 56, 33, 140, 40, 37, 198, 217, 121, 66, 110, 23, 132, 36, 242, 110, 180, 2, 192, 93, 38, 202, 143, 127, 131, 179, 127 }, new byte[] { 134, 145, 64, 164, 179, 224, 158, 219, 198, 2, 90, 61, 192, 208, 222, 53, 44, 100, 133, 147, 70, 11, 60, 72, 17, 252, 89, 174, 145, 125, 73, 82, 163, 163, 168, 79, 105, 26, 111, 65, 222, 62, 162, 255, 127, 132, 118, 10, 172, 145, 55, 169, 1, 98, 95, 210, 205, 201, 70, 219, 252, 150, 147, 245, 60, 149, 57, 100, 154, 140, 164, 188, 3, 235, 113, 43, 18, 187, 72, 192, 67, 146, 22, 254, 26, 124, 228, 63, 189, 49, 180, 190, 214, 193, 232, 255, 167, 28, 247, 162, 91, 144, 211, 193, 229, 62, 236, 223, 240, 192, 94, 193, 28, 227, 64, 17, 200, 146, 49, 23, 213, 80, 179, 240, 46, 125, 34, 197 } });

            migrationBuilder.InsertData(
                table: "MovieLists",
                columns: new[] { "Id", "Created", "DefaultImageUrl", "Name", "Privacy", "Slug", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 3, 1, 19, 24, 49, 920, DateTimeKind.Local).AddTicks(7144), "/assets/movie-poster-default.png", "Horror", true, "horror-1", 1 },
                    { 2, new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4146), "/assets/movie-poster-default.png", "Sci Fi", false, "sci-fi-2", 1 },
                    { 3, new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4311), "/assets/movie-poster-default.png", "2018", true, "2018-3", 1 },
                    { 4, new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4339), "/assets/movie-poster-default.png", "2017", false, "2017-4", 1 },
                    { 5, new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4363), "/assets/movie-poster-default.png", "Action", true, "action-5", 1 },
                    { 6, new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4394), "/assets/movie-poster-default.png", "Drama", false, "drama-6", 1 },
                    { 7, new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4457), "/assets/movie-poster-default.png", "The Best", true, "the-best-7", 1 },
                    { 8, new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4497), "/assets/movie-poster-default.png", "Movie Ever", false, "movie-ever-8", 1 },
                    { 9, new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4521), "/assets/movie-poster-default.png", "Comedy", true, "comedy-9", 1 },
                    { 10, new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4548), "/assets/movie-poster-default.png", "Romance", false, "romance-10", 1 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Created", "MovieListId", "MoviesDbId", "PosterPath", "Rating", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4963), 1, 443055, "/7b19Sh0Aef5vGa0OFtvJxLe2SK9.jpg", 5, "2017-02-17" },
                    { 2, new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(6246), 1, 454294, "/kBuvLX6zynQP0sjyqbXV4jNaZ4E.jpg", 3, "2019-01-16" },
                    { 3, new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(6269), 1, 33125, "/mmGwawOiUaP4Nkr2b1k0xsVhuY5.jpg", 2, "1997-07-13" },
                    { 4, new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(6273), 1, 424783, "/fw02ONlDhrYjTSZV8XO6hhU3ds3.jpg", 0, "2018-12-15" },
                    { 5, new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(6277), 1, 543103, "/6sOFQDlkY6El1B2P5gklzJfVdsT.jpg", 0, "2018-12-22" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieLists_UserId",
                table: "MovieLists",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieListId",
                table: "Movies",
                column: "MovieListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "MovieLists");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
