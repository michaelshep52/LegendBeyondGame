using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Legend.Data.Migrations
{
    /// <inheritdoc />
    public partial class sidemission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubMissions",
                columns: table => new
                {
                    SideMissionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubMissions", x => x.SideMissionId);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSideMission",
                columns: table => new
                {
                    CharactersCharacterId = table.Column<int>(type: "integer", nullable: false),
                    SideMissionsSideMissionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSideMission", x => new { x.CharactersCharacterId, x.SideMissionsSideMissionId });
                    table.ForeignKey(
                        name: "FK_CharacterSideMission_Characters_CharactersCharacterId",
                        column: x => x.CharactersCharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSideMission_SubMissions_SideMissionsSideMissionId",
                        column: x => x.SideMissionsSideMissionId,
                        principalTable: "SubMissions",
                        principalColumn: "SideMissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSideMission_SideMissionsSideMissionId",
                table: "CharacterSideMission",
                column: "SideMissionsSideMissionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterSideMission");

            migrationBuilder.DropTable(
                name: "SubMissions");
        }
    }
}
