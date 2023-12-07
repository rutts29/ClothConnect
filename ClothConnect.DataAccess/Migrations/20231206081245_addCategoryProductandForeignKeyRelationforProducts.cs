using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClothConnect.DataAccess.Migrations
{
    /// <summary>
    /// Migration for adding Category and Product tables and establishing a foreign key relationship between them.
    /// </summary>
    public partial class addCategoryProductandForeignKeyRelationforProducts : Migration
    {
        /// <summary>
        /// Method to define the logic for applying the migration.
        /// </summary>
        /// <param name="migrationBuilder">Builder for constructing migration commands.</param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Create the Categories table
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            // Create the Products table with a foreign key to Categories
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seller = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            // Insert initial data into Categories table
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 5, "Gown" },
                    { 2, 2, "Jacket" },
                    { 3, 3, "Dress" }
                });

            // Insert initial data into Products table
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ItemCode", "ListPrice", "Price", "Price100", "Price50", "Seller", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Exquisite evening gown perfect for gala events. Features a sleek silhouette and luxurious fabric that gracefully flows to the floor.", "ELEG001122", 120.0, 115.0, 105.0, 110.0, "Sophia Lorenz", "Elegant Evening Gown" },
                    { 2, 2, "A timeless leather jacket, ideal for adding an edge to any outfit. Made with premium quality leather for durability and style.", "CLJ8889002", 200.0, 190.0, 170.0, 180.0, "Mike Johnson", "Classic Leather Jacket" },
                    { 3, 3, "Flowy and light, this maxi dress is perfect for sunny days. Features a floral print and a comfortable, airy design.", "SBMD5555003", 80.0, 75.0, 65.0, 70.0, "Luna Rodriguez", "Summer Breeze Maxi Dress" }
                });

            // Create an index for the CategoryId column in the Products table
            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <summary>
        /// Method to define the logic for reverting the migration.
        /// </summary>
        /// <param name="migrationBuilder">Builder for constructing migration commands.</param>
        protected override void Down(MigrationBuilder migrationBuilder)
       

//Radhika Munjal
