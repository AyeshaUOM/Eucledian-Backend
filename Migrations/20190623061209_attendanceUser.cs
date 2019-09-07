using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class attendanceUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "studentClasses",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "studentClasses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_studentClasses_userId",
                table: "studentClasses",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_studentClasses_Users_userId",
                table: "studentClasses",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studentClasses_Users_userId",
                table: "studentClasses");

            migrationBuilder.DropIndex(
                name: "IX_studentClasses_userId",
                table: "studentClasses");

            migrationBuilder.DropColumn(
                name: "status",
                table: "studentClasses");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "studentClasses");
        }
    }
}
