using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RMZ.Migrations
{
    public partial class initialrrr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "city",
                columns: table => new
                {
                    Cityid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CityName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city", x => x.Cityid);
                });

            migrationBuilder.CreateTable(
                name: "facility",
                columns: table => new
                {
                    FacilityId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Facilityname = table.Column<string>(type: "text", nullable: true),
                    Cityid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facility", x => x.FacilityId);
                    table.ForeignKey(
                        name: "FK_facility_city_Cityid",
                        column: x => x.Cityid,
                        principalTable: "city",
                        principalColumn: "Cityid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "buildings",
                columns: table => new
                {
                    Bid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BuildingName = table.Column<string>(type: "text", nullable: true),
                    FacilityId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_buildings", x => x.Bid);
                    table.ForeignKey(
                        name: "FK_buildings_facility_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "facility",
                        principalColumn: "FacilityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "zones",
                columns: table => new
                {
                    ZoneId = table.Column<string>(type: "text", nullable: false),
                    BuildingBid = table.Column<int>(type: "integer", nullable: true),
                    FacilityId = table.Column<int>(type: "integer", nullable: true),
                    Floornumber = table.Column<string>(type: "text", nullable: true),
                    Eletricmeter = table.Column<decimal>(type: "numeric", nullable: false),
                    watermeteer = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zones", x => x.ZoneId);
                    table.ForeignKey(
                        name: "FK_zones_buildings_BuildingBid",
                        column: x => x.BuildingBid,
                        principalTable: "buildings",
                        principalColumn: "Bid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_zones_facility_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "facility",
                        principalColumn: "FacilityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_buildings_FacilityId",
                table: "buildings",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_facility_Cityid",
                table: "facility",
                column: "Cityid");

            migrationBuilder.CreateIndex(
                name: "IX_zones_BuildingBid",
                table: "zones",
                column: "BuildingBid");

            migrationBuilder.CreateIndex(
                name: "IX_zones_FacilityId",
                table: "zones",
                column: "FacilityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "zones");

            migrationBuilder.DropTable(
                name: "buildings");

            migrationBuilder.DropTable(
                name: "facility");

            migrationBuilder.DropTable(
                name: "city");
        }
    }
}
