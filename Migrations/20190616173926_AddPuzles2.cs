using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class AddPuzles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "puzzles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    studentIdId = table.Column<int>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    noOfQuestions = table.Column<int>(nullable: false),
                    noOfCorrect = table.Column<int>(nullable: false),
                    assignDate = table.Column<DateTime>(nullable: false),
                    submitDate = table.Column<DateTime>(nullable: false),
                    collectedById = table.Column<int>(nullable: true),
                    correctedById = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_puzzles", x => x.id);
                    table.ForeignKey(
                        name: "FK_puzzles_Users_collectedById",
                        column: x => x.collectedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_puzzles_Users_correctedById",
                        column: x => x.correctedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_puzzles_Students_studentIdId",
                        column: x => x.studentIdId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_puzzles_collectedById",
                table: "puzzles",
                column: "collectedById");

            migrationBuilder.CreateIndex(
                name: "IX_puzzles_correctedById",
                table: "puzzles",
                column: "correctedById");

            migrationBuilder.CreateIndex(
                name: "IX_puzzles_studentIdId",
                table: "puzzles",
                column: "studentIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "puzzles");
        }
    }
}
