using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Controller.Migrations
{
    /// <inheritdoc />
    public partial class ClientCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BuyCount",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyCount",
                table: "Clients");
        }
    }
}
