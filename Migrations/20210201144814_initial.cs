using Microsoft.EntityFrameworkCore.Migrations;

namespace Stores.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 10000, nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Computer & Office", null },
                    { 2, "Clothing", null },
                    { 3, "Shoe", null },
                    { 4, "Luggage & Bags", null },
                    { 5, "Watch & Jewelry", null },
                    { 6, "Home & Appliances", null },
                    { 7, "Phones & Tel", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Description", "ImagePath", "ProductName", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, "sweet 2.4G Ultra Slim wireless keyboard Portable Mute Keys Keyboards mouse combos for Mac Win XP 7 wireless Keyboard and mouse", "image1.jpeg", "Keyboards", 60000.78m },
                    { 2, 1, "Wireless Keyboard  Ultra Slim wireless keyboard Portable Mute Keys Keyboards mouse combos for Mac Win XP 7 wireless Keyboard and mouse", "image12.jpeg", "Wireless Keyboard and Mouse Mini Multimedia", 70000.11m },
                    { 8, 2, "Business brogue suede dress shoes is affordable and clean shoe you wou;d like to have and enjoy it.", "s1.jpeg", "Men fashion business brogue suede dress shoes", 20000.90m },
                    { 9, 2, "Men's Shoes Fall 2019 Sports Shoes Men's Fashion Leisure Shoes A Generic PU Small White Shoe", "s2.jpeg", "Leisure Shoes", 20000.90m },
                    { 3, 5, "Get one of these whatch. You will love it. This will change your life style", "whatch2.jpeg", "Simple Fashion Casual Business Watches", 30000.8m },
                    { 5, 5, "Get one of these whatch. You will love it. This will change your life style", "whatch1.jpeg", "SKMEI Luxury Men Watch Fashion Casual Watches", 40000.0m },
                    { 6, 5, "296 calendar men's watch waterproof quartz watch is one of the most cool whatch to have in town. Buy one for yourself today.", "whatch3.jpeg", "296 calendar men's watch waterproof quartz watch", 10000.0m },
                    { 7, 5, "Men watches casual sports watch is a waterproof quartz watch is one of the most cool whatch to have in town. Buy one for yourself today.", "whatch4.jpeg", "Men watches casual sports watch", 14000.8m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
