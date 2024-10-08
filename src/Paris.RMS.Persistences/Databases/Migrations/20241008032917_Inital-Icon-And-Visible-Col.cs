using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Paris.RMS.Persistences.Databases.Migrations
{
    /// <inheritdoc />
    public partial class InitalIconAndVisibleCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "ProductCategory",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Visible",
                table: "ProductCategory",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "ProductCategory");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "ProductCategory");
        }
    }
}
