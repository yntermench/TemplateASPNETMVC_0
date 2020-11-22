using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemplateforAspNetCore_0.Migrations
{
    public partial class fixed_0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af10569-b018-4fe7-a380-7d6a14c70b74",
                column: "ConcurrencyStamp",
                value: "0f8206c1-c767-434c-a21f-a5f104c9390a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e81ebc71-e468-491d-9eec-561fc5cb6166", "AQAAAAEAACcQAAAAEEoc4X+CHVibqeuWtf34dXjLGhqhEKGamA39CDD1L1lAFD9bpsEdQg8DAB0VPNyUNQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2020, 11, 21, 17, 59, 17, 150, DateTimeKind.Utc).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2020, 11, 21, 17, 59, 17, 149, DateTimeKind.Utc).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2020, 11, 21, 17, 59, 17, 150, DateTimeKind.Utc).AddTicks(1705));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af10569-b018-4fe7-a380-7d6a14c70b74",
                column: "ConcurrencyStamp",
                value: "7ec60eac-507e-4d00-a234-5ad76ba88ac0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "00ecbbe7-0836-438f-b98f-47ec8f3cf37d", "AQAAAAEAACcQAAAAEF0uh0EbC9g2af1mKJwbPY/ULpM6+2aMpBhCyfFGB+JuZHdUFnk0B5WR/QyyaiLhyA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2020, 11, 14, 14, 13, 45, 69, DateTimeKind.Utc).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2020, 11, 14, 14, 13, 45, 69, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2020, 11, 14, 14, 13, 45, 69, DateTimeKind.Utc).AddTicks(8117));
        }
    }
}
