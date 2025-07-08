using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b1bb66e-6aa2-4728-8b5b-4e6de4fd899b", null, "Administrator", "ADMINISTRATOR" },
                    { "958e6340-4275-49ed-80ee-2cb5e2fad807", null, "Employee", "EMPLOYEE" },
                    { "f4145e80-361d-4541-b311-9e95b4a95964", null, "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "69321195-8b73-4f1a-919b-e7deee4b3909", 0, "d147bd8c-8985-425c-b976-f0d31ff34d2f", "user1adin@gmail.com", true, false, null, "USER1admin@GMAIL.COM", "USER1admin", "AQAAAAIAAYagAAAAEOD+PFdx0v62T56zGt00JXoQFW8NFNYQco05l+epQEVS7LacwNnQaUoB/pmkencjVA==", null, false, "5f79351e-1455-437e-adec-54d5490df75c", false, "user1admin" },
                    { "bdee7c76-d0b8-4ff2-908c-f80177687964", 0, "45b68e67-9218-45f6-8bec-044bbfab7bd8", "user2sup@gmail.com", true, false, null, "USER2SUP@GMAIL.COM", "USER2SUP", "AQAAAAIAAYagAAAAEEAy2JNfyZsAGayX+5dHJ/3prLDv+4WRZb879vepcXBNcpBVLn5McjWMPE209mJknQ==", null, false, "46efc705-1e14-49b3-bf58-81b4b6934367", false, "user2sup" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1b1bb66e-6aa2-4728-8b5b-4e6de4fd899b", "69321195-8b73-4f1a-919b-e7deee4b3909" },
                    { "f4145e80-361d-4541-b311-9e95b4a95964", "bdee7c76-d0b8-4ff2-908c-f80177687964" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "958e6340-4275-49ed-80ee-2cb5e2fad807");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1b1bb66e-6aa2-4728-8b5b-4e6de4fd899b", "69321195-8b73-4f1a-919b-e7deee4b3909" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f4145e80-361d-4541-b311-9e95b4a95964", "bdee7c76-d0b8-4ff2-908c-f80177687964" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b1bb66e-6aa2-4728-8b5b-4e6de4fd899b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4145e80-361d-4541-b311-9e95b4a95964");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69321195-8b73-4f1a-919b-e7deee4b3909");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bdee7c76-d0b8-4ff2-908c-f80177687964");
        }
    }
}
