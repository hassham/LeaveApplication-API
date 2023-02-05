using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveApplication.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveApplicationRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicantId = table.Column<int>(type: "int", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfDays = table.Column<int>(type: "int", nullable: false),
                    GeneralComments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveApplicationRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FullName", "ManagerId", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "Sarah Johnson", 2, "Abcd1234", "sarahjohnson" },
                    { 2, "Michael Brown", 1, "Abcd1234", "michaelbrown" },
                    { 3, "Elizabeth Davis", 1, "Abcd1234", "elizabethdavis" },
                    { 4, "William Smith", 1, "Abcd1234", "williamsmith" },
                    { 5, "James Wilson", 1, "Abcd1234", "jameswilson" },
                    { 6, "Catherine White", 1, "Abcd1234", "catherinewhite" },
                    { 7, "Jennifer Anderson", 2, "Abcd1234", "jenniferanderson" },
                    { 8, "Christopher Lee", 2, "Abcd1234", "christopherlee" },
                    { 9, "Susan Taylor", 2, "Abcd1234", "susantaylor" },
                    { 10, "David Green", 2, "Abcd1234", "davidgreen" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveApplicationRequests");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
