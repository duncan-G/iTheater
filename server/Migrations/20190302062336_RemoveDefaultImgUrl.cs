using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class RemoveDefaultImgUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 22, 23, 35, 913, DateTimeKind.Local).AddTicks(9439), null });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(3620), null });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(3759), null });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(3782), null });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(3810), null });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(3842), null });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(3928), null });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(3976), null });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(4059), null });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(4086), null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { new byte[] { 245, 93, 80, 127, 131, 204, 237, 206, 177, 78, 81, 121, 245, 29, 216, 52, 214, 113, 124, 44, 96, 236, 100, 31, 16, 123, 82, 114, 72, 35, 53, 225, 143, 19, 243, 80, 33, 157, 44, 125, 235, 55, 40, 146, 99, 186, 218, 179, 76, 20, 133, 242, 76, 197, 206, 238, 206, 124, 202, 92, 38, 234, 105, 183 }, new byte[] { 166, 81, 98, 16, 255, 247, 133, 186, 120, 72, 237, 112, 159, 18, 99, 212, 131, 159, 212, 124, 96, 113, 217, 36, 183, 208, 193, 229, 52, 243, 44, 239, 242, 0, 224, 107, 251, 183, 42, 188, 87, 4, 138, 58, 68, 240, 69, 26, 55, 167, 166, 95, 43, 215, 10, 171, 113, 227, 112, 149, 126, 5, 68, 59, 176, 210, 233, 59, 78, 175, 226, 44, 40, 92, 17, 162, 39, 245, 196, 63, 49, 29, 160, 63, 214, 175, 72, 116, 68, 181, 155, 43, 166, 32, 212, 237, 155, 93, 97, 178, 190, 145, 118, 77, 232, 92, 185, 151, 163, 21, 37, 158, 85, 60, 253, 114, 3, 75, 223, 86, 185, 107, 157, 159, 35, 22, 202, 79 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 19, 44, 46, 0, DateTimeKind.Local).AddTicks(7014), "/assets/movie-poster-default.png" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3064), "/assets/movie-poster-default.png" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3171), "/assets/movie-poster-default.png" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3194), "/assets/movie-poster-default.png" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3222), "/assets/movie-poster-default.png" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3297), "/assets/movie-poster-default.png" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3364), "/assets/movie-poster-default.png" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3408), "/assets/movie-poster-default.png" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3431), "/assets/movie-poster-default.png" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3455), "/assets/movie-poster-default.png" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { new byte[] { 63, 111, 216, 25, 109, 75, 115, 126, 244, 217, 48, 110, 2, 25, 102, 19, 143, 10, 142, 198, 138, 141, 189, 84, 189, 159, 186, 9, 132, 185, 122, 150, 182, 251, 48, 220, 141, 253, 203, 44, 83, 153, 8, 245, 184, 125, 248, 237, 2, 156, 130, 1, 120, 15, 161, 43, 181, 185, 4, 25, 108, 9, 137, 4 }, new byte[] { 130, 160, 141, 178, 244, 20, 34, 119, 67, 1, 212, 89, 186, 232, 170, 177, 5, 60, 119, 84, 25, 89, 241, 222, 113, 22, 153, 212, 175, 75, 52, 137, 30, 17, 99, 229, 204, 12, 82, 111, 188, 160, 63, 218, 52, 69, 51, 132, 87, 164, 35, 228, 67, 103, 196, 57, 246, 206, 108, 122, 202, 197, 64, 253, 233, 232, 29, 250, 238, 19, 11, 13, 67, 84, 0, 218, 198, 209, 23, 83, 47, 104, 40, 157, 61, 174, 158, 229, 111, 48, 19, 26, 68, 248, 237, 152, 146, 21, 152, 217, 135, 247, 207, 207, 78, 49, 24, 253, 93, 163, 7, 237, 57, 98, 29, 128, 248, 116, 247, 89, 138, 14, 44, 191, 97, 72, 99, 191 } });
        }
    }
}
