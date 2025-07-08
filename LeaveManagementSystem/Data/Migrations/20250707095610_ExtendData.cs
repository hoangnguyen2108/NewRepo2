using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69321195-8b73-4f1a-919b-e7deee4b3909",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d78cfa6-723c-461e-94e1-d6697d615528", new DateOnly(1990, 1, 1), "Jay", "Van", "AQAAAAIAAYagAAAAEPLiyosGHCT84APxHyVkq78Bx0mxtdu1HyuuxVW5CkmS5vl1WOL1WdR/LY8MBoU0YA==", "06cfe8fa-1778-4fd9-9fb5-93ac6e7df15d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bdee7c76-d0b8-4ff2-908c-f80177687964",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65966086-f036-463e-9799-82925279102b", new DateOnly(1992, 2, 2), "John", "Doe", "AQAAAAIAAYagAAAAEELh3MByvUuJcrpYVbC7ykpEKna9spNafhIgkI28zaGq85FfkxGSBZikcQoe0Pxh9w==", "beaab2b5-8a0a-45a3-877e-7a8c0e0ebaa5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69321195-8b73-4f1a-919b-e7deee4b3909",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d147bd8c-8985-425c-b976-f0d31ff34d2f", "AQAAAAIAAYagAAAAEOD+PFdx0v62T56zGt00JXoQFW8NFNYQco05l+epQEVS7LacwNnQaUoB/pmkencjVA==", "5f79351e-1455-437e-adec-54d5490df75c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bdee7c76-d0b8-4ff2-908c-f80177687964",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45b68e67-9218-45f6-8bec-044bbfab7bd8", "AQAAAAIAAYagAAAAEEAy2JNfyZsAGayX+5dHJ/3prLDv+4WRZb879vepcXBNcpBVLn5McjWMPE209mJknQ==", "46efc705-1e14-49b3-bf58-81b4b6934367" });
        }
    }
}
