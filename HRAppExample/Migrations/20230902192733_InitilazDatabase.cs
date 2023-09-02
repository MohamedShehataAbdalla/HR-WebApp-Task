using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRAppExample.Migrations
{
    /// <inheritdoc />
    public partial class InitilazDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HR");

            migrationBuilder.CreateTable(
                name: "Departments",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    IdCard = table.Column<string>(type: "VARCHAR(12)", maxLength: 12, nullable: true),
                    Gender = table.Column<string>(type: "VARCHAR(6)", maxLength: 6, nullable: true),
                    JobTtitle = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "DATE", nullable: true),
                    HireDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    Salary = table.Column<decimal>(type: "Decimal(12,2)", nullable: false),
                    IsActive = table.Column<byte>(type: "TINYINT", nullable: false),
                    HasHealthInsurance = table.Column<byte>(type: "TINYINT", nullable: false),
                    HasPensionPlan = table.Column<byte>(type: "TINYINT", nullable: false),
                    Skills = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    ImageUser = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    NationalId = table.Column<string>(type: "VARCHAR(14)", maxLength: 14, nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "HR",
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "HR",
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "Finance" },
                    { 3, "Accounting" },
                    { 4, "HR" },
                    { 5, "Sales" }
                });

            migrationBuilder.InsertData(
                schema: "HR",
                table: "Employees",
                columns: new[] { "Id", "BirthDate", "DepartmentId", "Email", "FirstName", "Gender", "HasHealthInsurance", "HasPensionPlan", "HireDate", "IdCard", "ImageUser", "IsActive", "JobTtitle", "LastName", "NationalId", "Salary", "Skills" },
                values: new object[,]
                {
                    { 1001, new DateTime(1997, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Cole.Cochran@example.com", "Cochran", "male", (byte)1, (byte)0, new DateTime(2010, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2010-FI-1234", "User.png", (byte)0, "Adminstrator", "Cole", "12345678912345", 21000.00m, "ASP.NET, CSS, Oracle" },
                    { 1002, new DateTime(1994, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Wolfe.Jaclyn@example.com", "Jaclyn", "male", (byte)1, (byte)0, new DateTime(2011, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2011-IT-4563", "User.png", (byte)0, "Web Developer", "Wolfe", "12345678998765", 25000.00m, "ASP.NET, SQL Server, Javascript, CSS, HTML" },
                    { 1003, new DateTime(1995, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Jones.Warner@example.com", "Warner", "male", (byte)1, (byte)1, new DateTime(2012, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2012-HR-7896", "User.png", (byte)0, "Markting", "Jones", "12345678936985", 23000.00m, "HTML, Oracle, SQL Server" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                schema: "HR",
                table: "Employees",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Departments",
                schema: "HR");
        }
    }
}
