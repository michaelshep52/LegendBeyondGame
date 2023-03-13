using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Legend.Data.Migrations
{
    /// <inheritdoc />
    public partial class CharacterInventoryRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "Players",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Players_InventoryId",
                table: "Players",
                column: "InventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Inventories_InventoryId",
                table: "Players",
                column: "InventoryId",
                principalTable: "Inventories",
                principalColumn: "InventoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Inventories_InventoryId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_InventoryId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "Players");

            migrationBuilder.AddColumn<int>(
                name: "CharacterId",
                table: "Inventories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 1,
                column: "CharacterId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 2,
                column: "CharacterId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 3,
                column: "CharacterId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 4,
                column: "CharacterId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 5,
                column: "CharacterId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 6,
                column: "CharacterId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 7,
                column: "CharacterId",
                value: 4);

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
    }
}
