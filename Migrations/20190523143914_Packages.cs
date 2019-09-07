using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class Packages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DefaultPayments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    classFee = table.Column<decimal>(nullable: false),
                    admissionFee = table.Column<decimal>(nullable: false),
                    latePaymentDate = table.Column<int>(nullable: false),
                    latePaymentPrecentage = table.Column<decimal>(nullable: false),
                    latePaymentEnabled = table.Column<bool>(nullable: false),
                    monthEndPrecentage = table.Column<decimal>(nullable: false),
                    monthEndEnabled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefaultPayments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    packageName = table.Column<string>(nullable: true),
                    noOfMonths = table.Column<int>(nullable: false),
                    precentage = table.Column<decimal>(nullable: false),
                    isAdmissionWaveOff = table.Column<bool>(nullable: false),
                    isActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DefaultPayments");

            migrationBuilder.DropTable(
                name: "Packages");
        }
    }
}
