using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class AddPuzles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studentClasses_Classes_classId",
                table: "studentClasses");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "classId",
                table: "studentClasses",
                newName: "ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_studentClasses_classId",
                table: "studentClasses",
                newName: "IX_studentClasses_ClassId");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Students",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_studentClasses_Classes_ClassId",
                table: "studentClasses",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClassId",
                table: "Students",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studentClasses_Classes_ClassId",
                table: "studentClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClassId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClassId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "studentClasses",
                newName: "classId");

            migrationBuilder.RenameIndex(
                name: "IX_studentClasses_ClassId",
                table: "studentClasses",
                newName: "IX_studentClasses_classId");

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Students",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_studentClasses_Classes_classId",
                table: "studentClasses",
                column: "classId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
