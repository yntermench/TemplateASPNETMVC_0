using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemplateforAspNetCore_0.Migrations
{
    public partial class _final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af10569-b018-4fe7-a380-7d6a14c70b74",
                column: "ConcurrencyStamp",
                value: "8bb7b57b-6793-4244-bd38-e938bcd23349");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8931b457-e201-402b-907b-7201ffc2158d", "AQAAAAEAACcQAAAAEEArAjnXxXwnMwdfqR6UTENwbrYvb6a6cB5y0t/oomeLj3gxdJsV/8gMUuuyivR8bA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2020, 11, 22, 12, 16, 16, 905, DateTimeKind.Utc).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2020, 11, 22, 12, 16, 16, 905, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2020, 11, 22, 12, 16, 16, 905, DateTimeKind.Utc).AddTicks(7792));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af10569-b018-4fe7-a380-7d6a14c70b74",
                column: "ConcurrencyStamp",
                value: "29e53147-722a-4f51-b343-3cf830e9803b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72098b1b-6a72-4baa-8d57-6c060532d418", "AQAAAAEAACcQAAAAEMmIubQUju0PiXLK2m3B8zkogkJcFGer+Idv06CyuxH4OYJ3sqeHmstnoCe+fzrhyw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2020, 11, 21, 18, 13, 43, 57, DateTimeKind.Utc).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2020, 11, 21, 18, 13, 43, 57, DateTimeKind.Utc).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2020, 11, 21, 18, 13, 43, 57, DateTimeKind.Utc).AddTicks(7139));
        }
    }
}
