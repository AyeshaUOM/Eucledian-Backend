using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class Class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "classId",
                table: "Attendances",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    StudentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Classes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_classId",
                table: "Attendances",
                column: "classId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_StudentId",
                table: "Classes",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_UserId",
                table: "Classes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Classes_classId",
                table: "Attendances",
                column: "classId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Classes_classId",
                table: "Attendances");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_classId",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "classId",
                table: "Attendances");
        }
    }
}
