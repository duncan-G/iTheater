using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class FixSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 9, 34, 563, DateTimeKind.Local).AddTicks(5470), "Horror", "horror-1" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 9, 34, 566, DateTimeKind.Local).AddTicks(2360), "Sci Fi", "sci-fi-2" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 9, 34, 566, DateTimeKind.Local).AddTicks(2471), "2018", "2018-3" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 9, 34, 566, DateTimeKind.Local).AddTicks(2495), "2017", "2017-4" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 9, 34, 566, DateTimeKind.Local).AddTicks(2522), "Action", "action-5" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 9, 34, 566, DateTimeKind.Local).AddTicks(2550), "Drama", "drama-6" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 9, 34, 566, DateTimeKind.Local).AddTicks(2613), "The Best", "the-best-7" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 9, 34, 566, DateTimeKind.Local).AddTicks(2653), "Movie Ever", "movie-ever-8" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 9, 34, 566, DateTimeKind.Local).AddTicks(2680), "Comedy", "comedy-9" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 9, 34, 566, DateTimeKind.Local).AddTicks(2751), "Romance", "romance-10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { new byte[] { 240, 179, 139, 232, 91, 0, 154, 48, 192, 128, 53, 34, 76, 80, 111, 191, 76, 7, 21, 21, 61, 218, 203, 241, 104, 90, 78, 57, 203, 106, 155, 187, 65, 215, 12, 5, 22, 80, 80, 252, 7, 147, 71, 95, 51, 62, 94, 252, 127, 232, 110, 141, 200, 142, 204, 244, 192, 129, 218, 140, 245, 55, 232, 180 }, new byte[] { 93, 247, 175, 62, 213, 149, 71, 0, 201, 145, 92, 210, 124, 87, 139, 115, 86, 65, 210, 158, 125, 110, 226, 36, 202, 223, 235, 210, 213, 140, 64, 204, 57, 75, 224, 15, 201, 179, 190, 29, 69, 180, 31, 135, 248, 249, 63, 207, 206, 173, 155, 188, 234, 7, 136, 242, 97, 93, 139, 235, 167, 3, 138, 47, 141, 126, 116, 181, 136, 60, 169, 209, 180, 42, 169, 249, 181, 129, 174, 8, 208, 86, 137, 255, 56, 42, 104, 45, 53, 36, 27, 9, 54, 225, 158, 93, 6, 149, 172, 19, 206, 222, 170, 213, 252, 146, 251, 43, 4, 111, 50, 41, 57, 107, 243, 61, 28, 66, 42, 170, 235, 93, 141, 14, 157, 83, 202, 34 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 20, 56, 31, 243, DateTimeKind.Local).AddTicks(5174), null, null });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 20, 56, 31, 246, DateTimeKind.Local).AddTicks(1093), null, null });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 20, 56, 31, 246, DateTimeKind.Local).AddTicks(1152), null, null });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 20, 56, 31, 246, DateTimeKind.Local).AddTicks(1156), null, null });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 20, 56, 31, 246, DateTimeKind.Local).AddTicks(1160), null, null });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 20, 56, 31, 246, DateTimeKind.Local).AddTicks(1172), null, null });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 20, 56, 31, 246, DateTimeKind.Local).AddTicks(1176), null, null });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 20, 56, 31, 246, DateTimeKind.Local).AddTicks(1180), null, null });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 20, 56, 31, 246, DateTimeKind.Local).AddTicks(1183), null, null });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Name", "Slug" },
                values: new object[] { new DateTime(2019, 2, 28, 20, 56, 31, 246, DateTimeKind.Local).AddTicks(1187), null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { new byte[] { 178, 214, 4, 221, 2, 27, 241, 152, 207, 136, 201, 205, 231, 57, 4, 172, 79, 166, 181, 198, 36, 68, 218, 247, 189, 183, 101, 236, 251, 14, 67, 166, 9, 158, 177, 133, 104, 53, 245, 91, 111, 107, 204, 89, 175, 17, 210, 79, 69, 94, 5, 78, 105, 195, 66, 145, 248, 196, 185, 245, 136, 132, 116, 217 }, new byte[] { 229, 113, 64, 124, 199, 23, 17, 9, 160, 64, 148, 9, 121, 247, 34, 231, 109, 37, 115, 76, 27, 79, 29, 74, 97, 250, 153, 247, 215, 32, 110, 192, 220, 43, 13, 103, 155, 109, 140, 197, 187, 209, 62, 51, 51, 125, 113, 240, 34, 253, 240, 196, 83, 133, 162, 36, 112, 236, 233, 96, 64, 183, 96, 97, 75, 169, 2, 133, 44, 25, 112, 66, 51, 183, 157, 106, 35, 2, 177, 19, 227, 129, 89, 251, 96, 59, 131, 57, 103, 52, 64, 31, 29, 133, 25, 127, 123, 93, 96, 177, 217, 153, 93, 56, 23, 98, 1, 153, 24, 168, 233, 18, 127, 183, 27, 12, 244, 160, 121, 40, 23, 2, 94, 9, 149, 242, 120, 204 } });
        }
    }
}
