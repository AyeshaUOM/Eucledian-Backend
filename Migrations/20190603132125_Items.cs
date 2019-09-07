using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Etudiant.Migrations
{
    public partial class Items : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    CompanyName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "subCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    categoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subCategories_categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    CostPrice = table.Column<decimal>(nullable: false),
                    SellPrice = table.Column<decimal>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    subCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_items_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_items_subCategories_subCategoryId",
                        column: x => x.subCategoryId,
                        principalTable: "subCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "itemPictures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(nullable: false),
                    Picture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemPictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_itemPictures_items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_itemPictures_ItemId",
                table: "itemPictures",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_items_CategoryId",
                table: "items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_items_subCategoryId",
                table: "items",
                column: "subCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_subCategories_categoryId",
                table: "subCategories",
                column: "categoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "itemPictures");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "subCategories");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
