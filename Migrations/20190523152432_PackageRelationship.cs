using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class PackageRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "packageId",
                table: "DefaultPayments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DefaultPayments_packageId",
                table: "DefaultPayments",
                column: "packageId");

            migrationBuilder.AddForeignKey(
                name: "FK_DefaultPayments_Packages_packageId",
                table: "DefaultPayments",
                column: "packageId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DefaultPayments_Packages_packageId",
                table: "DefaultPayments");

            migrationBuilder.DropIndex(
                name: "IX_DefaultPayments_packageId",
                table: "DefaultPayments");

            migrationBuilder.DropColumn(
                name: "packageId",
                table: "DefaultPayments");
        }
    }
}
