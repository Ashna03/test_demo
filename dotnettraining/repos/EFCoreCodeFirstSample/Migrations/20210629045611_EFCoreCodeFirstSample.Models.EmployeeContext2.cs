using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreCodeFirstSample.Migrations
{
    public partial class EFCoreCodeFirstSampleModelsEmployeeContext2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 3L, new DateTime(1988, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna.Stew@gmail.com", "Anna", "Stewart", "131-442-3553" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3L);
        }
    }
}
