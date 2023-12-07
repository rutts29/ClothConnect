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
            // [Existing Up method code with comments]
        }

        /// <summary>
        /// Method to define the logic for reverting the migration.
        /// This method will be called when rolling back this migration.
        /// </summary>
        /// <param name="migrationBuilder">Builder for constructing migration commands.</param>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop the Products table if rolling back
            migrationBuilder.DropTable(
                name: "Products");

            // Drop the Categories table if rolling back
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
//Radhika Munjal
