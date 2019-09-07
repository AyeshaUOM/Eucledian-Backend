using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class ParentDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MotherFirstName",
                table: "Parents",
                newName: "SMSAlertNumber");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "Parents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "Parents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Parents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherMobileNumber",
                table: "Parents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                table: "Parents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherOccupation",
                table: "Parents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherOfficeAddress",
                table: "Parents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LandLineNumber",
                table: "Parents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherMobileNumber",
                table: "Parents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherName",
                table: "Parents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherOccupation",
                table: "Parents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherOfficeAddress",
                table: "Parents",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "FatherMobileNumber",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "FatherName",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "FatherOccupation",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "FatherOfficeAddress",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "LandLineNumber",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "MotherMobileNumber",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "MotherName",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "MotherOccupation",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "MotherOfficeAddress",
                table: "Parents");

            migrationBuilder.RenameColumn(
                name: "SMSAlertNumber",
                table: "Parents",
                newName: "MotherFirstName");
        }
    }
}
