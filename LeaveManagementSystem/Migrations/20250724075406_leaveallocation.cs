using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class leaveallocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Periods",
                columns: table => new
                {
                    PeriodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periods", x => x.PeriodId);
                });

            migrationBuilder.CreateTable(
                name: "leaveALocations",
                columns: table => new
                {
                    LeaveALocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PeriodId = table.Column<int>(type: "int", nullable: false),
                    Days = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leaveALocations", x => x.LeaveALocationId);
                    table.ForeignKey(
                        name: "FK_leaveALocations_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_leaveALocations_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_leaveALocations_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "PeriodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69321195-8b73-4f1a-919b-e7deee4b3909",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "998e9644-6f33-4001-b304-93b5a5fd8f11", "AQAAAAIAAYagAAAAEMOL6tpSdam0ITTGTM5cKJXoAk41W5mT2y2oDtV1KySQRCU1m9XpEUaIrD3tll5uEw==", "bd132535-3ac0-4506-9485-b9f2b0387753" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bdee7c76-d0b8-4ff2-908c-f80177687964",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5283ef23-da22-4c6d-96d1-d4e1de080b66", "AQAAAAIAAYagAAAAEPC5GYHA/6aKBVpr+PxlFAq7LrkHDZ5iHjF4XHGW42Y/QOk6Z2ou5/cmwCHfTsAdDg==", "4b7f0f74-7cff-4258-bed8-4a164f963974" });

            migrationBuilder.CreateIndex(
                name: "IX_leaveALocations_EmployeeId",
                table: "leaveALocations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_leaveALocations_LeaveTypeId",
                table: "leaveALocations",
                column: "LeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_leaveALocations_PeriodId",
                table: "leaveALocations",
                column: "PeriodId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "leaveALocations");

            migrationBuilder.DropTable(
                name: "Periods");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69321195-8b73-4f1a-919b-e7deee4b3909",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26821315-e966-4d10-aeaf-81d48926e081", "AQAAAAIAAYagAAAAEJIPtGxb95IV1ZrYm6QShaVgmaQOf+908r3PjpDCnaP6NvZfQUNWnipOY7qvTC/hqA==", "848173f6-7241-4484-a303-58a2e65298e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bdee7c76-d0b8-4ff2-908c-f80177687964",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f198f668-260b-491b-9e49-facc32ff3cd0", "AQAAAAIAAYagAAAAEKfGMeECg9+fOuvNtizdyBqfplVHtgeO1jgJgUIP4KWG8Tm+hMNt+ADUO0AI71jX4Q==", "55940d09-d143-4a61-8fcd-78e86ab15b7f" });
        }
    }
}
