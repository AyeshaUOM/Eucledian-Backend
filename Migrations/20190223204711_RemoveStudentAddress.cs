using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class RemoveStudentAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Branches_BranchID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AddressLine3",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "BranchID",
                table: "Users",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_BranchID",
                table: "Users",
                newName: "IX_Users_BranchId");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Branches_BranchId",
                table: "Users",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Branches_BranchId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "Users",
                newName: "BranchID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_BranchId",
                table: "Users",
                newName: "IX_Users_BranchID");

            migrationBuilder.AlterColumn<int>(
                name: "BranchID",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine3",
                table: "Students",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Branches_BranchID",
                table: "Users",
                column: "BranchID",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
