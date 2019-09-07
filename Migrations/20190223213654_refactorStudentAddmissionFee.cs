using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class refactorStudentAddmissionFee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdmissionFree",
                table: "Students",
                newName: "AdmissionFee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdmissionFee",
                table: "Students",
                newName: "AdmissionFree");
        }
    }
}
