using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagementSystem.Migrations
{
    public partial class InitialSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhotoUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhotoPublicId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "DateUpdated", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoPublicId", "PhotoUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c9d4c053-49b6-410c-bc78-2d54a9991870", 0, "507b18a5-9cce-4608-a9a3-4e2aa4075894", new DateTime(2022, 6, 23, 11, 17, 9, 405, DateTimeKind.Local).AddTicks(8660), new DateTime(2022, 6, 23, 11, 17, 9, 405, DateTimeKind.Local).AddTicks(8677), "admin@nlpcpfa.com", true, "IT", "Male", "Support", false, null, null, null, null, null, false, null, null, "d472fe17-1aa9-4bab-8124-1a627ac9570a", false, "admin" });

            migrationBuilder.InsertData(
                table: "Visitors",
                columns: new[] { "Id", "CreatedAt", "Feedback", "FirstName", "Gender", "LastName", "Purpose", "TimeIn", "TimeOut", "UpdatedAt", "VisitingDepartment", "WalkInType" },
                values: new object[] { "80abbca8-664d-4b20-b5de-024705497d4a", new DateTime(2022, 6, 23, 11, 17, 9, 405, DateTimeKind.Local).AddTicks(9169), "Experience was wonderful", "Arsene", 0, "Merlino", "Test purpose", new DateTime(2022, 6, 23, 11, 17, 9, 405, DateTimeKind.Local).AddTicks(9179), new DateTime(2022, 6, 23, 13, 17, 9, 405, DateTimeKind.Local).AddTicks(9180), new DateTime(2022, 6, 23, 11, 17, 9, 405, DateTimeKind.Local).AddTicks(9169), "IT Department", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c9d4c053-49b6-410c-bc78-2d54a9991870");

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: "80abbca8-664d-4b20-b5de-024705497d4a");

            migrationBuilder.AlterColumn<string>(
                name: "PhotoUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhotoPublicId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
