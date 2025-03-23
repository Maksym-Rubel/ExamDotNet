using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Controller.Migrations
{
    /// <inheritdoc />
    public partial class AddClients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Selles_Accounts_AccountId",
                table: "Selles");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Selles",
                newName: "ClientsId");

            migrationBuilder.RenameIndex(
                name: "IX_Selles_AccountId",
                table: "Selles",
                newName: "IX_Selles_ClientsId");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Selles_Clients_ClientsId",
                table: "Selles",
                column: "ClientsId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Selles_Clients_ClientsId",
                table: "Selles");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.RenameColumn(
                name: "ClientsId",
                table: "Selles",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Selles_ClientsId",
                table: "Selles",
                newName: "IX_Selles_AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Selles_Accounts_AccountId",
                table: "Selles",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
