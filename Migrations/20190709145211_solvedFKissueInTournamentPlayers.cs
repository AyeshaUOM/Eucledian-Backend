using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class solvedFKissueInTournamentPlayers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_tournamentPlayers_PlayerId",
                table: "tournamentPlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_tournamentPlayers_TournamentId",
                table: "tournamentPlayers",
                column: "TournamentId");

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
    }
}
