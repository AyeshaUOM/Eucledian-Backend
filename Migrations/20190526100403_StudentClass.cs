using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class StudentClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "studentClasses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    studentId = table.Column<int>(nullable: true),
                    classId = table.Column<int>(nullable: true),
                    branchId = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentClasses_Branches_branchId",
                        column: x => x.branchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_studentClasses_Classes_classId",
                        column: x => x.classId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_studentClasses_Students_studentId",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_studentClasses_branchId",
                table: "studentClasses",
                column: "branchId");

            migrationBuilder.CreateIndex(
                name: "IX_studentClasses_classId",
                table: "studentClasses",
                column: "classId");

            migrationBuilder.CreateIndex(
                name: "IX_studentClasses_studentId",
                table: "studentClasses",
                column: "studentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "studentClasses");
        }
    }
}
