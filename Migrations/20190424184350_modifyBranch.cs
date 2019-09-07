using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class modifyBranch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Branches_BranchId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "Students",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_BranchId",
                table: "Students",
                newName: "IX_Students_ParentId");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Branches",
                newName: "IsActive");

            migrationBuilder.AddColumn<DateTime>(
                name: "CRTDatetime",
                table: "Branches",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CRTDatetime",
                table: "Branches");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Students",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_ParentId",
                table: "Students",
                newName: "IX_Students_BranchId");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Branches",
                newName: "Active");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Branches_BranchId",
                table: "Students",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
