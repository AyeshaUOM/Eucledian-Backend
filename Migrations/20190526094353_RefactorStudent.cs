using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class RefactorStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Students_StudentId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_StudentId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Classes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Classes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_StudentId",
                table: "Classes",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Students_StudentId",
                table: "Classes",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
