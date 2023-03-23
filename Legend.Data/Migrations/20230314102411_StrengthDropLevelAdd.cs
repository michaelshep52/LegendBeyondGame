using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Legend.Data.Migrations
{
    /// <inheritdoc />
    public partial class StrengthDropLevelAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 7);

            migrationBuilder.RenameColumn(
                name: "Strength",
                table: "Characters",
                newName: "Level");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Characters",
                newName: "Strength");

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Health", "Name", "Speed", "Stamina", "Strength" },
                values: new object[,]
                {
                    { 1, 6, "Gunner", 6, 7, 5 },
                    { 2, 10, "Defender", 4, 5, 10 },
                    { 3, 6, "Ninja", 8, 7, 5 },
                    { 4, 5, "Healer", 6, 6, 5 },
                    { 5, 7, "Sniper", 7, 7, 5 },
                    { 6, 7, "Runner", 10, 8, 5 },
                    { 7, 8, "Ghost", 8, 8, 7 }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "InventoryId", "Damage", "Name", "Type" },
                values: new object[,]
                {
                    { 1, 5, "Assault rife", "Gun" },
                    { 2, 5, "Shotgun", "Gun" },
                    { 3, 5, "Katana", "Sword" },
                    { 4, 5, "Sniper", "Gun" },
                    { 5, 5, "Bowie", "Knife" },
                    { 6, 5, "Silenced Sniper", "Gun" },
                    { 7, 5, "Health Blaster", "Gun" }
                });
        }
    }
}
