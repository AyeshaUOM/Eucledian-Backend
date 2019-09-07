using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class addedForeignKeysToTournamentPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tournamentPlayers_Students_PlayerId",
                table: "tournamentPlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_tournamentPlayers_tournament_TournamentId",
                table: "tournamentPlayers");

            migrationBuilder.AlterColumn<int>(
                name: "TournamentId",
                table: "tournamentPlayers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlayerId",
                table: "tournamentPlayers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
                name: "FK_tournamentPlayers_Students_PlayerId",
                table: "tournamentPlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_tournamentPlayers_tournament_TournamentId",
                table: "tournamentPlayers");

            migrationBuilder.AlterColumn<int>(
                name: "TournamentId",
                table: "tournamentPlayers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PlayerId",
                table: "tournamentPlayers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_tournamentPlayers_Students_PlayerId",
                table: "tournamentPlayers",
                column: "PlayerId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tournamentPlayers_tournament_TournamentId",
                table: "tournamentPlayers",
                column: "TournamentId",
                principalTable: "tournament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
