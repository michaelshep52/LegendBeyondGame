using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Legend.Data.Migrations
{
    /// <inheritdoc />
    public partial class CharacterToInventory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CharacterId",
                table: "Inventories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_CharacterId",
                table: "Inventories",
                column: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Characters_CharacterId",
                table: "Inventories",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "CharacterId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Characters_CharacterId",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_CharacterId",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "Inventories");
        }
    }
}
