using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class Stock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "goodReceiveNote_Mains",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LotId = table.Column<int>(nullable: false),
                    TotalCostPrice = table.Column<decimal>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    userId = table.Column<int>(nullable: true),
                    branchId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_goodReceiveNote_Mains", x => x.id);
                    table.ForeignKey(
                        name: "FK_goodReceiveNote_Mains_Branches_branchId",
                        column: x => x.branchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_goodReceiveNote_Mains_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "goodReceiveNote_Subs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Qty = table.Column<int>(nullable: false),
                    CostPrice = table.Column<decimal>(nullable: false),
                    SellPrice = table.Column<decimal>(nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    itemId = table.Column<int>(nullable: true),
                    goodReceiveNote_Mainid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_goodReceiveNote_Subs", x => x.id);
                    table.ForeignKey(
                        name: "FK_goodReceiveNote_Subs_goodReceiveNote_Mains_goodReceiveNote_Mainid",
                        column: x => x.goodReceiveNote_Mainid,
                        principalTable: "goodReceiveNote_Mains",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_goodReceiveNote_Subs_items_itemId",
                        column: x => x.itemId,
                        principalTable: "items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_goodReceiveNote_Mains_branchId",
                table: "goodReceiveNote_Mains",
                column: "branchId");

            migrationBuilder.CreateIndex(
                name: "IX_goodReceiveNote_Mains_userId",
                table: "goodReceiveNote_Mains",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_goodReceiveNote_Subs_goodReceiveNote_Mainid",
                table: "goodReceiveNote_Subs",
                column: "goodReceiveNote_Mainid");

            migrationBuilder.CreateIndex(
                name: "IX_goodReceiveNote_Subs_itemId",
                table: "goodReceiveNote_Subs",
                column: "itemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "goodReceiveNote_Subs");

            migrationBuilder.DropTable(
                name: "goodReceiveNote_Mains");
        }
    }
}
