using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class AddTournamentPlayersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentType",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentType",
                table: "Parents",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tournamentPlayers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlayerId = table.Column<int>(nullable: true),
                    TournamentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tournamentPlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tournamentPlayers_Students_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tournamentPlayers_tournament_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "tournament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tournamentPlayers_PlayerId",
                table: "tournamentPlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_tournamentPlayers_TournamentId",
                table: "tournamentPlayers",
                column: "TournamentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tournamentPlayers");

            migrationBuilder.DropColumn(
                name: "StudentType",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ParentType",
                table: "Parents");
        }
    }
}
