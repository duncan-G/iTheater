using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class UpdateModelsAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Slug = table.Column<string>(nullable: true),
                    Private = table.Column<bool>(nullable: false),
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "PasswordHash", "Salt" },
                values: new object[] { 1, "a@gmail.com", new byte[] { 178, 214, 4, 221, 2, 27, 241, 152, 207, 136, 201, 205, 231, 57, 4, 172, 79, 166, 181, 198, 36, 68, 218, 247, 189, 183, 101, 236, 251, 14, 67, 166, 9, 158, 177, 133, 104, 53, 245, 91, 111, 107, 204, 89, 175, 17, 210, 79, 69, 94, 5, 78, 105, 195, 66, 145, 248, 196, 185, 245, 136, 132, 116, 217 }, new byte[] { 229, 113, 64, 124, 199, 23, 17, 9, 160, 64, 148, 9, 121, 247, 34, 231, 109, 37, 115, 76, 27, 79, 29, 74, 97, 250, 153, 247, 215, 32, 110, 192, 220, 43, 13, 103, 155, 109, 140, 197, 187, 209, 62, 51, 51, 125, 113, 240, 34, 253, 240, 196, 83, 133, 162, 36, 112, 236, 233, 96, 64, 183, 96, 97, 75, 169, 2, 133, 44, 25, 112, 66, 51, 183, 157, 106, 35, 2, 177, 19, 227, 129, 89, 251, 96, 59, 131, 57, 103, 52, 64, 31, 29, 133, 25, 127, 123, 93, 96, 177, 217, 153, 93, 56, 23, 98, 1, 153, 24, 168, 233, 18, 127, 183, 27, 12, 244, 160, 121, 40, 23, 2, 94, 9, 149, 242, 120, 204 } });

            migrationBuilder.InsertData(
                table: "MovieLists",
                columns: new[] { "Id", "Created", "Name", "Private", "Slug", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 2, 28, 20, 56, 31, 243, DateTimeKind.Local).AddTicks(5174), null, false, null, 1 },
                    { 2, new DateTime(2019, 2, 28, 20, 56, 31, 246, DateTimeKind.Local).AddTicks(1093), null, false, null, 1 },
                    { 3, new DateTime(2019, 2, 28, 20, 56, 31, 246, DateTimeKind.Local).AddTicks(1152), null, false, null, 1 },
                    { 4, new DateTime(2019, 2, 28, 20, 56, 31, 246, DateTimeKind.Local).AddTicks(1156), null, false, null, 1 },
                    { 5, new DateTime(2019, 2, 28, 20, 56, 31, 246, DateTimeKind.Local).AddTicks(1160), null, false, null, 1 },
                    { 6, new DateTime(2019, 2, 28, 20, 56, 31, 246, DateTimeKind.Local).AddTicks(1172), null, false, null, 1 },
                    { 7, new DateTime(2019, 2, 28, 20, 56, 31, 246, DateTimeKind.Local).AddTicks(1176), null, false, null, 1 },
                    { 8, new DateTime(2019, 2, 28, 20, 56, 31, 246, DateTimeKind.Local).AddTicks(1180), null, false, null, 1 },
                    { 9, new DateTime(2019, 2, 28, 20, 56, 31, 246, DateTimeKind.Local).AddTicks(1183), null, false, null, 1 },
                    { 10, new DateTime(2019, 2, 28, 20, 56, 31, 246, DateTimeKind.Local).AddTicks(1187), null, false, null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieLists_UserId",
                table: "MovieLists",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_MovieLists_MovieListId",
                table: "Movies",
                column: "MovieListId",
                principalTable: "MovieLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_MovieLists_MovieListId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "MovieLists");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "MovieListId",
                table: "Movies",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_MovieListId",
                table: "Movies",
                newName: "IX_Movies_CategoryId");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_UserId",
                table: "Categories",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categories_CategoryId",
                table: "Movies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
