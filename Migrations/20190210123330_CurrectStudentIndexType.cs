using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class CurrectStudentIndexType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddmissionFeePaid",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "BatchNo",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "AddmissionDate",
                table: "Students",
                newName: "AdmissionDate");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IndexNumber",
                table: "Students",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AdmissionFree",
                table: "Students",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdmissionFree",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "AdmissionDate",
                table: "Students",
                newName: "AddmissionDate");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "IndexNumber",
                table: "Students",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<bool>(
                name: "AddmissionFeePaid",
                table: "Students",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "BatchNo",
                table: "Students",
                nullable: true);
        }
    }
}
