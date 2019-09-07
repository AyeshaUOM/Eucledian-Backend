using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class attendance_dependancy_student_tbl2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Attendances_AttendanceId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_AttendanceId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AttendanceId",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "studentId",
                table: "Attendances",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_studentId",
                table: "Attendances",
                column: "studentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Students_studentId",
                table: "Attendances",
                column: "studentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Students_studentId",
                table: "Attendances");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_studentId",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "studentId",
                table: "Attendances");

            migrationBuilder.AddColumn<int>(
                name: "AttendanceId",
                table: "Students",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_AttendanceId",
                table: "Students",
                column: "AttendanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Attendances_AttendanceId",
                table: "Students",
                column: "AttendanceId",
                principalTable: "Attendances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
