using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class AddStudentPuzzle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "studentPuzzles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PuzzleId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    NoofCorrectAnswers = table.Column<int>(nullable: false),
                    IssueDate = table.Column<DateTime>(nullable: false),
                    SubmitDate = table.Column<DateTime>(nullable: false),
                    CollectedBy = table.Column<int>(nullable: false),
                    CollectedUserId = table.Column<int>(nullable: true),
                    CorrectedBy = table.Column<int>(nullable: false),
                    CorrectedUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentPuzzles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentPuzzles_Users_CollectedUserId",
                        column: x => x.CollectedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_studentPuzzles_Users_CorrectedUserId",
                        column: x => x.CorrectedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_studentPuzzles_puzzles_PuzzleId",
                        column: x => x.PuzzleId,
                        principalTable: "puzzles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_studentPuzzles_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_studentPuzzles_CollectedUserId",
                table: "studentPuzzles",
                column: "CollectedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_studentPuzzles_CorrectedUserId",
                table: "studentPuzzles",
                column: "CorrectedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_studentPuzzles_PuzzleId",
                table: "studentPuzzles",
                column: "PuzzleId");

            migrationBuilder.CreateIndex(
                name: "IX_studentPuzzles_StudentId",
                table: "studentPuzzles",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "studentPuzzles");
        }
    }
}
