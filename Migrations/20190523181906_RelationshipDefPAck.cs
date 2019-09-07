using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class RelationshipDefPAck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "branchId",
                table: "DefaultPayments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DefaultPayments_branchId",
                table: "DefaultPayments",
                column: "branchId");

            migrationBuilder.AddForeignKey(
                name: "FK_DefaultPayments_Branches_branchId",
                table: "DefaultPayments",
                column: "branchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DefaultPayments_Branches_branchId",
                table: "DefaultPayments");

            migrationBuilder.DropIndex(
                name: "IX_DefaultPayments_branchId",
                table: "DefaultPayments");

            migrationBuilder.DropColumn(
                name: "branchId",
                table: "DefaultPayments");
        }
    }
}
