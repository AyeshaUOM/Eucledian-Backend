using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class Relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "branchId",
                table: "Packages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Packages_branchId",
                table: "Packages",
                column: "branchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Branches_branchId",
                table: "Packages",
                column: "branchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Branches_branchId",
                table: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_Packages_branchId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "branchId",
                table: "Packages");
        }
    }
}
