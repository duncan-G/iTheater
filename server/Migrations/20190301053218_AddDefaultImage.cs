using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class AddDefaultImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Private",
                table: "MovieLists",
                newName: "Privacy");

            migrationBuilder.AddColumn<string>(
                name: "DefaultImageUrl",
                table: "MovieLists",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "DefaultImageUrl", "Privacy" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 32, 18, 90, DateTimeKind.Local).AddTicks(6991), "/assets/movie-poster-default.png", true });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 32, 18, 93, DateTimeKind.Local).AddTicks(7943), "/assets/movie-poster-default.png" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "DefaultImageUrl", "Privacy" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 32, 18, 93, DateTimeKind.Local).AddTicks(8062), "/assets/movie-poster-default.png", true });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 32, 18, 93, DateTimeKind.Local).AddTicks(8093), "/assets/movie-poster-default.png" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "DefaultImageUrl", "Privacy" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 32, 18, 93, DateTimeKind.Local).AddTicks(8121), "/assets/movie-poster-default.png", true });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 32, 18, 93, DateTimeKind.Local).AddTicks(8152), "/assets/movie-poster-default.png" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "DefaultImageUrl", "Privacy" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 32, 18, 93, DateTimeKind.Local).AddTicks(8216), "/assets/movie-poster-default.png", true });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 32, 18, 93, DateTimeKind.Local).AddTicks(8314), "/assets/movie-poster-default.png" });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "DefaultImageUrl", "Privacy" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 32, 18, 93, DateTimeKind.Local).AddTicks(8346), "/assets/movie-poster-default.png", true });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "DefaultImageUrl" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 32, 18, 93, DateTimeKind.Local).AddTicks(8373), "/assets/movie-poster-default.png" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { new byte[] { 97, 178, 148, 43, 207, 15, 116, 160, 235, 24, 161, 6, 193, 183, 109, 223, 204, 151, 206, 148, 186, 251, 52, 87, 3, 235, 231, 93, 129, 104, 61, 79, 96, 105, 42, 121, 251, 216, 189, 141, 58, 94, 241, 175, 66, 242, 140, 51, 245, 52, 77, 111, 156, 82, 99, 31, 74, 122, 133, 231, 249, 105, 78, 178 }, new byte[] { 222, 131, 249, 248, 251, 31, 22, 226, 148, 103, 168, 99, 168, 101, 243, 205, 171, 251, 180, 204, 55, 236, 23, 217, 151, 205, 100, 227, 27, 173, 84, 133, 26, 16, 83, 69, 229, 160, 202, 48, 251, 96, 191, 70, 122, 7, 90, 63, 156, 148, 172, 8, 248, 178, 71, 26, 65, 122, 27, 161, 96, 146, 65, 112, 246, 208, 230, 61, 228, 150, 202, 0, 102, 147, 2, 168, 216, 216, 180, 160, 239, 30, 245, 19, 109, 6, 251, 86, 113, 172, 175, 67, 56, 210, 120, 247, 93, 152, 139, 228, 204, 239, 120, 65, 92, 206, 2, 0, 178, 121, 181, 75, 89, 231, 100, 67, 7, 47, 142, 124, 208, 110, 194, 194, 25, 2, 134, 84 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefaultImageUrl",
                table: "MovieLists");

            migrationBuilder.RenameColumn(
                name: "Privacy",
                table: "MovieLists",
                newName: "Private");

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Private" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 9, 34, 563, DateTimeKind.Local).AddTicks(5470), false });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 2, 28, 21, 9, 34, 566, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Private" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 9, 34, 566, DateTimeKind.Local).AddTicks(2471), false });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 2, 28, 21, 9, 34, 566, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Private" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 9, 34, 566, DateTimeKind.Local).AddTicks(2522), false });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2019, 2, 28, 21, 9, 34, 566, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Private" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 9, 34, 566, DateTimeKind.Local).AddTicks(2613), false });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2019, 2, 28, 21, 9, 34, 566, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Private" },
                values: new object[] { new DateTime(2019, 2, 28, 21, 9, 34, 566, DateTimeKind.Local).AddTicks(2680), false });

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2019, 2, 28, 21, 9, 34, 566, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { new byte[] { 240, 179, 139, 232, 91, 0, 154, 48, 192, 128, 53, 34, 76, 80, 111, 191, 76, 7, 21, 21, 61, 218, 203, 241, 104, 90, 78, 57, 203, 106, 155, 187, 65, 215, 12, 5, 22, 80, 80, 252, 7, 147, 71, 95, 51, 62, 94, 252, 127, 232, 110, 141, 200, 142, 204, 244, 192, 129, 218, 140, 245, 55, 232, 180 }, new byte[] { 93, 247, 175, 62, 213, 149, 71, 0, 201, 145, 92, 210, 124, 87, 139, 115, 86, 65, 210, 158, 125, 110, 226, 36, 202, 223, 235, 210, 213, 140, 64, 204, 57, 75, 224, 15, 201, 179, 190, 29, 69, 180, 31, 135, 248, 249, 63, 207, 206, 173, 155, 188, 234, 7, 136, 242, 97, 93, 139, 235, 167, 3, 138, 47, 141, 126, 116, 181, 136, 60, 169, 209, 180, 42, 169, 249, 181, 129, 174, 8, 208, 86, 137, 255, 56, 42, 104, 45, 53, 36, 27, 9, 54, 225, 158, 93, 6, 149, 172, 19, 206, 222, 170, 213, 252, 146, 251, 43, 4, 111, 50, 41, 57, 107, 243, 61, 28, 66, 42, 170, 235, 93, 141, 14, 157, 83, 202, 34 } });
        }
    }
}
