using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Controller.Migrations
{
    /// <inheritdoc />
    public partial class AddListener : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Listers",
                table: "Records",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Listers",
                table: "Artists",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Listers",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Listers",
                table: "Artists");
        }
    }
}
