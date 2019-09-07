using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class AddFeesToTournamentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ExternalFee",
                table: "tournament",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "InternalFee",
                table: "tournament",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExternalFee",
                table: "tournament");

            migrationBuilder.DropColumn(
                name: "InternalFee",
                table: "tournament");
        }
    }
}
