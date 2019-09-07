using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Classes_classId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Users_UserId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_studentClasses_Branches_branchId",
                table: "studentClasses");

            migrationBuilder.DropIndex(
                name: "IX_studentClasses_branchId",
                table: "studentClasses");

            migrationBuilder.DropColumn(
                name: "branchId",
                table: "studentClasses");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "studentClasses",
                newName: "active");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Classes",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Classes",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Classes",
                newName: "isActive");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_UserId",
                table: "Classes",
                newName: "IX_Classes_userId");

            migrationBuilder.RenameColumn(
                name: "classId",
                table: "Attendances",
                newName: "ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendances_classId",
                table: "Attendances",
                newName: "IX_Attendances_ClassId");

            migrationBuilder.AddColumn<int>(
                name: "branchId",
                table: "Classes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "Classes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dayOfWeek",
                table: "Classes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "timeOfDay",
                table: "Classes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AttendanceId",
                table: "Attendances",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_branchId",
                table: "Classes",
                column: "branchId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_AttendanceId",
                table: "Attendances",
                column: "AttendanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Attendances_AttendanceId",
                table: "Attendances",
                column: "AttendanceId",
                principalTable: "Attendances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Classes_ClassId",
                table: "Attendances",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Branches_branchId",
                table: "Classes",
                column: "branchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Users_userId",
                table: "Classes",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Attendances_AttendanceId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Classes_ClassId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Branches_branchId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Users_userId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_branchId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_AttendanceId",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "branchId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "category",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "dayOfWeek",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "timeOfDay",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "AttendanceId",
                table: "Attendances");

            migrationBuilder.RenameColumn(
                name: "active",
                table: "studentClasses",
                newName: "Active");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Classes",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Classes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Classes",
                newName: "Active");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_userId",
                table: "Classes",
                newName: "IX_Classes_UserId");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "Attendances",
                newName: "classId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendances_ClassId",
                table: "Attendances",
                newName: "IX_Attendances_classId");

            migrationBuilder.AddColumn<int>(
                name: "branchId",
                table: "studentClasses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_studentClasses_branchId",
                table: "studentClasses",
                column: "branchId");

            migrationBuilder.CreateIndex(
                name: "IX_tournamentPlayer_TournamentIdId",
                table: "tournamentPlayer",
                column: "TournamentIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Classes_classId",
                table: "Attendances",
                column: "classId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Users_UserId",
                table: "Classes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_studentClasses_Branches_branchId",
                table: "studentClasses",
                column: "branchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
