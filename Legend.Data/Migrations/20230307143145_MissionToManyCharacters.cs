using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Legend.Data.Migrations
{
    /// <inheritdoc />
    public partial class MissionToManyCharacters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterMission",
                columns: table => new
                {
                    CharactersCharacterId = table.Column<int>(type: "integer", nullable: false),
                    MissionsMissionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterMission", x => new { x.CharactersCharacterId, x.MissionsMissionId });
                    table.ForeignKey(
                        name: "FK_CharacterMission_Characters_CharactersCharacterId",
                        column: x => x.CharactersCharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterMission_Missions_MissionsMissionId",
                        column: x => x.MissionsMissionId,
                        principalTable: "Missions",
                        principalColumn: "MissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMission_MissionsMissionId",
                table: "CharacterMission",
                column: "MissionsMissionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterMission");
        }
    }
}
