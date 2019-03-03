using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class InitCloudDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 3, 2, 23, 20, 33, 109, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 3, 2, 23, 20, 33, 111, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 3, 2, 23, 20, 33, 112, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 3, 2, 23, 20, 33, 112, DateTimeKind.Local).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 3, 2, 23, 20, 33, 112, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 3, 2, 23, 20, 33, 112, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { new byte[] { 214, 170, 170, 219, 70, 12, 233, 137, 168, 40, 128, 239, 145, 82, 137, 99, 150, 213, 59, 151, 222, 235, 223, 188, 69, 48, 167, 203, 32, 31, 13, 88, 95, 80, 0, 44, 251, 206, 228, 251, 52, 72, 218, 99, 183, 52, 45, 6, 83, 220, 24, 174, 224, 96, 81, 19, 12, 220, 43, 141, 67, 81, 62, 206 }, new byte[] { 79, 17, 131, 170, 94, 199, 192, 206, 186, 114, 241, 181, 234, 217, 35, 166, 105, 51, 128, 171, 161, 63, 158, 10, 4, 113, 88, 48, 70, 144, 202, 185, 97, 131, 26, 214, 249, 3, 8, 58, 56, 122, 140, 236, 163, 204, 21, 129, 162, 52, 38, 36, 236, 100, 0, 38, 197, 230, 221, 55, 229, 195, 6, 44, 26, 57, 164, 179, 231, 20, 59, 172, 94, 57, 59, 10, 104, 131, 42, 217, 184, 111, 223, 233, 206, 156, 154, 249, 160, 241, 212, 18, 182, 111, 90, 183, 33, 127, 199, 244, 169, 240, 159, 79, 32, 22, 12, 54, 176, 32, 92, 30, 123, 181, 220, 92, 30, 35, 114, 115, 84, 82, 31, 190, 41, 115, 209, 129 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 3, 1, 22, 23, 35, 913, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "MovieLists",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2019, 3, 1, 22, 23, 35, 917, DateTimeKind.Local).AddTicks(4086));

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
    }
}
