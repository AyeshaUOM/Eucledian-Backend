using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class AddedStudentPuzzlesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_puzzles_Users_collectedById",
                table: "puzzles");

            migrationBuilder.DropForeignKey(
                name: "FK_puzzles_Users_correctedById",
                table: "puzzles");

            migrationBuilder.DropForeignKey(
                name: "FK_puzzles_Students_studentIdId",
                table: "puzzles");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_puzzles_collectedById",
                table: "puzzles");

            migrationBuilder.DropIndex(
                name: "IX_puzzles_correctedById",
                table: "puzzles");

            migrationBuilder.DropIndex(
                name: "IX_puzzles_studentIdId",
                table: "puzzles");

            migrationBuilder.DropColumn(
                name: "assignDate",
                table: "puzzles");

            migrationBuilder.DropColumn(
                name: "collectedById",
                table: "puzzles");

            migrationBuilder.DropColumn(
                name: "correctedById",
                table: "puzzles");

            migrationBuilder.DropColumn(
                name: "noOfCorrect",
                table: "puzzles");

            migrationBuilder.DropColumn(
                name: "studentIdId",
                table: "puzzles");

            migrationBuilder.DropColumn(
                name: "submitDate",
                table: "puzzles");

            migrationBuilder.RenameColumn(
                name: "noOfQuestions",
                table: "puzzles",
                newName: "NoofQuestions");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "puzzles",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "puzzles",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "Students",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "puzzles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExerciseType",
                table: "puzzles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tournamentPlayers_PlayerId",
                table: "tournamentPlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_tournamentPlayers_TournamentId",
                table: "tournamentPlayers",
                column: "TournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tournamentPlayers_Students_PlayerId",
                table: "tournamentPlayers",
                column: "PlayerId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tournamentPlayers_tournament_TournamentId",
                table: "tournamentPlayers",
                column: "TournamentId",
                principalTable: "tournament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_tournamentPlayers_Students_PlayerId",
                table: "tournamentPlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_tournamentPlayers_tournament_TournamentId",
                table: "tournamentPlayers");

            migrationBuilder.DropIndex(
                name: "IX_tournamentPlayers_PlayerId",
                table: "tournamentPlayers");

            migrationBuilder.DropIndex(
                name: "IX_tournamentPlayers_TournamentId",
                table: "tournamentPlayers");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "puzzles");

            migrationBuilder.DropColumn(
                name: "ExerciseType",
                table: "puzzles");

            migrationBuilder.RenameColumn(
                name: "NoofQuestions",
                table: "puzzles",
                newName: "noOfQuestions");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "puzzles",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "puzzles",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "Students",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<DateTime>(
                name: "assignDate",
                table: "puzzles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "collectedById",
                table: "puzzles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "correctedById",
                table: "puzzles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "noOfCorrect",
                table: "puzzles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "studentIdId",
                table: "puzzles",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "submitDate",
                table: "puzzles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

            migrationBuilder.AddForeignKey(
                name: "FK_puzzles_Users_collectedById",
                table: "puzzles",
                column: "collectedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_puzzles_Users_correctedById",
                table: "puzzles",
                column: "correctedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_puzzles_Students_studentIdId",
                table: "puzzles",
                column: "studentIdId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
