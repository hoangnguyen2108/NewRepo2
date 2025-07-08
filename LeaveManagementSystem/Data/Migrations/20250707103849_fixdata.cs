using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69321195-8b73-4f1a-919b-e7deee4b3909",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b41373f1-86a3-468d-bfaf-b51147c0ebc0", "AQAAAAIAAYagAAAAEE8HEdSNvf/go+EB1zjPumFOqe5uy5lbAfSEtvqMqlCSC8FVPwsFgCr3PqZNH8Rxkw==", "b5534be9-8034-4b95-b20b-79a4201ef7d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bdee7c76-d0b8-4ff2-908c-f80177687964",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a89c6f65-4196-488c-bdd7-869bf946cec1", "AQAAAAIAAYagAAAAEBvvuNIJLsDYnOOynDdV95Smg6gm51601MvHe0y6tcNCTty4pwqncllASn6Y6Aa8YQ==", "10f6ed51-cdbc-422b-be76-1e9fda54f880" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69321195-8b73-4f1a-919b-e7deee4b3909",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d78cfa6-723c-461e-94e1-d6697d615528", "AQAAAAIAAYagAAAAEPLiyosGHCT84APxHyVkq78Bx0mxtdu1HyuuxVW5CkmS5vl1WOL1WdR/LY8MBoU0YA==", "06cfe8fa-1778-4fd9-9fb5-93ac6e7df15d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bdee7c76-d0b8-4ff2-908c-f80177687964",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65966086-f036-463e-9799-82925279102b", "AQAAAAIAAYagAAAAEELh3MByvUuJcrpYVbC7ykpEKna9spNafhIgkI28zaGq85FfkxGSBZikcQoe0Pxh9w==", "beaab2b5-8a0a-45a3-877e-7a8c0e0ebaa5" });
        }
    }
}
