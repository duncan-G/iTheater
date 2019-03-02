using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class AddTitleToMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Movies",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 44, 46, 0, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Title" },
                values: new object[] { new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(3791), "Love of My Life" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Title" },
                values: new object[] { new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(5061), "The Kid Who Would Be King" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Title" },
                values: new object[] { new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(5089), "Border" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Title" },
                values: new object[] { new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(5093), "Bumblebee" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Title" },
                values: new object[] { new DateTime(2019, 3, 1, 19, 44, 46, 3, DateTimeKind.Local).AddTicks(5097), "Kamen Rider Heisei Generations FOREVER" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { new byte[] { 63, 111, 216, 25, 109, 75, 115, 126, 244, 217, 48, 110, 2, 25, 102, 19, 143, 10, 142, 198, 138, 141, 189, 84, 189, 159, 186, 9, 132, 185, 122, 150, 182, 251, 48, 220, 141, 253, 203, 44, 83, 153, 8, 245, 184, 125, 248, 237, 2, 156, 130, 1, 120, 15, 161, 43, 181, 185, 4, 25, 108, 9, 137, 4 }, new byte[] { 130, 160, 141, 178, 244, 20, 34, 119, 67, 1, 212, 89, 186, 232, 170, 177, 5, 60, 119, 84, 25, 89, 241, 222, 113, 22, 153, 212, 175, 75, 52, 137, 30, 17, 99, 229, 204, 12, 82, 111, 188, 160, 63, 218, 52, 69, 51, 132, 87, 164, 35, 228, 67, 103, 196, 57, 246, 206, 108, 122, 202, 197, 64, 253, 233, 232, 29, 250, 238, 19, 11, 13, 67, 84, 0, 218, 198, 209, 23, 83, 47, 104, 40, 157, 61, 174, 158, 229, 111, 48, 19, 26, 68, 248, 237, 152, 146, 21, 152, 217, 135, 247, 207, 207, 78, 49, 24, 253, 93, 163, 7, 237, 57, 98, 29, 128, 248, 116, 247, 89, 138, 14, 44, 191, 97, 72, 99, 191 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 24, 49, 920, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 3, 1, 19, 24, 49, 923, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { new byte[] { 193, 140, 159, 157, 95, 80, 73, 103, 191, 210, 209, 16, 129, 168, 139, 65, 78, 58, 25, 7, 154, 220, 112, 217, 174, 95, 21, 201, 175, 231, 51, 9, 128, 121, 149, 14, 49, 199, 56, 33, 140, 40, 37, 198, 217, 121, 66, 110, 23, 132, 36, 242, 110, 180, 2, 192, 93, 38, 202, 143, 127, 131, 179, 127 }, new byte[] { 134, 145, 64, 164, 179, 224, 158, 219, 198, 2, 90, 61, 192, 208, 222, 53, 44, 100, 133, 147, 70, 11, 60, 72, 17, 252, 89, 174, 145, 125, 73, 82, 163, 163, 168, 79, 105, 26, 111, 65, 222, 62, 162, 255, 127, 132, 118, 10, 172, 145, 55, 169, 1, 98, 95, 210, 205, 201, 70, 219, 252, 150, 147, 245, 60, 149, 57, 100, 154, 140, 164, 188, 3, 235, 113, 43, 18, 187, 72, 192, 67, 146, 22, 254, 26, 124, 228, 63, 189, 49, 180, 190, 214, 193, 232, 255, 167, 28, 247, 162, 91, 144, 211, 193, 229, 62, 236, 223, 240, 192, 94, 193, 28, 227, 64, 17, 200, 146, 49, 23, 213, 80, 179, 240, 46, 125, 34, 197 } });
        }
    }
}
