using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class StudentAttendaceFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailabilityToday",
                table: "Students");

            migrationBuilder.AddColumn<DateTime>(
                name: "datetime",
                table: "studentClasses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "datetime",
                table: "studentClasses");

            migrationBuilder.AddColumn<bool>(
                name: "AvailabilityToday",
                table: "Students",
                nullable: false,
                defaultValue: false);
        }
    }
}
